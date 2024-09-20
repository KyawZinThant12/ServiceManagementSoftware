using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class TaskCharge
    {
        public static IEnumerable<m.TaskCharge> Get(int taskId)
        {
            using (var db = da.Con())
            {
                return db.Query<m.TaskCharge>(
                    "SELECT * FROM TaskCharge WHERE taskId=@taskId",
                    new { taskId });
            }
        }

        public static void Insert(IEnumerable<m.TaskCharge> charges)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Insert<m.TaskCharge>(), charges);
            }
        }

        public static void Delete(int taskId)
        {
            using (var db = da.Con())
            {
                db.Execute("DELETE FROM TaskCharge WHERE taskId=@taskId",
                    new { taskId });
            }
        }
    }
}
