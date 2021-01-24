namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class TaudiUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel47 = new System.Windows.Forms.Panel();
            this.btnShowthienboat = new System.Windows.Forms.Button();
            this.btnUpdatethienboat = new System.Windows.Forms.Button();
            this.btnDeletethienboat = new System.Windows.Forms.Button();
            this.btnAddthienboat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvthienboat = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpLoadPictureFilm = new System.Windows.Forms.Button();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.clbthienboatGenre = new System.Windows.Forms.CheckedListBox();
            this.dtmthienboatEnd = new System.Windows.Forms.DateTimePicker();
            this.dtmthienboatStart = new System.Windows.Forms.DateTimePicker();
            this.txtthienboatYear = new System.Windows.Forms.TextBox();
            this.txtthienboatDirector = new System.Windows.Forms.TextBox();
            this.txtthienboatProductor = new System.Windows.Forms.TextBox();
            this.txtthienboatLength = new System.Windows.Forms.TextBox();
            this.lblthienboatEndDate = new System.Windows.Forms.Label();
            this.lblthienboatStartDate = new System.Windows.Forms.Label();
            this.lblthienboatLength = new System.Windows.Forms.Label();
            this.txtthienboatDesc = new System.Windows.Forms.TextBox();
            this.lblthienboatYear = new System.Windows.Forms.Label();
            this.lblthienboatGenre = new System.Windows.Forms.Label();
            this.lblthienboatDirector = new System.Windows.Forms.Label();
            this.lblthienboatProductor = new System.Windows.Forms.Label();
            this.lblthienboatDesc = new System.Windows.Forms.Label();
            this.txtthienboatName = new System.Windows.Forms.TextBox();
            this.lblthienboatName = new System.Windows.Forms.Label();
            this.txtthienboatID = new System.Windows.Forms.TextBox();
            this.lblthienboatID = new System.Windows.Forms.Label();
            this.panel47.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthienboat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.btnShowthienboat);
            this.panel47.Controls.Add(this.btnUpdatethienboat);
            this.panel47.Controls.Add(this.btnDeletethienboat);
            this.panel47.Controls.Add(this.btnAddthienboat);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel47.Location = new System.Drawing.Point(0, 226);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(1161, 52);
            this.panel47.TabIndex = 10;
            // 
            // btnShowthienboat
            // 
            this.btnShowthienboat.Location = new System.Drawing.Point(246, 3);
            this.btnShowthienboat.Name = "btnShowthienboat";
            this.btnShowthienboat.Size = new System.Drawing.Size(75, 46);
            this.btnShowthienboat.TabIndex = 3;
            this.btnShowthienboat.Text = "Xem";
            this.btnShowthienboat.UseVisualStyleBackColor = true;
            this.btnShowthienboat.Click += new System.EventHandler(this.btnShowthienboat_Click);
            // 
            // btnUpdatethienboat
            // 
            this.btnUpdatethienboat.Location = new System.Drawing.Point(165, 3);
            this.btnUpdatethienboat.Name = "btnUpdatethienboat";
            this.btnUpdatethienboat.Size = new System.Drawing.Size(75, 46);
            this.btnUpdatethienboat.TabIndex = 2;
            this.btnUpdatethienboat.Text = "Sửa";
            this.btnUpdatethienboat.UseVisualStyleBackColor = true;
            this.btnUpdatethienboat.Click += new System.EventHandler(this.btnUpdatethienboat_Click);
            // 
            // btnDeletethienboat
            // 
            this.btnDeletethienboat.Location = new System.Drawing.Point(84, 3);
            this.btnDeletethienboat.Name = "btnDeletethienboat";
            this.btnDeletethienboat.Size = new System.Drawing.Size(75, 46);
            this.btnDeletethienboat.TabIndex = 1;
            this.btnDeletethienboat.Text = "Xóa";
            this.btnDeletethienboat.UseVisualStyleBackColor = true;
            this.btnDeletethienboat.Click += new System.EventHandler(this.btnDeletethienboat_Click);
            // 
            // btnAddthienboat
            // 
            this.btnAddthienboat.Location = new System.Drawing.Point(3, 3);
            this.btnAddthienboat.Name = "btnAddthienboat";
            this.btnAddthienboat.Size = new System.Drawing.Size(75, 46);
            this.btnAddthienboat.TabIndex = 0;
            this.btnAddthienboat.Text = "Thêm";
            this.btnAddthienboat.UseVisualStyleBackColor = true;
            this.btnAddthienboat.Click += new System.EventHandler(this.btnAddthienboat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvthienboat);
            this.panel1.Controls.Add(this.panel47);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 518);
            this.panel1.TabIndex = 11;
            // 
            // dtgvthienboat
            // 
            this.dtgvthienboat.AllowUserToAddRows = false;
            this.dtgvthienboat.AllowUserToDeleteRows = false;
            this.dtgvthienboat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvthienboat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvthienboat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvthienboat.Location = new System.Drawing.Point(0, 278);
            this.dtgvthienboat.Name = "dtgvthienboat";
            this.dtgvthienboat.ReadOnly = true;
            this.dtgvthienboat.Size = new System.Drawing.Size(1161, 240);
            this.dtgvthienboat.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpLoadPictureFilm);
            this.panel2.Controls.Add(this.picFilm);
            this.panel2.Controls.Add(this.clbthienboatGenre);
            this.panel2.Controls.Add(this.dtmthienboatEnd);
            this.panel2.Controls.Add(this.dtmthienboatStart);
            this.panel2.Controls.Add(this.txtthienboatYear);
            this.panel2.Controls.Add(this.txtthienboatDirector);
            this.panel2.Controls.Add(this.txtthienboatProductor);
            this.panel2.Controls.Add(this.txtthienboatLength);
            this.panel2.Controls.Add(this.lblthienboatEndDate);
            this.panel2.Controls.Add(this.lblthienboatStartDate);
            this.panel2.Controls.Add(this.lblthienboatLength);
            this.panel2.Controls.Add(this.txtthienboatDesc);
            this.panel2.Controls.Add(this.lblthienboatYear);
            this.panel2.Controls.Add(this.lblthienboatGenre);
            this.panel2.Controls.Add(this.lblthienboatDirector);
            this.panel2.Controls.Add(this.lblthienboatProductor);
            this.panel2.Controls.Add(this.lblthienboatDesc);
            this.panel2.Controls.Add(this.txtthienboatName);
            this.panel2.Controls.Add(this.lblthienboatName);
            this.panel2.Controls.Add(this.txtthienboatID);
            this.panel2.Controls.Add(this.lblthienboatID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 226);
            this.panel2.TabIndex = 0;
            // 
            // btnUpLoadPictureFilm
            // 
            this.btnUpLoadPictureFilm.Location = new System.Drawing.Point(729, 188);
            this.btnUpLoadPictureFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpLoadPictureFilm.Name = "btnUpLoadPictureFilm";
            this.btnUpLoadPictureFilm.Size = new System.Drawing.Size(95, 33);
            this.btnUpLoadPictureFilm.TabIndex = 56;
            this.btnUpLoadPictureFilm.Text = "Chọn hình ảnh";
            this.btnUpLoadPictureFilm.UseVisualStyleBackColor = true;
            this.btnUpLoadPictureFilm.Click += new System.EventHandler(this.btnUpLoadPictureFilm_Click);
            // 
            // picFilm
            // 
            this.picFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFilm.Location = new System.Drawing.Point(707, 2);
            this.picFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(140, 177);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 55;
            this.picFilm.TabStop = false;
            // 
            // clbthienboatGenre
            // 
            this.clbthienboatGenre.CheckOnClick = true;
            this.clbthienboatGenre.FormattingEnabled = true;
            this.clbthienboatGenre.Location = new System.Drawing.Point(11, 123);
            this.clbthienboatGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbthienboatGenre.MultiColumn = true;
            this.clbthienboatGenre.Name = "clbthienboatGenre";
            this.clbthienboatGenre.Size = new System.Drawing.Size(251, 79);
            this.clbthienboatGenre.TabIndex = 54;
            // 
            // dtmthienboatEnd
            // 
            this.dtmthienboatEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmthienboatEnd.Location = new System.Drawing.Point(481, 69);
            this.dtmthienboatEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmthienboatEnd.Name = "dtmthienboatEnd";
            this.dtmthienboatEnd.Size = new System.Drawing.Size(152, 20);
            this.dtmthienboatEnd.TabIndex = 53;
            // 
            // dtmthienboatStart
            // 
            this.dtmthienboatStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmthienboatStart.Location = new System.Drawing.Point(481, 41);
            this.dtmthienboatStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmthienboatStart.Name = "dtmthienboatStart";
            this.dtmthienboatStart.Size = new System.Drawing.Size(152, 20);
            this.dtmthienboatStart.TabIndex = 52;
            // 
            // txtthienboatYear
            // 
            this.txtthienboatYear.Location = new System.Drawing.Point(480, 163);
            this.txtthienboatYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtthienboatYear.Name = "txtthienboatYear";
            this.txtthienboatYear.Size = new System.Drawing.Size(152, 20);
            this.txtthienboatYear.TabIndex = 50;
            // 
            // txtthienboatDirector
            // 
            this.txtthienboatDirector.Location = new System.Drawing.Point(480, 135);
            this.txtthienboatDirector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtthienboatDirector.Name = "txtthienboatDirector";
            this.txtthienboatDirector.Size = new System.Drawing.Size(152, 20);
            this.txtthienboatDirector.TabIndex = 49;
            // 
            // txtthienboatProductor
            // 
            this.txtthienboatProductor.Location = new System.Drawing.Point(480, 104);
            this.txtthienboatProductor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtthienboatProductor.Name = "txtthienboatProductor";
            this.txtthienboatProductor.Size = new System.Drawing.Size(152, 20);
            this.txtthienboatProductor.TabIndex = 48;
            // 
            // txtthienboatLength
            // 
            this.txtthienboatLength.Location = new System.Drawing.Point(481, 13);
            this.txtthienboatLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtthienboatLength.Name = "txtthienboatLength";
            this.txtthienboatLength.Size = new System.Drawing.Size(152, 20);
            this.txtthienboatLength.TabIndex = 47;
            // 
            // lblthienboatEndDate
            // 
            this.lblthienboatEndDate.AutoSize = true;
            this.lblthienboatEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatEndDate.Location = new System.Drawing.Point(379, 69);
            this.lblthienboatEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatEndDate.Name = "lblthienboatEndDate";
            this.lblthienboatEndDate.Size = new System.Drawing.Size(75, 19);
            this.lblthienboatEndDate.TabIndex = 44;
            this.lblthienboatEndDate.Text = "Ngày KT:";
            // 
            // lblthienboatStartDate
            // 
            this.lblthienboatStartDate.AutoSize = true;
            this.lblthienboatStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatStartDate.Location = new System.Drawing.Point(379, 41);
            this.lblthienboatStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatStartDate.Name = "lblthienboatStartDate";
            this.lblthienboatStartDate.Size = new System.Drawing.Size(61, 19);
            this.lblthienboatStartDate.TabIndex = 42;
            this.lblthienboatStartDate.Text = "Ngày đi";
            // 
            // lblthienboatLength
            // 
            this.lblthienboatLength.AutoSize = true;
            this.lblthienboatLength.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatLength.Location = new System.Drawing.Point(379, 11);
            this.lblthienboatLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatLength.Name = "lblthienboatLength";
            this.lblthienboatLength.Size = new System.Drawing.Size(88, 19);
            this.lblthienboatLength.TabIndex = 35;
            this.lblthienboatLength.Text = "Thời gian đi";
            // 
            // txtthienboatDesc
            // 
            this.txtthienboatDesc.Location = new System.Drawing.Point(110, 73);
            this.txtthienboatDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtthienboatDesc.Multiline = true;
            this.txtthienboatDesc.Name = "txtthienboatDesc";
            this.txtthienboatDesc.Size = new System.Drawing.Size(152, 19);
            this.txtthienboatDesc.TabIndex = 46;
            // 
            // lblthienboatYear
            // 
            this.lblthienboatYear.AutoSize = true;
            this.lblthienboatYear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatYear.Location = new System.Drawing.Point(378, 162);
            this.lblthienboatYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatYear.Name = "lblthienboatYear";
            this.lblthienboatYear.Size = new System.Drawing.Size(83, 22);
            this.lblthienboatYear.TabIndex = 41;
            this.lblthienboatYear.Text = "Năm SX:";
            // 
            // lblthienboatGenre
            // 
            this.lblthienboatGenre.AutoSize = true;
            this.lblthienboatGenre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatGenre.Location = new System.Drawing.Point(8, 100);
            this.lblthienboatGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatGenre.Name = "lblthienboatGenre";
            this.lblthienboatGenre.Size = new System.Drawing.Size(47, 22);
            this.lblthienboatGenre.TabIndex = 40;
            this.lblthienboatGenre.Text = "Loại";
            // 
            // lblthienboatDirector
            // 
            this.lblthienboatDirector.AutoSize = true;
            this.lblthienboatDirector.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatDirector.Location = new System.Drawing.Point(344, 132);
            this.lblthienboatDirector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatDirector.Name = "lblthienboatDirector";
            this.lblthienboatDirector.Size = new System.Drawing.Size(132, 22);
            this.lblthienboatDirector.TabIndex = 39;
            this.lblthienboatDirector.Text = "Thuyền trưởng";
            // 
            // lblthienboatProductor
            // 
            this.lblthienboatProductor.AutoSize = true;
            this.lblthienboatProductor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatProductor.Location = new System.Drawing.Point(378, 100);
            this.lblthienboatProductor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatProductor.Name = "lblthienboatProductor";
            this.lblthienboatProductor.Size = new System.Drawing.Size(86, 22);
            this.lblthienboatProductor.TabIndex = 38;
            this.lblthienboatProductor.Text = "Sản xuất:";
            // 
            // lblthienboatDesc
            // 
            this.lblthienboatDesc.AutoSize = true;
            this.lblthienboatDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatDesc.Location = new System.Drawing.Point(8, 69);
            this.lblthienboatDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatDesc.Name = "lblthienboatDesc";
            this.lblthienboatDesc.Size = new System.Drawing.Size(64, 22);
            this.lblthienboatDesc.TabIndex = 37;
            this.lblthienboatDesc.Text = "Mô tả:";
            // 
            // txtthienboatName
            // 
            this.txtthienboatName.Location = new System.Drawing.Point(110, 44);
            this.txtthienboatName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtthienboatName.Name = "txtthienboatName";
            this.txtthienboatName.Size = new System.Drawing.Size(152, 20);
            this.txtthienboatName.TabIndex = 51;
            // 
            // lblthienboatName
            // 
            this.lblthienboatName.AutoSize = true;
            this.lblthienboatName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatName.Location = new System.Drawing.Point(8, 40);
            this.lblthienboatName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatName.Name = "lblthienboatName";
            this.lblthienboatName.Size = new System.Drawing.Size(85, 22);
            this.lblthienboatName.TabIndex = 36;
            this.lblthienboatName.Text = "Tên Tàu:";
            // 
            // txtthienboatID
            // 
            this.txtthienboatID.Location = new System.Drawing.Point(110, 13);
            this.txtthienboatID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtthienboatID.Name = "txtthienboatID";
            this.txtthienboatID.Size = new System.Drawing.Size(152, 20);
            this.txtthienboatID.TabIndex = 45;
            this.txtthienboatID.TextChanged += new System.EventHandler(this.txtthienboatID_TextChanged);
            // 
            // lblthienboatID
            // 
            this.lblthienboatID.AutoSize = true;
            this.lblthienboatID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthienboatID.Location = new System.Drawing.Point(8, 9);
            this.lblthienboatID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthienboatID.Name = "lblthienboatID";
            this.lblthienboatID.Size = new System.Drawing.Size(81, 22);
            this.lblthienboatID.TabIndex = 43;
            this.lblthienboatID.Text = "Mã Tàu:";
            // 
            // TaudiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaudiUC";
            this.Size = new System.Drawing.Size(1161, 518);
            this.panel47.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthienboat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Button btnShowthienboat;
        private System.Windows.Forms.Button btnUpdatethienboat;
        private System.Windows.Forms.Button btnDeletethienboat;
        private System.Windows.Forms.Button btnAddthienboat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpLoadPictureFilm;
        private System.Windows.Forms.PictureBox picFilm;
        private System.Windows.Forms.CheckedListBox clbthienboatGenre;
        private System.Windows.Forms.DateTimePicker dtmthienboatEnd;
        private System.Windows.Forms.DateTimePicker dtmthienboatStart;
        private System.Windows.Forms.TextBox txtthienboatYear;
        private System.Windows.Forms.TextBox txtthienboatDirector;
        private System.Windows.Forms.TextBox txtthienboatProductor;
        private System.Windows.Forms.TextBox txtthienboatLength;
        private System.Windows.Forms.Label lblthienboatEndDate;
        private System.Windows.Forms.Label lblthienboatStartDate;
        private System.Windows.Forms.Label lblthienboatLength;
        private System.Windows.Forms.TextBox txtthienboatDesc;
        private System.Windows.Forms.Label lblthienboatYear;
        private System.Windows.Forms.Label lblthienboatGenre;
        private System.Windows.Forms.Label lblthienboatDirector;
        private System.Windows.Forms.Label lblthienboatProductor;
        private System.Windows.Forms.Label lblthienboatDesc;
        private System.Windows.Forms.TextBox txtthienboatName;
        private System.Windows.Forms.Label lblthienboatName;
        private System.Windows.Forms.TextBox txtthienboatID;
        private System.Windows.Forms.Label lblthienboatID;
        private System.Windows.Forms.DataGridView dtgvthienboat;
    }
}
