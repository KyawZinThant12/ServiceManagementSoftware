using Dapper;
using System.Collections.Generic;
using da = DataAccess.Shared.DbAccess;
using m = Model;

namespace DataAccess
{
    public class AppOption
    {
        public static IEnumerable<m.AppOption> Get()
        {
            using (var db = da.Con())
            {
                var val = da.Select<m.AppOption>();
                return db.Query<m.AppOption>(da.Select<m.AppOption>());
            }
        }

        public static m.AppOption Get(int optionId)
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.AppOption>(da.Select<m.AppOption>("optionId"),
                    new { optionId });
            }
        }

        public static void Insert(m.AppOption option)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Insert<m.AppOption>(), option);
            }
        }

        public static void Update(m.AppOption option)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.AppOption>("optionId"), option);
            }
        }

        public static void Update(m.OptionId optionId, string value)
        {
            using (var db = da.Con())
            {
                db.Execute(
                    "UPDATE AppOption SET value=@value WHERE optionId=@optionId", 
                    new { optionId=(int)optionId, value });
            }
        }

        public static void Delete(int optionId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.AppOption>("optionId"),
                    new { optionId });
            }
        }
    }
}
