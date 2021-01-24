using System;
using System.Data;
using System.Linq;

namespace GUI.DTO
{
    public class TauByGenre
    {
        public TauByGenre(string thienboatID, string genre)
        {
            this.thienboatID = thienboatID;
            this.Genre = genre;
        }

        public TauByGenre(DataRow row)
        {
            this.thienboatID = row["idTau"].ToString();
            this.Genre = row["idTheLoai"].ToString();
        }

        public string thienboatID { get; set; }

        public string Genre { get; set; }
    }
}
