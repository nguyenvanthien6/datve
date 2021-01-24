using GUI.frmAdminUserControls.DataUserControl;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class DataUC : UserControl
    {
        public DataUC()
        {
            InitializeComponent();
        }

        private void btnTauTypeUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTauTypeUC.Height;
            SidePanel.Top = btnTauTypeUC.Top;
            pnData.Controls.Clear();
            TauTypeUC TauTypeUC = new TauTypeUC();
            TauTypeUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(TauTypeUC);
        }

        private void btnTauUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTauUC.Height;
            SidePanel.Top = btnTauUC.Top;
            pnData.Controls.Clear();
            TauUC TauUC = new TauUC();
            TauUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(TauUC);
        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGenreUC.Height;
            SidePanel.Top = btnGenreUC.Top;
            pnData.Controls.Clear();
            GenreUC genreUc = new GenreUC();
            genreUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(genreUc);
        }

        private void btnTaudiUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTaudiUC.Height;
            SidePanel.Top = btnTaudiUC.Top;
            pnData.Controls.Clear();
            TaudiUC TaudiUC = new TaudiUC();
            TaudiUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(TaudiUC);
        }

        private void btnFormatTaudiUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFormatTaudiUC.Height;
            SidePanel.Top = btnFormatTaudiUC.Top;
            pnData.Controls.Clear();
            FormatTaudiUC formatTaudiUC = new FormatTaudiUC();
            formatTaudiUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(formatTaudiUC);
        }

        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowTimesUC.Height;
            SidePanel.Top = btnShowTimesUC.Top;
            pnData.Controls.Clear();
            ShowTimesUC showTimesUc = new ShowTimesUC();
            showTimesUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(showTimesUc);
        }

        private void btnTicketsUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTicketsUC.Height;
            SidePanel.Top = btnTicketsUC.Top;
            pnData.Controls.Clear();
            TicketsUC ticketsUc = new TicketsUC();
            ticketsUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(ticketsUc);
        }
    }
}
