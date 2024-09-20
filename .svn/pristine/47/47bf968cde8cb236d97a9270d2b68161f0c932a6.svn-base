using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;
using System;

namespace DataAccess
{
    public class Cash
    {
        public static IEnumerable<m.Cash> Get()
        {
            using (var db = da.Con())
            {
                return db.Query<m.Cash>(da.Select<m.Cash>());
            }
        }

        public static m.Cash Get(int cId)
        {
            using (var db = da.Con())
            {
                return db.QueryFirstOrDefault<m.Cash>(da.Select<m.Cash>("cId"),
                    new { cId });
            }
        }

        public static IEnumerable<m.Cash> Get(m.Period period)
        {
            using (var db = da.Con())
            {
                return db.Query<m.Cash>(
                        @"SELECT * FROM Cash 
                        WHERE cDate BETWEEN @startDate AND @endDate",
                        new { period.startDate, period.endDate });
            }
        }

        public static string GenerateCno()
        {
            using (var db = da.Con())
            {
                string preFix = "T" + DateTime.Now.ToString("yyMM");

                string maxVno = db.QueryFirstOrDefault<string>(
                    $"SELECT TOP(1)cNo FROM Cash WHERE cNo LIKE '{preFix}%' ORDER BY cNo DESC");

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

        public static IEnumerable<string> GetAccounts(m.CType type)
        {
            using (var db = da.Con())
            {
                return db.Query<string>(
                    @"SELECT DISTINCT accId 
                    FROM Cash 
                    WHERE type=@type AND accId<>'' AND accId IS NOT NULL",
                    new { type = (int)type });
            }
        }

        public static long Insert(m.Cash cash)
        {
            using (var db = da.Con())
            {
                cash.cNo = GenerateCno();

                object result = db.ExecuteScalar(da.InsertAutoId<m.Cash>("cId"), cash);
                return long.Parse(result.ToString());
            }
        }

        public static void Update(m.Cash cash)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Update<m.Cash>("cId"), cash);
            }
        }

        public static void Delete(int cId)
        {
            using (var db = da.Con())
            {
                db.Execute(da.Delete<m.Cash>("cId"),
                    new { cId });
            }
        }
    }
}
