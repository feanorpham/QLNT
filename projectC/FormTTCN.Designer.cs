namespace projectC
{
    partial class FormTTCN
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTTCN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btunThoat = new System.Windows.Forms.Button();
            this.btunXoa = new System.Windows.Forms.Button();
            this.btunSua = new System.Windows.Forms.Button();
            this.btunKT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbCharID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGT = new System.Windows.Forms.ComboBox();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.txtbDC = new System.Windows.Forms.TextBox();
            this.txtbSDT = new System.Windows.Forms.TextBox();
            this.txtbTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btunThoat);
            this.groupBox1.Controls.Add(this.btunXoa);
            this.groupBox1.Controls.Add(this.btunSua);
            this.groupBox1.Controls.Add(this.btunKT);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btunThoat
            // 
            this.btunThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunThoat.BackgroundImage")));
            this.btunThoat.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunThoat.Image = ((System.Drawing.Image)(resources.GetObject("btunThoat.Image")));
            this.btunThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunThoat.Location = new System.Drawing.Point(593, 19);
            this.btunThoat.Name = "btunThoat";
            this.btunThoat.Size = new System.Drawing.Size(66, 26);
            this.btunThoat.TabIndex = 3;
            this.btunThoat.Text = "Thoát";
            this.btunThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunThoat.UseVisualStyleBackColor = true;
            this.btunThoat.Click += new System.EventHandler(this.btunThoat_Click);
            // 
            // btunXoa
            // 
            this.btunXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunXoa.BackgroundImage")));
            this.btunXoa.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunXoa.Image = ((System.Drawing.Image)(resources.GetObject("btunXoa.Image")));
            this.btunXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunXoa.Location = new System.Drawing.Point(534, 19);
            this.btunXoa.Name = "btunXoa";
            this.btunXoa.Size = new System.Drawing.Size(53, 26);
            this.btunXoa.TabIndex = 2;
            this.btunXoa.Text = "Xóa";
            this.btunXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunXoa.UseVisualStyleBackColor = true;
            this.btunXoa.Click += new System.EventHandler(this.btunXoa_Click);
            // 
            // btunSua
            // 
            this.btunSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunSua.BackgroundImage")));
            this.btunSua.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunSua.Image = ((System.Drawing.Image)(resources.GetObject("btunSua.Image")));
            this.btunSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunSua.Location = new System.Drawing.Point(411, 19);
            this.btunSua.Name = "btunSua";
            this.btunSua.Size = new System.Drawing.Size(114, 26);
            this.btunSua.TabIndex = 1;
            this.btunSua.Text = "Sửa Thông Tin";
            this.btunSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunSua.UseVisualStyleBackColor = true;
            this.btunSua.Click += new System.EventHandler(this.btunSua_Click);
            // 
            // btunKT
            // 
            this.btunKT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunKT.BackgroundImage")));
            this.btunKT.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunKT.Image = ((System.Drawing.Image)(resources.GetObject("btunKT.Image")));
            this.btunKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunKT.Location = new System.Drawing.Point(319, 19);
            this.btunKT.Name = "btunKT";
            this.btunKT.Size = new System.Drawing.Size(85, 26);
            this.btunKT.TabIndex = 0;
            this.btunKT.Text = "Khởi Tạo";
            this.btunKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunKT.UseVisualStyleBackColor = true;
            this.btunKT.Click += new System.EventHandler(this.btunKT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.txtbCharID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbGT);
            this.groupBox2.Controls.Add(this.dtpicker);
            this.groupBox2.Controls.Add(this.txtbDC);
            this.groupBox2.Controls.Add(this.txtbSDT);
            this.groupBox2.Controls.Add(this.txtbTen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtbCharID
            // 
            this.txtbCharID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbCharID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCharID.Location = new System.Drawing.Point(587, 93);
            this.txtbCharID.Multiline = true;
            this.txtbCharID.Name = "txtbCharID";
            this.txtbCharID.Size = new System.Drawing.Size(350, 33);
            this.txtbCharID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(504, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(587, 52);
            this.txtbEmail.Multiline = true;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(350, 33);
            this.txtbEmail.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(504, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Định Danh:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(504, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giới Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày Sinh:";
            // 
            // cmbGT
            // 
            this.cmbGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGT.FormattingEnabled = true;
            this.cmbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGT.Location = new System.Drawing.Point(118, 97);
            this.cmbGT.Name = "cmbGT";
            this.cmbGT.Size = new System.Drawing.Size(349, 24);
            this.cmbGT.TabIndex = 11;
            // 
            // dtpicker
            // 
            this.dtpicker.CustomFormat = "";
            this.dtpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker.Location = new System.Drawing.Point(118, 59);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(349, 29);
            this.dtpicker.TabIndex = 10;
            this.dtpicker.UseWaitCursor = true;
            this.dtpicker.Value = new System.DateTime(2022, 10, 31, 3, 47, 15, 0);
            // 
            // txtbDC
            // 
            this.txtbDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDC.Location = new System.Drawing.Point(587, 12);
            this.txtbDC.Multiline = true;
            this.txtbDC.Name = "txtbDC";
            this.txtbDC.Size = new System.Drawing.Size(350, 33);
            this.txtbDC.TabIndex = 7;
            // 
            // txtbSDT
            // 
            this.txtbSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSDT.Location = new System.Drawing.Point(118, 127);
            this.txtbSDT.Multiline = true;
            this.txtbSDT.Name = "txtbSDT";
            this.txtbSDT.Size = new System.Drawing.Size(349, 33);
            this.txtbSDT.TabIndex = 5;
            // 
            // txtbTen
            // 
            this.txtbTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTen.Location = new System.Drawing.Point(118, 19);
            this.txtbTen.Multiline = true;
            this.txtbTen.Name = "txtbTen";
            this.txtbTen.Size = new System.Drawing.Size(349, 33);
            this.txtbTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.dgvInfo);
            this.groupBox3.Location = new System.Drawing.Point(13, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị";
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.CharID,
            this.HoVaTen,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT,
            this.DiaChi,
            this.Email,
            this.UserName});
            this.dgvInfo.Location = new System.Drawing.Point(6, 19);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(945, 223);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // CharID
            // 
            this.CharID.DataPropertyName = "CharID";
            this.CharID.HeaderText = "Char ID";
            this.CharID.Name = "CharID";
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ Và Tên";
            this.HoVaTen.Name = "HoVaTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // FormTTCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(975, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTTCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Người Dùng - Leo Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btunSua;
        private System.Windows.Forms.Button btunKT;
        private System.Windows.Forms.Button btunThoat;
        private System.Windows.Forms.Button btunXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGT;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.TextBox txtbDC;
        private System.Windows.Forms.TextBox txtbSDT;
        private System.Windows.Forms.TextBox txtbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.TextBox txtbCharID;
    }
}