using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;

namespace DataAccess
{
    public class VoucherCharge
    {
        public static IEnumerable<m.VoucherCharge> Get(long vId)
        {
            using (var db = da.Con())
            {
                return db.Query<m.VoucherCharge, m.Charge, m.VoucherCharge>(
                    @"SELECT *
                    FROM VoucherCharge
                    LEFT OUTER JOIN Charge ON VoucherCharge.chargeId=Charge.chargeId
                    WHERE VoucherCharge.vId=@vId",
                    (rec, item) =>
                    {
                        rec.charge = item;

                        return rec;
                    },
                    new { vId },
                    splitOn: "chargeId");
            }
        }

        public static void Insert(IEnumerable<m.VoucherCharge> charges)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Insert<m.VoucherCharge>("vChId"), charges);
            }
        }

        public static void Delete(long vId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.VoucherCharge>("vId"),
                    new { vId });
            }
        }
    }
}
