using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;
using System;

namespace DataAccess
{
    public class Voucher
    {
        public static IEnumerable<m.Voucher> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.Voucher>(da.Select<m.Voucher>());
            }
        }

        public static m.Voucher Get(long vId)
        {
            using (var db = da.Con())
            {
                var voucher = db.QueryFirstOrDefault<m.Voucher>(da.Select<m.Voucher>("vId"),
                            new { vId });

                if (voucher != null)
                {
                    voucher.taskItems = TaskItem.Get(voucher.vId);
                    voucher.voucherCharges = VoucherCharge.Get(voucher.vId);
                }

                return voucher;
            }
        }

        public static long Insert(m.Voucher voucher)
        {
            using (var db = da.Con())
            {
                voucher.vNo = GenerateVno();

                var result = db.ExecuteScalar(da.InsertAutoId<m.Voucher>("vId"), voucher);
                long newId = long.Parse(result.ToString());

                if (voucher.taskItems != null)
                {
                    foreach (var item in voucher.taskItems) item.vId = newId;
                    TaskItem.Insert(voucher.taskItems);
                }

                if (voucher.voucherCharges != null)
                {
                    foreach (var item in voucher.voucherCharges) item.vId = newId;
                    VoucherCharge.Insert(voucher.voucherCharges);
                }

                return newId;
            }
        }

        public static void Update(m.Voucher voucher)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.Voucher>("vId"), voucher);

                if (voucher.taskItems != null)
                {
                    foreach (var item in voucher.taskItems)
                    {
                        if (item.vId == 0)
                            item.vId = voucher.vId;
                    }
                    TaskItem.Delete(voucher.vId);
                    TaskItem.Insert(voucher.taskItems);
                }

                if (voucher.voucherCharges != null)
                {
                    foreach (var item in voucher.voucherCharges)
                    {
                        if (item.vId == 0)
                            item.vId = voucher.vId;
                    }
                    VoucherCharge.Delete(voucher.vId);
                    VoucherCharge.Insert(voucher.voucherCharges);
                }
            }
        }

        public static void Delete(long vId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.Voucher>("vId"),
                    new { vId });
            }
        }

        public static void SetLock(long vId, bool locked)
        {
            using (var db = da.Con())
            {
                db.Execute("UPDATE Voucher SET locked=@locked WHERE vId=@vId",
                    new { vId, locked });
            }
        }

        public static void SetDelete(long vId, bool deleted)
        {
            using (var db = da.Con())
            {
                db.Execute("UPDATE Voucher SET deleted=@deleted WHERE vId=@vId",
                    new { vId, deleted });
            }
        }

        public static string GenerateVno()
        {
            using (var db = da.Con())
            {
                string preFix = "V" + DateTime.Now.ToString("yyMM");

                string maxVno = db.QueryFirstOrDefault<string>(
                    $"SELECT TOP(1)vNo FROM Voucher WHERE vNo LIKE '{preFix}%' ORDER BY vNo DESC");

                if (maxVno == null)
                {
                    return preFix + "0001";
                }
                else
                {
                    string serial = maxVno.Replace(preFix, "");

                    int num;
                    if (int.TryParse(serial, out num))
                        return preFix + (num + 1).ToString("0000");
                    else
                        return preFix + "0000";
                }
            }
        }

        public static void UpdateStatus(long vId, m.VStatus status)
        {
            using (var db = da.Con())
            {
                db.Execute("UPDATE Voucher SET status=@status WHERE vId=@vId",
                    new { vId, status=(int)status });
            }
        }

        //public static IEnumerable<m.VoucherAmount> GetFinishedVouchers()
        //{
        //    using (var db = da.Con())
        //    {
        //        return db.Query<m.VoucherAmount>(
        //            @"SELECT *, c.customerName
        //            FROM Voucher AS v
        //            LEFT OUTER JOIN Customer AS c ON v.customerId=c.customerId
        //            WHERE v.status=@status",
        //            new { status = (int)m.VStatus.Finish });
        //    }
        //}

        // can be merged 
        public static IEnumerable<m.VoucherAmount> GetByCustomerStatus(m.PeriodCusStatus pcs)
        {
            using (var db = da.Con())
            {
                string condition = "";
                if (pcs.customerId > 0)
                    condition += "c.customerId=@customerId AND ";
                else if (pcs.customerId == null)
                    condition += "c.customerId IS NULL AND ";

                if (pcs.status != null)
                {
                    if (pcs.status == (m.VStatus.Paid | m.VStatus.Finish)) // unpaid
                        condition += $"(v.status={(int)m.VStatus.Paid} OR v.status={(int)m.VStatus.Finish}) AND ";
                    else if (pcs.status == (m.VStatus.Paid | m.VStatus.Pending)) // unfinished
                        condition += $"(v.status={(int)m.VStatus.Paid} OR v.status={(int)m.VStatus.Pending}) AND ";
                    else
                        condition += $"v.status={(int)pcs.status} AND ";
                }

                return db.Query<m.VoucherAmount>(
                    $@"SELECT *, c.customerName
                    FROM Voucher AS v
                    LEFT OUTER JOIN Customer AS c ON v.customerId=c.customerId
                    WHERE v.deleted<>1 AND {condition}(v.vDate BETWEEN @startDate AND @endDate)",
                    new { pcs.customerId, pcs.startDate, pcs.endDate });
            }
        }
    }
}
