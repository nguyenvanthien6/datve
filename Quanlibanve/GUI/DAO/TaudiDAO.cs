using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

namespace GUI.DAO
{
    public class TaudiDAO
    {
        //ảnh -> byte[]
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static List<Taudidto> GetListthienboatByDate(DateTime date)
        {
            List<Taudidto> listthienboat = new List<Taudidto>();
            DataTable data = DataProvider.ExecuteQuery("select * from Tau where @Date <= NgayKetThuc", new object[] { date });
            foreach (DataRow row in data.Rows)
            {
                Taudidto thienboat = new Taudidto(row);
                listthienboat.Add(thienboat);
            }
            return listthienboat;
        }

        public static List<Taudidto> GetListthienboat()
        {
            List<Taudidto> listthienboat = new List<Taudidto>();
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM Tau");
            foreach (DataRow row in data.Rows)
            {
                Taudidto thienboat = new Taudidto(row);
                listthienboat.Add(thienboat);
            }
            return listthienboat;
        }

        public static DataTable Getthienboat()
        {
            return DataProvider.ExecuteQuery("EXEC USP_Getthienboat");
        }

        public static bool Insertthienboat(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_Insertthienboat @id , @tenTau , @moTa , @thoiLuong , @NgayDi , @ngayKetThuc , @sanXuat , @ThuyenTruong , @namSX , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image});
            return result > 0;
        }

        public static bool Updatethienboat(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_Updatethienboat @id , @tenTau , @moTa , @thoiLuong , @NgayDi , @ngayKetThuc , @sanXuat , @ThuyenTruong , @namSX , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image });
            return result > 0;
        }

        public static bool Deletethienboat(string id)
        {
			DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiTauWHERE idTau = '" + id + "'");
			DataProvider.ExecuteNonQuery("DELETE dbo.DinhDangTau WHERE idTau = '" + id + "'");

			TauByGenreDAO.Deletethienboat_GenreBythienboatID(id);
            int result = DataProvider.ExecuteNonQuery("DELETE dbo.Tau WHERE id = '" + id + "'");
            return result > 0;
        }

        public static Taudidto GetthienboatByID(string id)
        {
            Taudidto thienboat = null;
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.Tau WHERE id = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                thienboat = new Taudidto(item);
                return thienboat;
            }
            return thienboat;
        }
    }
}
