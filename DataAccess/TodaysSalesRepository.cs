using DataAccess.Hubs;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class TodaysSalesRepository : ITodaysSalesRepository
    {
        private static string _connString = ConfigurationManager.ConnectionStrings["JodiUpdate"].ConnectionString;

        public double GetTodaysSales2(string storeId)
        {
            double todaySalesValue = 0;

            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                using (var command = new SqlCommand(@"SELECT SiteId, DAILYTODAY from [dbo].JodiUpdateView", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(TotalSales_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var SiteId = reader["SiteID"].ToString();

                        if (SiteId == storeId)
                        {
                            todaySalesValue = double.Parse(reader["DAILYTODAY"].ToString());
                        }
                    }
                }
                return todaySalesValue;
            }
        }
        //string sql = @"SELECT RTSASUP.SMSITE as SiteID, sum(smbsr+smbsrr) as DAILYTODAY 
        //    FROM V0608LDHHN.RTSASUP RTSASUP
        //    WHERE RTSASUP.SMDATE = '20161221'
        //    AND SMSITE IN('0001', '0002', '0003', '0004', '0005', '0006', '0007', '0009', '0018', '002B')
        //    GROUP BY RTSASUP.SMSITE";

        public double GetTodaysSales(string storeId)
        {
            double todaySalesValue = 0;

            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                using (var command = new SqlCommand(@"SELECT SiteId, TotalSales from [dbo].Sales", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(TotalSales1_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var SiteId = reader["SiteID"].ToString();

                        if (SiteId == storeId)
                        {
                            todaySalesValue = double.Parse(reader["TotalSales"].ToString());
                        }
                    }
                }
                return todaySalesValue;
            }
        }

        private void TotalSales_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.TotalSalesByStore();
            }
        }

        private void TotalSales1_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.TotalSalesByStore();
            }
        }
    }
}
