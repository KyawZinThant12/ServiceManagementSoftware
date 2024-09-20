using Dapper;
using da = DataAccess.Shared.DbAccess;
using m = Model;

namespace DataAccess
{
    public class BusinessInfo
    {
        public static m.BusinessInfo Get()
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.BusinessInfo>(da.Select<m.BusinessInfo>());
            }
        }

        public static void Insert(m.BusinessInfo businessInfo)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Insert<m.BusinessInfo>(), businessInfo);
            }
        }

        public static void Update(m.BusinessInfo businessInfo)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.BusinessInfo>("businessId"), businessInfo);
            }
        }

        public static void Delete(int businessId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.BusinessInfo>("businessId"),
                    new { businessId });
            }
        }
    }
}
