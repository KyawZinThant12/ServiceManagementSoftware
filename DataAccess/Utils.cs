using Dapper;
using System.Collections.Generic;
using m = Model;
using da = DataAccess.Shared.DbAccess;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Utils
    {
        public static IEnumerable<string> GetDatabaseNames()
        {
            using (var db = new SqlConnection(SetUp.MainConString))
            {
                return db.Query<string>(@"SELECT name 
                                        FROM sys.databases 
                                        WHERE name<>'master' AND name<>'tempdb' 
                                        AND name<>'model' AND name<>'msdb'");
            }
        }

        public static void BackupDatabase(string dbName, string filePath)
        {
            using (var db = new SqlConnection(SetUp.MainConString))
            {
                db.Execute($@"BACKUP DATABASE [{dbName}]
                            TO DISK='{filePath}' WITH INIT");
            }
        }

        public static void ResetAllData()
        {
            using (var db = da.Con())
            {
                db.Execute(
                    @"DELETE FROM Voucher
                    DELETE FROM ActionLog
                    DELETE FROM Cash");
            }
        }
    }
}
