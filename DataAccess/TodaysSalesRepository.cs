using DataAccess.Hubs;
using DataAccess.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class TodaysSalesRepository : ISalesRepository
    {
        private static string _connString = ConfigurationManager.ConnectionStrings["JodiUpdate1"].ConnectionString;

        public List<SiteSalesPerHour> GetCumulativeSalesForAllStores()
        {
            List<SiteSalesPerHour> values = new List<SiteSalesPerHour>();

            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                using (var command = new SqlCommand(@"SELECT SiteId, TotalSales from [dbo].Sales", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(TodaysSales_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        values.Add(new SiteSalesPerHour()
                        {
                            SiteId = reader["SITEID"].ToString(),
                            Hour = int.Parse(reader["Hour"].ToString()),
                            TodaysValue = double.Parse(reader["CurrentAmount"].ToString()),
                            LastYearsValue = double.Parse(reader["LastYearAmount"].ToString())
                        });
                    }
                }

            }
            return values;

            //string sql = @"SELECT RTSASUP.SMSITE as SiteID, sum(smbsr+smbsrr) as DAILYTODAY 
            //    FROM V0608LDHHN.RTSASUP RTSASUP
            //    WHERE RTSASUP.SMDATE = '20161221'
            //    AND SMSITE IN('0001', '0002', '0003', '0004', '0005', '0006', '0007', '0009', '0018', '002B')
            //    GROUP BY RTSASUP.SMSITE";
        }

        public List<SiteSalesPerHour> GetCumulativeSalesForToday(string StoreId)
        {
            var values = new List<SiteSalesPerHour>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                using (var command = new SqlCommand(@"SELECT SiteId, Time as Hour, CurrentAmount, LastYearAmount from [dbo].SalesByHour Where SiteId = "+ StoreId, connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(SiteStoreByHour_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        values.Add(new SiteSalesPerHour()
                        {
                            SiteId = reader["SITEID"].ToString(),
                            Hour = int.Parse(reader["Hour"].ToString()),
                            TodaysValue = double.Parse(reader["CurrentAmount"].ToString()),
                            LastYearsValue = double.Parse(reader["LastYearAmount"].ToString())
                        });
                    }
                }

            }
            return values;
        }

        private void SiteStoreByHour_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.SendStoreByHourChange();
            }
        }
        private void TodaysSales_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.SendAllStoresByHourChange();
            }
        }
    }
}
