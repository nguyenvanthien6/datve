using GUI.DAO;
using GUI.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSeller : Form
    {
        public frmSeller()
        {
            InitializeComponent();
            dtpThoiGian.Value = DateTime.Now;
            Loadthienboat(dtpThoiGian.Value);
        }

        private void frmSeller_Load(object sender, EventArgs e)
        {
            Loadthienboat(dtpThoiGian.Value);
            timer1.Start();
        }

        private void Loadthienboat(DateTime date)
        {
            cboFilmName.DataSource = TaudiDAO.GetListthienboatByDate(date);
            cboFilmName.DisplayMember = "Name";
        }

        private void cboFilmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilmName.SelectedIndex != -1)
            {
                cboFormatFilm.DataSource = null;
                lvLichDi.Items.Clear();
                Taudidto thienboat = cboFilmName.SelectedItem as Taudidto;
                cboFormatFilm.DataSource = FormatTauDAO.GetListFormatthienboatBythienboat(thienboat.ID);
                cboFormatFilm.DisplayMember = "ScreenTypeName";
            }
        }

        private void cboFormatFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormatFilm.SelectedIndex != -1)
            {
                lvLichDi.Items.Clear();
                FormatTaudto format = cboFormatFilm.SelectedItem as FormatTaudto;
                LoadListShowTimeByFilm(format.ID);
            }
        }

        private void LoadListShowTimeByFilm(string formatthienboatID)
        {
            DataTable data = ShowTimesDAO.GetListShowTimeByFormatthienboat(formatthienboatID, dtpThoiGian.Value);
            //if (data == null) return;
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                ListViewItem lvi = new ListViewItem("");
                lvi.SubItems.Add(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.thienboatName);
                lvi.SubItems.Add(showTimes.Time.ToShortTimeString());
                lvi.Tag = showTimes;

                string statusShowTimes = TicketDAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    + "/" + TicketDAO.CountToltalTicketByShowTime(showTimes.ID);

                lvi.SubItems.Add(statusShowTimes);

                float status = (float)TicketDAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    / TicketDAO.CountToltalTicketByShowTime(showTimes.ID);

                //thêm ảnh status
                if (status == 1)
                    lvi.ImageIndex = 2;
                else if (status > 0.5f)
                    lvi.ImageIndex = 1;
                else lvi.ImageIndex = 0;

                lvLichDi.Items.Add(lvi);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Load lại form để cập nhật cơ sở dữ liệu
            this.OnLoad(null);
        }

        private void lvLichDi_Click(object sender, EventArgs e)
        {
            if (lvLichDi.SelectedItems.Count > 0)
            {
                timer1.Stop();
                ShowTimes showTimes = lvLichDi.SelectedItems[0].Tag as ShowTimes;
                Taudidto thienboat = cboFilmName.SelectedItem as Taudidto;
                frmTau frm = new frmTau(showTimes, thienboat);
                this.Hide();
                frm.ShowDialog();
                this.OnLoad(null);
                this.Show();
            }
        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            Loadthienboat(dtpThoiGian.Value);
        }

        private void labelX_Click(object sender, EventArgs e)
        {

        }
    }
}
