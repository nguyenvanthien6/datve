using GUI.DAO;
using GUI.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls.DataUserControl
{
    public partial class ShowTimesUC : UserControl
    {
        BindingSource showtimeList = new BindingSource();
        public ShowTimesUC()
        {
            InitializeComponent();
            LoadShowtime();
        }

        void LoadShowtime()
        {
            dtgvShowtime.DataSource = showtimeList;
            LoadShowtimeList();
            LoadFormatthienboatIntoComboBox();
            AddShowtimeBinding();
        }
        void LoadShowtimeList()
        {
            showtimeList.DataSource = ShowTimesDAO.GetListShowtime();
        }
        private void btnShowShowtime_Click(object sender, EventArgs e)
        {
            LoadShowtimeList();
        }

        //Binding
        void AddShowtimeBinding()
        {
            txtShowtimeID.DataBindings.Add("Text", dtgvShowtime.DataSource, "Mã lịch", true, DataSourceUpdateMode.Never);
            dtmShowtimeDate.DataBindings.Add("Value", dtgvShowtime.DataSource, "Thời gian", true, DataSourceUpdateMode.Never);
            dtmShowtimeTime.DataBindings.Add("Value", dtgvShowtime.DataSource, "Thời gian", true, DataSourceUpdateMode.Never);
            txtTicketPrice_Showtime.DataBindings.Add("Text", dtgvShowtime.DataSource, "Giá vé", true, DataSourceUpdateMode.Never);
        }
        void LoadFormatthienboatIntoComboBox()
        {
            cboFormatID_Showtime.DataSource = FormatTauDAO.GetFormatthienboat();
            cboFormatID_Showtime.DisplayMember = "ID";
        }
        private void cboFormatID_Showtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormatID_Showtime.SelectedIndex != -1)
            {
                FormatTaudto formatthienboatSelecting = (FormatTaudto)cboFormatID_Showtime.SelectedItem;
                txtthienboatName_Showtime.Text = formatthienboatSelecting.thienboatName;
                txtScreenTypeName_Showtime.Text = formatthienboatSelecting.ScreenTypeName;

                cboCinemaID_Showtime.DataSource = null;
                ScreenType screenType = ScreenTypeDAO.GetScreenTypeByName(formatthienboatSelecting.ScreenTypeName);
                cboCinemaID_Showtime.DataSource = TauDAO.GetCinemaByScreenTypeID(screenType.ID);
                cboCinemaID_Showtime.DisplayMember = "Name";
            }
        }
        private void txtShowtimeID_TextChanged(object sender, EventArgs e)
        {
            #region Change selected index of ComboBox Formatthienboat
            string thienboatName = (string)dtgvShowtime.SelectedCells[0].OwningRow.Cells["Tên Tau"].Value;
            string screenTypeName = (string)dtgvShowtime.SelectedCells[0].OwningRow.Cells["Màn hình"].Value;
            FormatTaudto formatthienboatSelecting = FormatTauDAO.GetFormatthienboatByName(thienboatName, screenTypeName);
            if (formatthienboatSelecting == null)
                return;
            int indexFormatthienboat = -1;
            for (int i = 0; i < cboFormatID_Showtime.Items.Count; i++)
            {
                FormatTaudto item = cboFormatID_Showtime.Items[i] as FormatTaudto;
                if (item.ID == formatthienboatSelecting.ID)
                {
                    indexFormatthienboat = i;
                    break;
                }
            }
            cboFormatID_Showtime.SelectedIndex = indexFormatthienboat;
            #endregion
            #region Change selected index of ComboBox Cinema
            string cinemaID = (string)dtgvShowtime.SelectedCells[0].OwningRow.Cells["Mã phòng"].Value;
            Taudto cinemaSelecting = TauDAO.GetCinemaByID(cinemaID);
            //This is the Cinema that we're currently selecting in dtgv

            if (cinemaSelecting == null)
                return;

            int indexCinema = -1;
            int iCinema = 0;
            foreach (Taudto item in cboCinemaID_Showtime.Items)
            {
                if (item.ID == cinemaSelecting.ID)
                {
                    indexCinema = iCinema;
                    break;
                }
                iCinema++;
            }
            cboCinemaID_Showtime.SelectedIndex = indexCinema;
			#endregion
			toolTipCinema.SetToolTip(cboCinemaID_Showtime, "Danh sách phòng hỗ trợ loại phòng trên");
        }

        //Insert
        void InsertShowtime(string id, string cinemaID, string formatthienboatID, DateTime time, float ticketPrice)
        {
            if (ShowTimesDAO.InsertShowtime(id, cinemaID, formatthienboatID, time, ticketPrice))
            {
                MessageBox.Show("Thêm lịch  thành công");
            }
            else
            {
                MessageBox.Show("Thêm lịch  thất bại");
            }
        }
        private void btnInsertShowtime_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            string cinemaID = ((Taudto)cboCinemaID_Showtime.SelectedItem).ID;
            string formatthienboatID = ((FormatTaudto)cboFormatID_Showtime.SelectedItem).ID;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            InsertShowtime(showtimeID, cinemaID, formatthienboatID, time, ticketPrice);
            LoadShowtimeList();
        }

        //Update
        void UpdateShowtime(string id, string cinemaID, string formatthienboatID, DateTime time, float ticketPrice)
        {
            if (ShowTimesDAO.UpdateShowtime(id, cinemaID, formatthienboatID, time, ticketPrice))
            {
                MessageBox.Show("Sửa lịch  thành công");
            }
            else
            {
                MessageBox.Show("Sửa lịch  thất bại");
            }
        }
        private void btnUpdateShowtime_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            string cinemaID = ((Taudto)cboCinemaID_Showtime.SelectedItem).ID;
            string formatthienboatID = ((FormatTaudto)cboFormatID_Showtime.SelectedItem).ID;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            UpdateShowtime(showtimeID, cinemaID, formatthienboatID, time, ticketPrice);
            LoadShowtimeList();
        }

        //Delete
        void DeleteShowtime(string id)
        {
            if (ShowTimesDAO.DeleteShowtime(id))
            {
                MessageBox.Show("Xóa lịch  thành công");
            }
            else
            {
                MessageBox.Show("Xóa lịch  thất bại");
            }
        }
        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            DeleteShowtime(showtimeID);
            LoadShowtimeList();
        }

        //Search
        private void btnSearchShowtime_Click(object sender, EventArgs e)
        {
            string thienboatName = txtSearchShowtime.Text;
            showtimeList.DataSource = ShowTimesDAO.SearchShowtimeBythienboatName(thienboatName);
        }

		private void txtSearchShowtime_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearchShowtime.PerformClick();
				e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
			}
		}
	}
}
