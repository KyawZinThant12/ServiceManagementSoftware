﻿using Model;
using ServiceManagementSoftware.Model;
using System.Globalization;
using System.Reflection;
using System.Resources;
using va = ServiceManagementSoftware.Shared.Variables;

namespace ServiceManagementSoftware.Helpers
{
    public class LangHelper
    {
        static ResourceManager rm;
        static CultureInfo ci;

        public static void Initialize()
        {
            // load options from database
            var fontOption = va.Options.Find(o => o.optionId == OptionId.Font);
            var langOption = va.Options.Find(o => o.optionId == OptionId.Language);

            // set up font
            if (fontOption?.value == "1")
                va.SelectedFont = "Pyidaungsu";
            else
                va.SelectedFont = "Zawgyi-One";

            // set up lang
            string cName = "";
            switch (langOption?.value)
            {
                case "1": // zawgyi
                    cName = "my";
                    break;
                case "2": // unicode
                    cName = "my-MM";
                    break;
                default: // english
                    cName = "en";
                    break;
            }
            ci = new CultureInfo(cName);

            rm = new ResourceManager("ServiceManagementSoftware.Languages.Language", Assembly.GetExecutingAssembly());
        }
        
        public static string GetLangString(string langId)
        {
            return rm.GetString(langId, ci);
        }

        public static string GetLangString(ControlInfo info)
        {
            return GetLangString(info.langId);
        }
    }
}
