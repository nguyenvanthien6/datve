using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GUI.DAO
{
    public class TauByGenreDAO
    {
        public static List<Genre> GetListGenreBythienboatID(string id)
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataProvider.ExecuteQuery("EXEC USP_GetListGenreBythienboat @idTau", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }

        public static void Insertthienboat_Genre(string thienboatID, List<Genre> genreList)
        {
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiTau(idTau, idTheLoai) VALUES  ('{0}','{1}')", thienboatID, item.ID);
                DataProvider.ExecuteNonQuery(command);
            }
        }

        public static void Updatethienboat_Genre(string thienboatID, List<Genre> genreList)
        //Idea : Delete all rows that contain thienboatID, then re-add all genre that have been chosen from CheckedListBox to 'PhanLoaiTauTau' with thienboatID
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiTauWHERE idTau = '" + thienboatID + "'");
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiTau(idTau, idTheLoai) VALUES  ('{0}','{1}')", thienboatID, item.ID);
                DataProvider.ExecuteNonQuery(command);
            }
        }

        public static void Deletethienboat_GenreBythienboatID(string thienboatID)
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiTauWHERE idTau = '" + thienboatID + "'");
        }
    }
}
