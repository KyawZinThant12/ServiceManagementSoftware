using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class Task
    {
        public static IEnumerable<m.Task> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.Task>(da.Select<m.Task>());
            }
        }

        public static IEnumerable<m.Task> Get(bool inActive)
        {
            using (var db = da.Con())
            {
                return db.Query<m.Task>(da.Select<m.Task>("inActive"), new { inActive });
            }
        }

        public static m.Task Get(int taskId)
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.Task>(da.Select<m.Task>("taskId"),
                    new { taskId });
            }
        }

        public static int Insert(m.Task task)
        {
            using (var db = da.Con())
            {
                object result = db.ExecuteScalar(da.InsertAutoId<m.Task>("taskId"), task);

                if (task.taskCharges != null)
                    TaskCharge.Insert(task.taskCharges);

                return int.Parse(result.ToString());
            }
        }

        public static void Update(m.Task task)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.Task>("taskId"), task);

                TaskCharge.Delete(task.taskId);
                if (task.taskCharges != null)
                    TaskCharge.Insert(task.taskCharges);
            }
        }

        public static void Delete(int taskId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.Task>("taskId"),
                    new { taskId });
            }
        }
    }
}
