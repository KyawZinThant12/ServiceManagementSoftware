using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class Customer
    {
        public static IEnumerable<m.Customer> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.Customer>(da.Select<m.Customer>());
            }
        }

        public static IEnumerable<m.Customer> Get(bool inActive)
        {
            using (var db = da.Con())
            {
                return db.Query<m.Customer>(da.Select<m.Customer>("inActive"), new { inActive });
            }
        }

        public static m.Customer Get(int customerId)
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.Customer>(da.Select<m.Customer>(),
                    new { customerId });
            }
        }

        public static int Insert(m.Customer customer)
        {
            using (var db = da.Con())
            {
                object result = db.ExecuteScalar(da.InsertAutoId<m.Customer>("customerId"), customer);
                return int.Parse(result.ToString());
            }
        }

        public static void Update(m.Customer customer)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.Customer>("customerId"), customer);
            }
        }

        public static void Delete(int customerId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.Customer>("customerId"),
                    new { customerId });
            }
        }
    }
}
