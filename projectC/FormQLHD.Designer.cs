namespace projectC
{
    partial class FormQLHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btunUpdate = new System.Windows.Forms.Button();
            this.rdXoaHD = new System.Windows.Forms.RadioButton();
            this.rdHTHD = new System.Windows.Forms.RadioButton();
            this.rdSuaHD = new System.Windows.Forms.RadioButton();
            this.rdThemHD = new System.Windows.Forms.RadioButton();
            this.btunThoat = new System.Windows.Forms.Button();
            this.btunXoa = new System.Windows.Forms.Button();
            this.btunKT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbMKH = new System.Windows.Forms.TextBox();
            this.txtbXoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCharP = new System.Windows.Forms.ComboBox();
            this.dtpickerNKT = new System.Windows.Forms.DateTimePicker();
            this.dtpickerNBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvQLHD = new System.Windows.Forms.DataGridView();
            this.CharHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btunUpdate);
            this.groupBox1.Controls.Add(this.rdXoaHD);
            this.groupBox1.Controls.Add(this.rdHTHD);
            this.groupBox1.Controls.Add(this.rdSuaHD);
            this.groupBox1.Controls.Add(this.rdThemHD);
            this.groupBox1.Controls.Add(this.btunThoat);
            this.groupBox1.Controls.Add(this.btunXoa);
            this.groupBox1.Controls.Add(this.btunKT);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btunUpdate
            // 
            this.btunUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunUpdate.BackgroundImage")));
            this.btunUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btunUpdate.Image")));
            this.btunUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btunUpdate.Location = new System.Drawing.Point(494, 18);
            this.btunUpdate.Name = "btunUpdate";
            this.btunUpdate.Size = new System.Drawing.Size(69, 50);
            this.btunUpdate.TabIndex = 7;
            this.btunUpdate.Text = "File HĐ";
            this.btunUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btunUpdate.UseVisualStyleBackColor = true;
            // 
            // rdXoaHD
            // 
            this.rdXoaHD.AutoSize = true;
            this.rdXoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdXoaHD.Location = new System.Drawing.Point(137, 20);
            this.rdXoaHD.Name = "rdXoaHD";
            this.rdXoaHD.Size = new System.Drawing.Size(113, 20);
            this.rdXoaHD.TabIndex = 6;
            this.rdXoaHD.TabStop = true;
            this.rdXoaHD.Text = "Xóa Hợp Đồng";
            this.rdXoaHD.UseVisualStyleBackColor = true;
            this.rdXoaHD.CheckedChanged += new System.EventHandler(this.rdXoaHD_CheckedChanged);
            // 
            // rdHTHD
            // 
            this.rdHTHD.AutoSize = true;
            this.rdHTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHTHD.Location = new System.Drawing.Point(137, 48);
            this.rdHTHD.Name = "rdHTHD";
            this.rdHTHD.Size = new System.Drawing.Size(139, 20);
            this.rdHTHD.TabIndex = 5;
            this.rdHTHD.TabStop = true;
            this.rdHTHD.Text = "Hiển Thị Hợp Đồng";
            this.rdHTHD.UseVisualStyleBackColor = true;
            // 
            // rdSuaHD
            // 
            this.rdSuaHD.AutoSize = true;
            this.rdSuaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSuaHD.Location = new System.Drawing.Point(7, 49);
            this.rdSuaHD.Name = "rdSuaHD";
            this.rdSuaHD.Size = new System.Drawing.Size(113, 20);
            this.rdSuaHD.TabIndex = 4;
            this.rdSuaHD.TabStop = true;
            this.rdSuaHD.Text = "Sửa Hợp Đồng";
            this.rdSuaHD.UseVisualStyleBackColor = true;
            this.rdSuaHD.CheckedChanged += new System.EventHandler(this.rdSuaHD_CheckedChanged);
            // 
            // rdThemHD
            // 
            this.rdThemHD.AutoSize = true;
            this.rdThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThemHD.Location = new System.Drawing.Point(7, 20);
            this.rdThemHD.Name = "rdThemHD";
            this.rdThemHD.Size = new System.Drawing.Size(124, 20);
            this.rdThemHD.TabIndex = 3;
            this.rdThemHD.TabStop = true;
            this.rdThemHD.Text = "Thêm Hợp Đồng";
            this.rdThemHD.UseVisualStyleBackColor = true;
            this.rdThemHD.CheckedChanged += new System.EventHandler(this.rdThemHD_CheckedChanged);
            // 
            // btunThoat
            // 
            this.btunThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunThoat.BackgroundImage")));
            this.btunThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunThoat.Image = ((System.Drawing.Image)(resources.GetObject("btunThoat.Image")));
            this.btunThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btunThoat.Location = new System.Drawing.Point(569, 18);
            this.btunThoat.Name = "btunThoat";
            this.btunThoat.Size = new System.Drawing.Size(67, 50);
            this.btunThoat.TabIndex = 2;
            this.btunThoat.Text = "Thoát";
            this.btunThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btunThoat.UseVisualStyleBackColor = true;
            this.btunThoat.Click += new System.EventHandler(this.btunThoat_Click);
            // 
            // btunXoa
            // 
            this.btunXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunXoa.BackgroundImage")));
            this.btunXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunXoa.Image = ((System.Drawing.Image)(resources.GetObject("btunXoa.Image")));
            this.btunXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btunXoa.Location = new System.Drawing.Point(417, 18);
            this.btunXoa.Name = "btunXoa";
            this.btunXoa.Size = new System.Drawing.Size(67, 50);
            this.btunXoa.TabIndex = 1;
            this.btunXoa.Text = "Xóa";
            this.btunXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btunXoa.UseVisualStyleBackColor = true;
            this.btunXoa.Click += new System.EventHandler(this.btunXoa_Click);
            // 
            // btunKT
            // 
            this.btunKT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunKT.BackgroundImage")));
            this.btunKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunKT.Image = ((System.Drawing.Image)(resources.GetObject("btunKT.Image")));
            this.btunKT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btunKT.Location = new System.Drawing.Point(340, 18);
            this.btunKT.Name = "btunKT";
            this.btunKT.Size = new System.Drawing.Size(71, 50);
            this.btunKT.TabIndex = 0;
            this.btunKT.Text = "Khởi Tạo";
            this.btunKT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btunKT.UseVisualStyleBackColor = true;
            this.btunKT.Click += new System.EventHandler(this.btunKT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.txtbMKH);
            this.groupBox2.Controls.Add(this.txtbXoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbCharP);
            this.groupBox2.Controls.Add(this.dtpickerNKT);
            this.groupBox2.Controls.Add(this.dtpickerNBD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.d);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // txtbMKH
            // 
            this.txtbMKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMKH.Location = new System.Drawing.Point(99, 42);
            this.txtbMKH.Multiline = true;
            this.txtbMKH.Name = "txtbMKH";
            this.txtbMKH.Size = new System.Drawing.Size(259, 27);
            this.txtbMKH.TabIndex = 16;
            // 
            // txtbXoa
            // 
            this.txtbXoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbXoa.Location = new System.Drawing.Point(99, 74);
            this.txtbXoa.Multiline = true;
            this.txtbXoa.Name = "txtbXoa";
            this.txtbXoa.Size = new System.Drawing.Size(259, 27);
            this.txtbXoa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã Khách:";
            // 
            // cmbCharP
            // 
            this.cmbCharP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCharP.FormattingEnabled = true;
            this.cmbCharP.Location = new System.Drawing.Point(99, 14);
            this.cmbCharP.Name = "cmbCharP";
            this.cmbCharP.Size = new System.Drawing.Size(259, 25);
            this.cmbCharP.TabIndex = 9;
            this.cmbCharP.SelectedIndexChanged += new System.EventHandler(this.cmbCharP_SelectedIndexChanged);
            // 
            // dtpickerNKT
            // 
            this.dtpickerNKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerNKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerNKT.Location = new System.Drawing.Point(496, 42);
            this.dtpickerNKT.Name = "dtpickerNKT";
            this.dtpickerNKT.Size = new System.Drawing.Size(124, 23);
            this.dtpickerNKT.TabIndex = 7;
            // 
            // dtpickerNBD
            // 
            this.dtpickerNBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerNBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerNBD.Location = new System.Drawing.Point(496, 14);
            this.dtpickerNBD.Name = "dtpickerNBD";
            this.dtpickerNBD.Size = new System.Drawing.Size(124, 23);
            this.dtpickerNBD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(377, 45);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(112, 16);
            this.d.TabIndex = 4;
            this.d.Text = "Ngày Kết Thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phòng:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.dgvQLHD);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển Thị";
            // 
            // dgvQLHD
            // 
            this.dgvQLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharHD,
            this.CharID,
            this.HoVaTen,
            this.CharP,
            this.TenP,
            this.NgayBatDau,
            this.NgayKetThuc});
            this.dgvQLHD.Location = new System.Drawing.Point(7, 20);
            this.dgvQLHD.Name = "dgvQLHD";
            this.dgvQLHD.Size = new System.Drawing.Size(782, 189);
            this.dgvQLHD.TabIndex = 0;
            this.dgvQLHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLHD_CellContentClick);
            this.dgvQLHD.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvQLHD_CellFormatting);
            // 
            // CharHD
            // 
            this.CharHD.DataPropertyName = "CharHD";
            this.CharHD.HeaderText = "Mã Hợp Đồng";
            this.CharHD.Name = "CharHD";
            // 
            // CharID
            // 
            this.CharID.DataPropertyName = "CharID";
            this.CharID.HeaderText = "Mã Khách Hàng";
            this.CharID.Name = "CharID";
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ Và Tên";
            this.HoVaTen.Name = "HoVaTen";
            // 
            // CharP
            // 
            this.CharP.DataPropertyName = "CharP";
            this.CharP.HeaderText = "Mã Phòng";
            this.CharP.Name = "CharP";
            // 
            // TenP
            // 
            this.TenP.DataPropertyName = "TenP";
            this.TenP.HeaderText = "Tên Phòng";
            this.TenP.Name = "TenP";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.FillWeight = 120F;
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 120;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.FillWeight = 120F;
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 120;
            // 
            // FormQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hợp Đồng - Leo Program";
            this.Load += new System.EventHandler(this.FormQLHD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btunXoa;
        private System.Windows.Forms.Button btunKT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btunThoat;
        private System.Windows.Forms.RadioButton rdXoaHD;
        private System.Windows.Forms.RadioButton rdHTHD;
        private System.Windows.Forms.RadioButton rdSuaHD;
        private System.Windows.Forms.RadioButton rdThemHD;
        private System.Windows.Forms.ComboBox cmbCharP;
        private System.Windows.Forms.DateTimePicker dtpickerNKT;
        private System.Windows.Forms.DateTimePicker dtpickerNBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQLHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btunUpdate;
        private System.Windows.Forms.TextBox txtbMKH;
    }
}