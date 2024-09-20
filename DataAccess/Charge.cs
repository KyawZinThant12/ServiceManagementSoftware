using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class Charge
    {
        public static IEnumerable<m.Charge> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.Charge>(da.Select<m.Charge>());
            }
        }

        public static IEnumerable<m.Charge> Get(bool inActive)
        {
            using (var db = da.Con())
            {
                return db.Query<m.Charge>(da.Select<m.Charge>("inActive"), new { inActive });
            }
        }

        public static m.Charge Get(int chargeId)
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.Charge>(da.Select<m.Charge>("chargeId"),
                    new { chargeId });
            }
        }

        public static int Insert(m.Charge charge)
        {
            using (var db = da.Con())
            {
                object result = db.ExecuteScalar(da.InsertAutoId<m.Charge>("chargeId"), charge);
                return int.Parse(result.ToString());
            }
        }

        public static void Update(m.Charge charge)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.Charge>("chargeId"), charge);
            }
        }

        public static void Delete(int chargeId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.Charge>("chargeId"),
                    new { chargeId });
            }
        }
    }
}
