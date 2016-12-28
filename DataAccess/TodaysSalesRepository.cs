using DataAccess.Hubs;
using DataAccess.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class TodaysSalesRepository
    {
        private static string _connString = ConfigurationManager.ConnectionStrings["JodiUpdate"].ConnectionString;

        public List<SiteTotalSales> GetTodaysSales()
        {
            List<SiteTotalSales> values = new List<SiteTotalSales>();

            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                using (var command = new SqlCommand(@"SELECT SiteId, TotalSales from [dbo].Sales", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        values.Add(new SiteTotalSales()
                        {
                            SiteId = reader["SITEID"].ToString(),
                            TotalSales = double.Parse(reader["TotalSales"].ToString())
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

        public List<SiteSalesPerHour> GetSalesByHourPerStore()
        {

            var values = new List<SiteSalesPerHour>();

            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                using (var command = new SqlCommand(@"SELECT SiteId, Time as Hour, CurrentAmount, LastYearAmount from [dbo].SalesByHour", connection))
                {
                    command.Notification = null;

                    //var dependency = new SqlDependency(command);
                    //dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

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

            //            SELECT

            //    b.site,
            //	case b.smtzon
            //    when 1 then B.Hour
            //    when 2 then B.Hour + '.5'

            //    end as time, 
            //	A.Amount as CurrentAmount,
            //	B.Amount as LastYearAmount
            //FROM
            //(
            //    SELECT

            //        RTSASUP.SMSITE as Site,
            //        RTSASUP.SMHOUR as Hour,
            //        RTSASUP.SMTZON,
            //        CASE

            //            WHEN RTSASUP.SMSITE = '0007' THEN sum(smlsr + smlsrr)

            //            ELSE sum(smbsr + smbsrr)

            //        END as Amount


            //    FROM    V0608LDHHN.COSYSTP COSYSTP, V0608LDHHN.RTSASUP RTSASUP

            //    WHERE   RTSASUP.SMCOMP = 1 and  RTSASUP.SMDATE = COSYSTP.SYDATE

            //    GROUP BY    RTSASUP.SMSITE, RTSASUP.SMHOUR, RTSASUP.SMTZON
            //) AS A
            //RIGHT JOIN
            //(
            //    SELECT

            //        RTSASUP.SMSITE as Site,
            //        RTSASUP.SMHOUR as Hour,
            //        RTSASUP.SMTZON,
            //        CASE

            //            WHEN RTSASUP.SMSITE = '0007' THEN sum(smlsr + smlsrr)

            //            ELSE sum(smbsr + smbsrr)

            //        END as Amount

            //    FROM    V0608LDHHN.COSYSTP COSYSTP, V0608LDHHN.RTSASUP RTSASUP

            //    WHERE   RTSASUP.SMCOMP = 1 and  RTSASUP.SMDATE =
            //        (
            //        SELECT D1.DAXDAT

            //        FROM V0608LDHHN.codatep D1

            //        INNER JOIN(SELECT DAACDY, DAACWK, DAACYR, DAACCN, DAXYER

            //            FROM V0608LDHHN.codatep, V0608LDHHN.COSYSTP

            //            WHERE daxdat = SYDATE) D2

            //        ON  D1.DAACWK = D2.DAACWK and D1.DAACDY = D2.DAACDY and D1.DAXYER = D2.DAXYER - 1
            //) 
            //GROUP BY    RTSASUP.SMSITE, RTSASUP.SMHOUR, RTSASUP.SMTZON
            //) AS B
            //on A.Site = B.Site   and A.Hour = B.Hour and A.SMTZON = B.SMTZON
            //ORDER BY b.site, B.Hour, B.SMTZON

        }

        public int GetLastYearsTodaySales()
        {
            //SELECT  RTSASUP.SMSITE as SiteID, sum(smbsr+smbsrr) as DAILYTODAY 
            //FROM V0608LDHHN.RTSASUP RTSASUP
            //WHERE RTSASUP.SMDATE = @Today_CY AND SMSITE IN('0001', '0002', '0003', '0004', '0005', '0006', '0007', '0009', '0018', '002B')
            //GROUP BY RTSASUP.SMSITE
            return 50;
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.SendMessages();
            }
        }
    }
}
