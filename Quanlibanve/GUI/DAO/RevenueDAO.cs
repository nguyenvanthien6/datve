using System;
using System.Data;
using System.Linq;

namespace GUI.DAO
{
    public class RevenueDAO
    {
        public static DataTable GetRevenue(string idthienboat, DateTime fromDate, DateTime toDate)
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetRevenueBythienboatAndDate @idthienboat , @fromDate , @toDate", new object[] { idthienboat, fromDate, toDate });
        }
    }
}
