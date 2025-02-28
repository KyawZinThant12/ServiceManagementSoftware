﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceManagementSoftware.Helpers
{
    public static class PrintReport
    {
        private static int m_currentPageIndex;
        private static IList<Stream> m_streams;

        public static Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void Export(LocalReport report, bool print = true)
        {
            var settings = report.GetDefaultPageSettings();

            string deviceInfo =
              $@"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                    <PageWidth>{settings.PaperSize.Width * 100}in</PageWidth>
                    <PageHeight>{settings.PaperSize.Height * 100}in</PageHeight>
                    <MarginTop>{settings.Margins.Top * 100}in</MarginTop>
                    <MarginLeft>{settings.Margins.Left * 100}in</MarginLeft>
                    <MarginRight>{settings.Margins.Right * 100}in</MarginRight>
                    <MarginBottom>{settings.Margins.Bottom * 100}in</MarginBottom>
                </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }


        // Handler for PrintPageEvents
        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
            {
                MessageBox.Show("Error: no stream to print.");
                return;
            }
            
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                MessageBox.Show("Error: cannot find the default printer.");
                return;
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static void PrintToPrinter(this LocalReport report)
        {
            Export(report);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
    }
}
