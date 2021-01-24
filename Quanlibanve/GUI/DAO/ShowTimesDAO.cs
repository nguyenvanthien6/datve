using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GUI.DAO
{
    public class ShowTimesDAO
    {
        public static DataTable GetListShowTimeByFormatthienboat(string formatthienboatID, DateTime date)
        {
            string query = "USP_GetListShowTimesByFormatthienboat @ID , @Date";
            return DataProvider.ExecuteQuery(query, new object[] { formatthienboatID, date });
        }
        public static List<ShowTimes> GetAllListShowTimes()
        {
            List<ShowTimes> listShowTimes = new List<ShowTimes>();
            DataTable data = DataProvider.ExecuteQuery("USP_GetAllListShowTimes");
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public static List<ShowTimes> GetListShowTimesNotCreateTickets()
        {
            List<ShowTimes> listShowTimes = new List<ShowTimes>();
            DataTable data = DataProvider.ExecuteQuery("USP_GetListShowTimesNotCreateTickets");
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public static int UpdateStatusShowTimes(string showTimesID, int status)
        {
            string query = "USP_UpdateStatusShowTimes @idLichDi , @status";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID, status });
        }

		public static DataTable GetListShowtime()
		{
			return DataProvider.ExecuteQuery("EXEC USP_GetShowtime");
		}

		public static bool InsertShowtime(string id, string cinemaID, string formatthienboatID, DateTime time, float ticketPrice)
		{
			int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertShowtime @id , @idPhong , @idDinhDang , @ThoiGianDi , @giaVe ", new object[] { id, cinemaID, formatthienboatID, time, ticketPrice });
			return result > 0;
		}

		public static bool UpdateShowtime(string id, string cinemaID, string formatthienboatID, DateTime time, float ticketPrice)
		{
			string command = string.Format("USP_UpdateShowtime @id , @idPhong , @idDinhDang , @ThoiGianDi , @giaVe ");
			int result = DataProvider.ExecuteNonQuery(command, new object[] { id, cinemaID, formatthienboatID, time, ticketPrice });
			return result > 0;
		}

		public static bool DeleteShowtime(string id)
		{
            TicketDAO.DeleteTicketsByShowTimes(id);

			int result = DataProvider.ExecuteNonQuery("DELETE dbo.LichDi WHERE id = '" + id + "'");
			return result > 0;
		}

		public static DataTable SearchShowtimeBythienboatName(string thienboatName)
		{
			DataTable data = DataProvider.ExecuteQuery("EXEC USP_SearchShowtimeBythienboatName @tenTau ", new object[] { thienboatName });
			return data;
		}
	}
}
