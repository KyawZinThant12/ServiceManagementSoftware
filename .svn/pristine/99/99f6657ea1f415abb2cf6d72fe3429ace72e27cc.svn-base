using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;
using System.Linq;

namespace DataAccess
{
    public class Report
    {
        // Voucher Cash Received
        public static IEnumerable<m.VoucherAmount> GetVCashReceived(m.Period period)
        {
            using (var db = da.Con())
            {
                return db.Query<m.VoucherAmount>(
                    @"SELECT *
                    FROM
                    (
	                    SELECT v.vId, v.vNo, v.vDate, c.customerName, v.vTol, v.disAmt, 
		                    (CASE WHEN v.preDate BETWEEN @startDate AND @endDate THEN v.preAmt ELSE 0 END) AS preAmt, 
		                    (CASE WHEN v.postDate BETWEEN @startDate AND @endDate THEN v.postAmt ELSE 0 END) AS postAmt
	                    FROM
	                    (
		                    SELECT vId, vNo, vDate, vTol, disAmt, preDate, postDate, preAmt, postAmt, customerId
		                    FROM Voucher
		                    WHERE deleted<>1 AND (preDate BETWEEN @startDate AND @endDate OR postDate BETWEEN @startDate AND @endDate)
	                    ) v
	                    LEFT OUTER JOIN Customer AS c ON v.customerId=c.customerId
                    ) t
                    WHERE t.preAmt > 0 OR t.postAmt > 0",
                    new { period.startDate, period.endDate });
            }
        }

        // Popular Services
        public static IEnumerable<m.TaskItemCount> GetTaskItemCounts(m.Period period)
        {
            using (var db = da.Con())
            {
                return db.Query<m.TaskItemCount>(
                    @"WITH tbl AS
                    (
                        SELECT i.taskId, SUM(i.qty) AS count, SUM(i.amount) AS tolAmt
                        FROM TaskItem AS i
                        LEFT OUTER JOIN Task AS t ON i.taskId=t.taskId
                        LEFT OUTER JOIN Voucher AS v ON i.vId=v.vId
                        WHERE v.deleted<>1 AND v.status=@status AND (v.vDate BETWEEN @startDate AND @endDate)
                        GROUP BY i.taskId
                    )
                    SELECT tbl.*, t.taskName
                    FROM tbl
                    LEFT OUTER JOIN Task AS t ON tbl.taskId=t.taskId",
                    new { status = (int)m.VStatus.Finish, period.startDate, period.endDate });
            }
        }

        // Cash Received By Services
        public static IEnumerable<m.TaskItemTolAmt> GetTaskItemTolAmts(m.Period period, int taskId, int? customerId)
        {
            using (var db = da.Con())
            {
                string condition = "";

                if (taskId > 0)
                    condition += "i.taskId=@taskId AND ";
                if (customerId > 0)
                    condition += "v.customerId=@customerId AND ";
                else if (customerId == null)
                    condition += "v.customerId IS NULL AND ";

                condition = $@"WHERE v.deleted<>1 AND {condition}(v.status={(int)m.VStatus.Paid} OR v.status={(int)m.VStatus.Finish})
                            AND (v.vDate BETWEEN @startDate AND @endDate)";

                return db.Query<m.TaskItemTolAmt>(
                    $@"WITH tbl AS
                    (
                        SELECT i.vId, i.taskId, SUM(i.qty) AS count, SUM(i.amount) AS tolAmt
                        FROM TaskItem AS i
                        LEFT OUTER JOIN Task AS t ON i.taskId=t.taskId
                        LEFT OUTER JOIN Voucher AS v ON i.vId=v.vId
                        {condition}
                        GROUP BY i.vId, i.taskId
                    )
                    SELECT tbl.*, v.vNo, v.vDate, c.customerName, t.taskName
                    FROM tbl
                    LEFT OUTER JOIN Task AS t ON tbl.taskId=t.taskId
                    LEFT OUTER JOIN Voucher AS v ON tbl.vId=v.vId
                    LEFT OUTER JOIN Customer AS c ON v.customerId=c.customerId",
                    new { taskId, customerId, period.startDate, period.endDate });
            }
        }

