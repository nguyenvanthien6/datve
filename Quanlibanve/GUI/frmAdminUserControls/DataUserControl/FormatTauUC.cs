using GUI.DAO;
using GUI.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls.DataUserControl
{
    public partial class FormatTaudiUC : UserControl
    {
        BindingSource formatList = new BindingSource();

        public FormatTaudiUC()
        {
            InitializeComponent();
            LoadFormatthienboat();
        }

        void LoadFormatthienboat()
        {
            dtgvFormat.DataSource = formatList;
            LoadFormatthienboatList();
            LoadthienboatIDIntoCombobox(cboFormat_thienboatID);
            LoadScreenIDIntoCombobox(cboFormat_ScreenID);
            AddFormatBinding();
        }
        void LoadthienboatIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = TaudiDAO.GetListthienboat();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }
        private void cboFormat_thienboatID_SelectedValueChanged(object sender, EventArgs e)
        //Display the thienboatName when thienboatID changed
        {
            Taudidto thienboatSelected = cboFormat_thienboatID.SelectedItem as Taudidto;
            txtFormat_thienboatName.Text = thienboatSelected.Name;
        }
        void LoadScreenIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = ScreenTypeDAO.GetListScreenType();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }
        private void cboFormat_ScreenID_SelectedValueChanged(object sender, EventArgs e)
        {
            ScreenType screenTypeSelected = cboFormat_ScreenID.SelectedItem as ScreenType;
            txtFormat_ScreenName.Text = screenTypeSelected.Name;
        }
        void LoadFormatthienboatList()
        {
            formatList.DataSource = FormatTauDAO.GetListFormatthienboat();
        }

        void AddFormatBinding()
        {
            txtFormatID.DataBindings.Add("Text", dtgvFormat.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
        }
        private void txtFormatID_TextChanged(object sender, EventArgs e)
        {
            string thienboatID = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Mã Tau"].Value;
            Taudidto thienboatSelecting = TaudiDAO.GetthienboatByID(thienboatID);
            //This is the thienboat that we're currently selecting in dtgv

            if (thienboatSelecting == null)
                return;

            //cboFormat_thienboatID.SelectedItem = thienboatSelecting;

            int indexthienboat = -1;
            int ithienboat = 0;
            foreach (Taudidto item in cboFormat_thienboatID.Items)
            {
                if (item.Name == thienboatSelecting.Name)
                {
                    indexthienboat = ithienboat;
                    break;
                }
                ithienboat++;
            }
            cboFormat_thienboatID.SelectedIndex = indexthienboat;


            string screenName = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Tên MH"].Value;
            ScreenType screenTypeSelecting = ScreenTypeDAO.GetScreenTypeByName(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            if (screenTypeSelecting == null)
                return;

            //cboFormat_ScreenID.SelectedItem = screenTypeSelecting;

            int indexScreen = -1;
            int iScreen = 0;
            foreach (ScreenType item in cboFormat_ScreenID.Items)
            {
                if (item.Name == screenTypeSelecting.Name)
                {
                    indexScreen = iScreen;
                    break;
                }
                iScreen++;
            }
            cboFormat_ScreenID.SelectedIndex = indexScreen;
        }

        private void btnShowFormat_Click(object sender, EventArgs e)
        {
            LoadFormatthienboatList();
        }

        void InsertFormat(string id, string idthienboat, string idScreen)
        {
            if (FormatTauDAO.InsertFormatthienboat(id, idthienboat, idScreen))
            {
                MessageBox.Show("Thêm định dạng thành công");
            }
            else
            {
                MessageBox.Show("Thêm định dạng thất bại");
            }
        }
        private void btnInsertFormat_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            string thienboatID = cboFormat_thienboatID.SelectedValue.ToString();
            string screenID = cboFormat_ScreenID.SelectedValue.ToString();
            InsertFormat(formatID, thienboatID, screenID);
            LoadFormatthienboatList();
        }

        void UpdateFormat(string id, string idthienboat, string idScreen)
        {
            if (FormatTauDAO.UpdateFormatthienboat(id, idthienboat, idScreen))
            {
                MessageBox.Show("Sửa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Sửa định dạng thất bại");
            }
        }
        private void btnUpdateFormat_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            string thienboatID = cboFormat_thienboatID.SelectedValue.ToString();
            string screenID = cboFormat_ScreenID.SelectedValue.ToString();
            UpdateFormat(formatID, thienboatID, screenID);
            LoadFormatthienboatList();
        }

        void DeleteFormat(string id)
        {
            if (FormatTauDAO.DeleteFormatthienboat(id))
            {
                MessageBox.Show("Xóa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Xóa định dạng thất bại");
            }
        }
        private void btnDeleteFormat_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            DeleteFormat(formatID);
            LoadFormatthienboatList();
        }
    }
}
