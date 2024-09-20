using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagementSoftware.Shared
{
    public static class Extensions
    {
        public static bool ToBool(this object value)
        {
            switch (value?.ToString().ToLower())
            {
                case "true":
                    return true;
                case "false":
                    return false;
                case "1":
                    return true;
                case "0":
                    return false;
                default:
                    return false;
            }
        }
    }
}
