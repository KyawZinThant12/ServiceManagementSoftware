using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class AppUser
    {
        public static IEnumerable<m.AppUser> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.AppUser>(da.Select<m.AppUser>());
            }
        }

        public static m.AppUser Get(string userId)
        {
            using (var db = da.Con())
            {
                var user = db.QueryFirstOrDefault<m.AppUser>(da.Select<m.AppUser>("userId"),
                    new { userId });

                if (user != null)
                    user.appPermissions = AppPermission.Get(user.userId);

                return user;
            }
        }

        public static m.AppUser Get(string userId, string pwd)
        {
            using (var db = da.Con())
            {
                var user = db.QueryFirstOrDefault<m.AppUser>(
                    @"SELECT * 
                    FROM AppUser
                    WHERE userId=@userId AND pwd=@pwd",
                    new { userId, pwd });

                if (user != null)
                    user.appPermissions = AppPermission.Get(user.userId);

                return user;
            }
        }

        public static IEnumerable<m.AppUser> Get(bool inActive)
        {
            using (var db = da.Con())
            {
                return db.Query<m.AppUser>(da.Select<m.AppUser>("inActive"), new { inActive });
            }
        }

        public static void Insert(m.AppUser user)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Insert<m.AppUser>(), user);
            }
        }

        public static void Update(m.AppUser user)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.AppUser>("userId"), user);
            }
        }

        public static void Delete(string userId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.AppUser>("userId"),
                    new { userId });
            }
        }
    }
}
