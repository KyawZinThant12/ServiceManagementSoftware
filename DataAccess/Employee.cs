using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class Employee
    {
        public static IEnumerable<m.Employee> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.Employee>(da.Select<m.Employee>());
            }
        }

        public static IEnumerable<m.Employee> Get(bool inActive)
        {
            using (var db = da.Con())
            {
                return db.Query<m.Employee>(da.Select<m.Employee>("inActive"), new { inActive });
            }
        }

        public static m.Employee Get(int empId)
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.Employee>(da.Select<m.Employee>("empId"),
                    new { empId });
            }
        }

        public static int Insert(m.Employee employee)
        {
            using (var db = da.Con())
            {
                object result = db.ExecuteScalar(da.InsertAutoId<m.Employee>("empId"), employee);
                return int.Parse(result.ToString());
            }
        }

        public static void Update(m.Employee employee)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.Employee>("empId"), employee);
            }
        }

        public static void Delete(int empId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.Employee>("empId"),
                    new { empId });
            }
        }
    }
}
