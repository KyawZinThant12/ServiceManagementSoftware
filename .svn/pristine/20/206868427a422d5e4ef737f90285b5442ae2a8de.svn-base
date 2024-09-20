using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace DataAccess.Shared
{
    public class DbAccess
    {
        public static Func<DbConnection> Con = () => new SqlConnection(SetUp.ConString);

        #region "Get Query String"

        public static string Select<T>(params string[] keys)
        {
            return "SELECT * FROM " + typeof(T).Name + GetConditions(keys);
        }

        public static string Insert<T>(params string[] keys)
        {
            return "INSERT INTO " + typeof(T).Name + "(" + GetPropertyNames<T>(0, keys) + ")" +
                " VALUES(" + GetPropertyNames<T>(1, keys) + ")";
        }

        public static string InsertAutoId<T>(string key)
        {
            return "INSERT INTO " + typeof(T).Name + "(" + GetPropertyNames<T>(0, key) + ")" +
                " VALUES(" + GetPropertyNames<T>(1, key) + ") SELECT SCOPE_IDENTITY()";
        }

        public static string Update<T>(params string[] keys)
        {
            return "UPDATE " + typeof(T).Name +
                " SET " + GetPropertyNames<T>(2, keys) + GetConditions(keys);
        }

        public static string Delete<T>(params string[] keys)
        {
            return "DELETE FROM " + typeof(T).Name + GetConditions(keys);
        }

        #endregion

        #region "Helper Methods"

        //0 => col // 1 => @col // 2 => col=@col
        public static string GetPropertyNames<T>(int mode, params string[] ignore)
        {
            string result = "";
            foreach (var name in typeof(T).GetProperties().Where(p => !ignore.Contains(p.Name)).GetValidName())
            {
                switch (mode)
                {
                    case 1:
                        result += "@" + name + ",";
                        break;
                    case 2:
                        result += name + "=@" + name + ",";
                        break;
                    default:
                        result += name + ",";
                        break;
                }
            }

            return result.Length > 0 ? result.Remove(result.Length - 1) : result;
        }

        public static string GetConditions(string[] keys)
        {
            if (keys.Length == 0) return "";

            string result = " WHERE ";
            foreach (var key in keys)
            {
                result += key + "=@" + key + " AND ";
            }

            return result.Length > 0 ? result.Remove(result.Length - 4) : result;
        }

        #endregion
    }

    public static class Extensions
    {
        public static IEnumerable<string> GetValidName(this IEnumerable<PropertyInfo> info)
        {
            return info.Where(i => i.PropertyType.IsValueType
                                || i.PropertyType.IsPrimitive
                                || i.PropertyType == typeof(string))
                .Select(s => s.Name);
        }
    }
}
