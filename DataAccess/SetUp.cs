using System.Data.SqlClient;

namespace DataAccess
{
    public class SetUp
    {
        public static string ConString;

        public static string MainConString
        {
            get
            {
                var builder = new SqlConnectionStringBuilder(ConString);

                return $@"Data Source={builder.DataSource};
                        User ID={builder.UserID};
                        Password={builder.Password};";
            }
        }
    }
}
