using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls.DataUserControl
{
    public partial class TaudiUC : UserControl
    {
        BindingSource thienboatList = new BindingSource();

        public TaudiUC()
        {
            InitializeComponent();
            Loadthienboat();
        }

        void Loadthienboat()
        {
            dtgvthienboat.DataSource = thienboatList;
            LoadthienboatList();
            AddthienboatBinding();
        }
        void LoadthienboatList()
        {
            thienboatList.DataSource = TaudiDAO.Getthienboat();
        }
        private void btnShowthienboat_Click(object sender, EventArgs e)
        {
            LoadthienboatList();
        }
        void AddthienboatBinding()
        {
            txtthienboatID.DataBindings.Add("Text", dtgvthienboat.DataSource, "Mã Tau", true,  DataSourceUpdateMode.Never);
            txtthienboatName.DataBindings.Add("Text", dtgvthienboat.DataSource, "Tên Tau", true, DataSourceUpdateMode.Never);
            txtthienboatDesc.DataBindings.Add("Text", dtgvthienboat.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
            txtthienboatLength.DataBindings.Add("Text", dtgvthienboat.DataSource, "Thời lượng", true, DataSourceUpdateMode.Never);
            dtmthienboatStart.DataBindings.Add("Value", dtgvthienboat.DataSource, "Ngày đi", true, DataSourceUpdateMode.Never);
            dtmthienboatEnd.DataBindings.Add("Value", dtgvthienboat.DataSource, "Ngày kết thúc", true, DataSourceUpdateMode.Never);
            txtthienboatProductor.DataBindings.Add("Text", dtgvthienboat.DataSource, "Sản xuất", true, DataSourceUpdateMode.Never);
            txtthienboatDirector.DataBindings.Add("Text", dtgvthienboat.DataSource, "Thuyền trưởng", true, DataSourceUpdateMode.Never);
            txtthienboatYear.DataBindings.Add("Text", dtgvthienboat.DataSource, "Năm SX", true, DataSourceUpdateMode.Never);
            LoadGenreIntoCheckedList(clbthienboatGenre);
        }
        void LoadGenreIntoCheckedList(CheckedListBox checkedList)
        {
            List<Genre> genreList = GenreDAO.GetListGenre();
            checkedList.DataSource = genreList;
            checkedList.DisplayMember = "Name";
        }
        private void txtthienboatID_TextChanged(object sender, EventArgs e)
        //Use to binding the CheckedListBox Genre of thienboat and picture of thienboat
        {
            picFilm.Image = null;
            for (int i = 0; i < clbthienboatGenre.Items.Count; i++)
            {
                clbthienboatGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }

            List<Genre> listGenreOfthienboat = TauByGenreDAO.GetListGenreBythienboatID(txtthienboatID.Text);
            for (int i = 0; i < clbthienboatGenre.Items.Count; i++)
            {
                Genre genre = (Genre)clbthienboatGenre.Items[i];
                foreach (Genre item in listGenreOfthienboat)
                {
                    if (genre.ID == item.ID)
                    {
                        clbthienboatGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            Taudidto thienboat = TaudiDAO.GetthienboatByID(txtthienboatID.Text);

            if (thienboat == null)
                return;

            if (thienboat.Poster != null)
                picFilm.Image = TaudiDAO.byteArrayToImage(thienboat.Poster);
        }

        void Insertthienboat(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            if (TaudiDAO.Insertthienboat(id, name, desc, length, startDate, endDate, productor, director, year, image))
            {
                MessageBox.Show("Thêm Tau thành công");
            }
            else
            {
                MessageBox.Show("Thêm Tau thất bại");
            }
        }
        void Insertthienboat_Genre(string thienboatID, CheckedListBox checkedListBox)
        //Insert into table 'PhanLoaiTauTau'
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in checkedListBox.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            TauByGenreDAO.Insertthienboat_Genre(thienboatID, checkedGenreList);
        }

        private void btnUpLoadPictureFilm_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    picFilm.Image = Image.FromFile(filePathImage.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnAddthienboat_Click(object sender, EventArgs e)
        {
            string thienboatID = txtthienboatID.Text;
            string thienboatName = txtthienboatName.Text;
            string thienboatDesc = txtthienboatDesc.Text;
            float thienboatLength = float.Parse(txtthienboatLength.Text);
            DateTime startDate = dtmthienboatStart.Value;
            DateTime endDate = dtmthienboatEnd.Value;
            string productor = txtthienboatProductor.Text;
            string director = txtthienboatDirector.Text;
            int year = int.Parse(txtthienboatYear.Text);
            if (picFilm.Image == null)
            {
                MessageBox.Show("Mời bạn thêm hình ảnh cho Tau trước");
                return;
            }
            Insertthienboat(thienboatID, thienboatName, thienboatDesc, thienboatLength, startDate, endDate, productor, director, year, TaudiDAO.imageToByteArray(picFilm.Image));
            Insertthienboat_Genre(thienboatID, clbthienboatGenre);
            LoadthienboatList();
        }

        void Updatethienboat(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            if (TaudiDAO.Updatethienboat(id, name, desc, length, startDate, endDate, productor, director, year, image))
            {
                MessageBox.Show("Sửa Tau thành công");
            }
            else
            {
                MessageBox.Show("Sửa Tau thất bại");
            }
        }
        void Updatethienboat_Genre(string thienboatID, CheckedListBox checkedListBox)
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in checkedListBox.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            TauByGenreDAO.Updatethienboat_Genre(thienboatID, checkedGenreList);
        }
        private void btnUpdatethienboat_Click(object sender, EventArgs e)
        {
            string thienboatID = txtthienboatID.Text;
            string thienboatName = txtthienboatName.Text;
            string thienboatDesc = txtthienboatDesc.Text;
            float thienboatLength = float.Parse(txtthienboatLength.Text);
            DateTime startDate = dtmthienboatStart.Value;
            DateTime endDate = dtmthienboatEnd.Value;
            string productor = txtthienboatProductor.Text;
            string director = txtthienboatDirector.Text;
            int year = int.Parse(txtthienboatYear.Text);
            if (picFilm.Image == null)
            {
                MessageBox.Show("Mời bạn thêm hình ảnh cho Tau trước");
                return;
            }
            Updatethienboat(thienboatID, thienboatName, thienboatDesc, thienboatLength, startDate, endDate, productor, director, year, TaudiDAO.imageToByteArray(picFilm.Image));
            Updatethienboat_Genre(thienboatID, clbthienboatGenre);
            LoadthienboatList();
        }

        void Deletethienboat(string id)
        {
            if (TaudiDAO.Deletethienboat(id))
            {
                MessageBox.Show("Xóa Tau thành công");
            }
            else
            {
                MessageBox.Show("Xóa Tau thất bại");
            }
        }
        private void btnDeletethienboat_Click(object sender, EventArgs e)
        {
            string thienboatID = txtthienboatID.Text;
            Deletethienboat(thienboatID);
            LoadthienboatList();
        }
    }
}
