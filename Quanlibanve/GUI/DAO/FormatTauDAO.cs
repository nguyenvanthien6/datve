using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GUI.DAO
{
    public class FormatTauDAO
    {
        public static List<FormatTaudto> GetListFormatthienboatBythienboat(string thienboatID)
        {
            List<FormatTaudto> listFormat = new List<FormatTaudto>();
            string query = "select d.id, p.TenTau, m.TenMH " +
                "from Tau p, DinhDangTau d, LoaiVe m " +
                "where p.id = d.idTau and d.idLoaiTau = m.id "
                + "and p.id = '" + thienboatID + "'";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                FormatTaudto format = new FormatTaudto(row);
                listFormat.Add(format);
            }
            return listFormat;
        }

        public static DataTable GetFormatthienboatByID(string thienboatID, string screenTypeID)
        {
            string query = "select d.id, p.TenTau, m.TenMH " +
                "from Tau p, DinhDangTau d, LoaiVe m " +
                "where p.id = d.idTau and d.idLoaiTau = m.id "
                + "and p.id = '" + thienboatID + "' and m.id = '" + screenTypeID + "'";
            return DataProvider.ExecuteQuery(query);
        }

		public static FormatTaudto GetFormatthienboatByName(string thienboatName, string screenTypeName)
		{
			string command =	"SELECT DD.id, P.TenTau, MH.TenMH " +
								"FROM dbo.DinhDangTau DD, dbo.Tau P, dbo.LoaiVe MH " +
								"WHERE DD.idTau = P.id AND DD.idLoaiTau = MH.id AND P.TenTau = N'" + thienboatName + "' AND MH.TENMH = N'" + screenTypeName + "'";
			DataTable data = DataProvider.ExecuteQuery(command);
			return new FormatTaudto(data.Rows[0]);
		}

		public static List<FormatTaudto> GetFormatthienboat()
		{
			List<FormatTaudto> formatthienboatList = new List<FormatTaudto>();
			DataTable data = DataProvider.ExecuteQuery("SELECT DD.id, P.TenTau, MH.TenMH " +
														"FROM dbo.DinhDangTau DD, dbo.Tau P, dbo.LoaiVe MH " +
														"WHERE DD.idTau = P.id AND DD.idLoaiTau = MH.id");
			foreach (DataRow item in data.Rows)
			{
				FormatTaudto formatthienboat = new FormatTaudto(item);
				formatthienboatList.Add(formatthienboat);
			}
			return formatthienboatList;
		}

        public static DataTable GetListFormatthienboat()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetListFormatthienboat");
        }

        public static bool InsertFormatthienboat(string id, string idthienboat, string idScreen)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertFormatthienboat @id , @idTau , @idLoaiTau ", new object[] { id, idthienboat, idScreen });
            return result > 0;
        }

        public static bool UpdateFormatthienboat(string id, string idthienboat, string idScreen)
        {
            string command = string.Format("UPDATE dbo.DinhDangTau SET idTau = '{0}', idLoaiTau = '{1}' WHERE id = '{2}'", idthienboat, idScreen, id);
            int result = DataProvider.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteFormatthienboat(string id)
        {
			DataProvider.ExecuteNonQuery("DELETE dbo.LichDi WHERE idDinhDang = '" + id + "'");

			int result = DataProvider.ExecuteNonQuery("DELETE dbo.DinhDangTau WHERE id = '" + id + "'");
            return result > 0;
        }
    }
}
