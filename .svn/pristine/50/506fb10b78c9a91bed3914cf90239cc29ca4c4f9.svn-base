using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;
using System;
using System.Linq;

namespace DataAccess
{
    public class TaskItem
    {
        public static IEnumerable<m.TaskItem> Get(long vId)
        {
            using (var db = da.Con())
            {
                return db.Query<m.TaskItem, m.Task, m.TaskItem>(
                    @"SELECT * 
                    FROM TaskItem 
                    LEFT OUTER JOIN Task ON TaskItem.taskId=Task.taskId
                    WHERE TaskItem.vId=@vId",
                    (item, task) =>
                    {
                        item.task = task;

                        return item;
                    },
                    new { vId },
                    splitOn: "taskId");
            }
        }

        public static IEnumerable<m.TaskItemDetail> GetByStatus(m.TStatus status, m.Period period = null)
        {
            using (var db = da.Con())
            {
                string condition = $"WHERE v.deleted<>1 AND t.status={(int)status}";

                if (period != null)
                    condition += $" AND t.createAt BETWEEN @startDate AND @endDate";

                return db.Query<m.TaskItemDetail>(
                    $@"SELECT t.*, e.empName AS asignee, k.taskName, v.dueDate, c.customerName
                    FROM TaskItem AS t
                    LEFT OUTER JOIN Task AS k ON t.taskId=k.taskId
                    LEFT OUTER JOIN Employee AS e ON t.empId=e.empId
                    LEFT OUTER JOIN Voucher AS v ON t.vId=v.vId
                    LEFT OUTER JOIN Customer AS c ON v.customerId=c.customerId
                    {condition}",
                    new { period?.startDate, period?.endDate });
            }
        }

        public static IEnumerable<long> GetPendingTaskByVoucher(long vId)
        {
            using (var db = da.Con())
            {
                return db.Query<long>(
                    "SELECT taskItemId FROM TaskItem WHERE vId=@vId AND status=@status",
                    new { vId, status = (int)m.TStatus.Pending });
            }
        }

        /// <summary>
        /// Return voucher id if no pending task exists
        /// </summary>
        public static long FinishTask(long taskItemId)
        {
            using (var db = da.Con())
            {
                db.Execute(
                    @"UPDATE TaskItem 
                    SET status=@status,finishAt=@date 
                    WHERE taskItemId=@taskItemId",
                    new { taskItemId, status = (int)m.TStatus.Finish, date = DateTime.Now });

                // finish voucher
                long vId = db.QueryFirstOrDefault<long>(
                    "SELECT vId FROM TaskItem WHERE taskItemId=@taskItemId",
                    new { taskItemId });
                var ptasks = GetPendingTaskByVoucher(vId);

                if (ptasks.Count() == 0)
                {
                    //Voucher.UpdateStatus(vId, m.VStatus.Finish);

                    return vId;
                }
                else
                    return 0;
            }
        }

        public static void Insert(IEnumerable<m.TaskItem> taskItems)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Insert<m.TaskItem>("taskItemId"), taskItems);
            }
        }

        public static void Delete(long vId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.TaskItem>("vId"),
                    new { vId });
            }
        }
    }
}
