using ServiceManagementSoftware.Forms;
using ServiceManagementSoftware.Model;
using System.Collections.Generic;
using m = Model;

namespace ServiceManagementSoftware.Shared
{
    public class Variables
    {
        public static MainForm FrmMain;

        public static UserInfo CurrentUser;
        public static List<m.AppPermission> Permissions;
        public static PrinterInfo PrinterInfo;
        public static m.BusinessInfo BusinessInfo;

        public static string SelectedFont;
        public static string SelectedLang;
        public static List<m.AppOption> Options;

        public const string RegistryPath = @"Software\SMS";
    }
}
