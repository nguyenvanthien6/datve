using System;
using System.Data;
using System.Linq;

namespace GUI.DTO
{
    public class FormatTaudto
    {
        public FormatTaudto(string iD, string thienboatName, string screenTypeName)
        {
            this.ID = iD;
            this.thienboatName = thienboatName;
            this.ScreenTypeName = screenTypeName;
        }

        public FormatTaudto(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.thienboatName = row["TenTau"].ToString();
            this.ScreenTypeName = row["TenMH"].ToString();
        }

        public string ID { get; set; }

        public string thienboatName { get; set; }

        public string ScreenTypeName { get; set; }
    }
}
