using GUI.DAO;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class RevenueUC : UserControl
    {
        public RevenueUC()
        {
            InitializeComponent();
            LoadRevenue();
        }
        void LoadRevenue()
        {
            LoadthienboatIntoCombobox(cboSelectthienboat);
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadRevenue(cboSelectthienboat.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }
        void LoadthienboatIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = TaudiDAO.GetListthienboat();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "ID";
        }
        void LoadDateTimePickerRevenue()
        {
            dtmFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtmToDate.Value = dtmFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadRevenue(string idthienboat, DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dtgvRevenue.DataSource = RevenueDAO.GetRevenue(idthienboat, fromDate, toDate);
            txtDoanhThu.Text = GetSumRevenue().ToString("c", culture);
        }
        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value);
            }
            return sum;
        }

        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            LoadRevenue(cboSelectthienboat.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }

        private void btnReportRevenue_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(cboSelectthienboat.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
            frm.ShowDialog();
        }
    }
}
