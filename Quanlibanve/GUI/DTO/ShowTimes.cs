using System;
using System.Data;
using System.Linq;

namespace GUI.DTO
{
    public class ShowTimes
    {
        public ShowTimes(string iD, DateTime time, string cinemaName,
            string formatthienboatID, string thienboatName, float ticketPrice, int status)
        {
            this.ID = iD;
            this.CinemaName = cinemaName;
            this.thienboatName = thienboatName;
            this.Time = time;
            this.FormatthienboatID = formatthienboatID;
            this.TicketPrice = ticketPrice;
            this.Status = status;
        }

        public ShowTimes(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.CinemaName = row["TenPhong"].ToString();
            this.thienboatName = row["TenTau"].ToString();
            this.Time = (DateTime)row["ThoiGianDi"];
            this.FormatthienboatID = row["idDinhDang"].ToString();
            if (row["GiaVe"].ToString() == "")
                this.TicketPrice = 0;
            else
                this.TicketPrice = float.Parse(row["GiaVe"].ToString());
            this.Status = (int)row["TrangThai"];
        }

        public string ID { get; set; }

        public DateTime Time { get; set; }

        public string CinemaName { get; set; }

        public string FormatthienboatID { get; set; }

        public string thienboatName { get; set; }

        public float TicketPrice { get; set; }

        public int Status { get; set; }

        //public override string ToString()
        //{
        //    return thienboatName + " " + CinemaName + " " + Time.ToString("HH:mm:ss dd/MM/yyyy");
        //}
    }
}
