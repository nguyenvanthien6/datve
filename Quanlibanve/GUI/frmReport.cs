using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmReport : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter = null;
        SqlConnection connection = null;
        string connectionSTR = Properties.Settings.Default.connectionSTR;

        string thienboatID;
        DateTime FromDate;
        DateTime ToDate;
        public frmReport(string idthienboat, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            thienboatID = idthienboat;
            FromDate = fromDate;
            ToDate = toDate;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadRevenue(thienboatID, FromDate, ToDate);
            this.rpViewer.RefreshReport();
        }

        void LoadRevenue(string idthienboat, DateTime fromDate, DateTime toDate)
        {
            if (connection == null)
                connection = new SqlConnection(connectionSTR);

            //string query = "SELECT P.TenTau ,LC.ThoiGianDi, CONVERT(TIME(0), LC.ThoiGianDi) AS[Giờ ], COUNT(V.id) AS[Số vé đã bán], SUM(TienBanVe)"
            //               + " FROM dbo.Ve AS V, dbo.LichDi AS LC, dbo.DinhDangTau AS DDP, Tau AS P"
            //               + " WHERE V.idLichDi = LC.id AND LC.idDinhDang = DDP.id AND DDP.idTau = P.id AND V.TrangThai = 1 AND P.id = N'P01'"
            //               + " GROUP BY idLichDi, P.TenTau, LC.ThoiGianDi";

            //SqlCommand command = new SqlCommand("USP_GetReportRevenueBythienboatAndDate @idthienboat, @fromDate, @toDate", connection);

            ////adapter = new SqlDataAdapter(query, connection);

            adapter = new SqlDataAdapter("USP_GetReportRevenueBythienboatAndDate @idthienboat, @fromDate, @toDate", connection);
            adapter.SelectCommand.Parameters.Add("@idthienboat", SqlDbType.VarChar).Value = idthienboat;
            adapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
            adapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;


            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "DOANHTHU");

            this.rpViewer.LocalReport.ReportEmbeddedResource = "GUI.Report.rdlc";
            this.rpViewer.RefreshReport();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetRevenue";
            rds.Value = dataSet.Tables[0];
            this.rpViewer.LocalReport.DataSources.Add(rds);

            //set parameter cho report
            ReportParameter[] reportParameter = new ReportParameter[2];
            reportParameter[0] = new ReportParameter("FromDate");
            reportParameter[0].Values.Add(FromDate.ToShortDateString());
            reportParameter[1] = new ReportParameter("ToDate");
            reportParameter[1].Values.Add(ToDate.ToShortDateString());

            this.rpViewer.LocalReport.SetParameters(reportParameter);
        }

        private void rpViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
