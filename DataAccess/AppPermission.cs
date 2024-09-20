using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class AppPermission
    {
        public static IEnumerable<m.AppPermission> Get(string userId)
        {
            using (var db = da.Con())
            {
                return db.Query<m.AppPermission, m.AppForm, m.AppPermission>(
                    @"SELECT * 
                    FROM AppPermission AS p
                    RIGHT OUTER JOIN AppForm AS f ON p.formId=f.formId AND p.userId=@userId
                    ORDER BY f.sort",
                    (per, form) =>
                    {
                        per.userId = userId;
                        per.formId = form.formId;
                        per.appForm = form;

                        return per;
                    },
                    new { userId },
                    splitOn: "formId");
            }
        }

        public static void InsertPermitions(string userId)
        {
            using (var db = da.Con())
            {
                db.Execute(
                    @"INSERT INTO AppPermission
                    SELECT @userId, formId, 1, 
	                    (CASE WHEN type=0 OR type=1 THEN 1 ELSE 0 END)
                    FROM AppForm",
                    new { userId });
            }
        }

        public static void Insert(IEnumerable<m.AppPermission> perms)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Insert<m.AppPermission>(), perms);
            }
        }

        public static void Delete(string userId)
        {
            using (var db = da.Con())
            {
                db.Execute("DELETE FROM AppPermission WHERE userId=@userId",
                    new { userId });
            }
        }
    }
}
