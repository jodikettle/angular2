using System.Configuration;
using System.Data;
using System.Data.Odbc;

namespace DataAccess
{
    public static class Repository
    {
        private static string _cs = ConfigurationManager.ConnectionStrings["merretDb"].ConnectionString;

        internal static DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection con = new OdbcConnection(_cs))
            {
                con.Open();

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
