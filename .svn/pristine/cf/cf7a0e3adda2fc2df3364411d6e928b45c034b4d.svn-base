using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class ActionLog
    {
        public static IEnumerable<m.ActionLog> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.ActionLog>(da.Select<m.ActionLog>());
            }
        }

        public static m.ActionLog Get(int logId)
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.ActionLog>(da.Select<m.ActionLog>("logId"),
                    new { logId });
            }
        }

        public static IEnumerable<m.ActionLog> Get(m.PeriodUser puser)
        {
            using (var db = da.Con())
            {
                string condition = "";
                if (!string.IsNullOrWhiteSpace(puser.userId))
                    condition = "actionBy=@userId AND ";

                return db.Query<m.ActionLog>(
                    $@"SELECT *
                    FROM ActionLog
                    WHERE {condition}actionDate BETWEEN @startDate AND @endDate 
                    ORDER BY logId DESC",
                    new { puser.userId, puser.startDate, puser.endDate });
            }
        }

        public static long Insert(m.ActionLog actionLog)
        {
            using (var db = da.Con())
            {
                object result = db.ExecuteScalar(da.InsertAutoId<m.ActionLog>("logId"), actionLog);
                return long.Parse(result.ToString());
            }
        }

        public static void Update(m.ActionLog actionLog)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.ActionLog>("logId"), actionLog);
            }
        }

        public static void Delete(int logId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.ActionLog>("logId"),
                    new { logId });
            }
        }
    }
}