        // Profit And Loss
        public static List<m.ProfitAndLoss> GetProfitAndLoss(m.Period period)
        {
            using (var db = da.Con())
            {
                var pList = new List<m.ProfitAndLoss>();
                decimal amt;

                // voucher cash received
                amt = db.Query<decimal>(@"SELECT ISNULL(SUM(preAmt+postAmt), 0)
                                        FROM Voucher
                                        WHERE deleted<>1 AND (vDate BETWEEN @startDate AND @endDate)",
                                        new { period.startDate, period.endDate })
                                        .FirstOrDefault();
                pList.Add(new m.ProfitAndLoss
                {
                    name = "Voucher Cash Received",
                    type = m.CType.Income,
                    amount = amt
                });

                // income and expense
                var list = db.Query<m.ProfitAndLoss>(
                    @"SELECT accId AS name, type, SUM(amount) AS amount
                    FROM Cash
                    WHERE cDate BETWEEN @startDate AND @endDate
                    GROUP BY type,accId",
                    new { period.startDate, period.endDate });
                pList.AddRange(list);

                return pList;
            }
        }

        // Daily Summary
        public static m.DailySummary GetDailySummary(m.Period period)
        {
            using (var db = da.Con())
            {
                var services = db.Query<m.DSService>(
                    @"SELECT MAX(t.taskName) AS name, SUM(i.qty) AS qty, SUM(i.cost) AS price, SUM(i.amount) AS amount, 'service' AS type
                    FROM TaskItem AS i
                    LEFT OUTER JOIN Task As t ON i.taskId=t.taskId
                    LEFT OUTER JOIN Voucher AS v ON i.vId=v.vId
                    WHERE v.deleted<>1 AND (v.vDate BETWEEN @startDate AND @endDate)
                    GROUP BY i.taskId
                    UNION ALL
                    SELECT MAX(c.name) AS name, SUM(vc.qty) AS qty, SUM(vc.price) AS price, SUM(vc.amount) AS amount, 'stock' AS type
                    FROM VoucherCharge AS vc
                    LEFT OUTER JOIN Charge As c ON vc.chargeId=c.chargeId
                    LEFT OUTER JOIN Voucher AS v ON vc.vId=v.vId
                    WHERE v.deleted<>1 AND (v.vDate BETWEEN @startDate AND @endDate)
                    GROUP BY vc.chargeId",
                    period);

                var result = db.QueryFirstOrDefault<m.DailySummary>(
                    @"SELECT SUM(vTol) AS tolAmount, SUM(disAmt) AS disAmt, SUM(preAmt) AS preAmt,
                        SUM(postAmt) AS postAmt
                    FROM
                    (
                        SELECT vTol, disAmt, 0 AS preAmt, 0 AS postAmt
                                        FROM Voucher
                        WHERE deleted<>1 AND (vDate BETWEEN @startDate AND @endDate)
                        UNION ALL
                        SELECT 0 AS vTol, 0 As disAmt, (CASE WHEN preDate BETWEEN @startDate AND @endDate THEN preAmt ELSE 0 END) AS preAmt, 
	                        (CASE WHEN postDate BETWEEN @startDate AND @endDate THEN postAmt ELSE 0 END) AS postAmt
                        FROM Voucher
                        WHERE deleted<>1
                    ) t",
                    period);

                result.services = services.ToArray();

                return result;
            }
        }

        // Deleted Voucher List
        public static IEnumerable<m.Voucher> GetDeletedVoucher(m.Period period)
        {
            using (var db = da.Con())
            {
                return db.Query<m.Voucher>(
                    @"SELECT * 
                    FROM Voucher
                    WHERE deleted=1 AND vDate BETWEEN @startDate AND @endDate",
                    period);
            }
        }
    }
}
