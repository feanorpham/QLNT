namespace projectC
{
    partial class FormHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHopDong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHDCN = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btunThoat = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btunPrint = new System.Windows.Forms.Button();
            this.btunThoat1 = new System.Windows.Forms.Button();
            this.CharHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDCN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hợp đồng cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHDCN);
            this.groupBox2.Location = new System.Drawing.Point(7, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển Thị";
            // 
            // dgvHDCN
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHDCN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharHD,
            this.HoVaTen,
            this.TenP,
            this.NgayBatDau,
            this.NgayKetThuc});
            this.dgvHDCN.Location = new System.Drawing.Point(7, 20);
            this.dgvHDCN.Name = "dgvHDCN";
            this.dgvHDCN.Size = new System.Drawing.Size(740, 287);
            this.dgvHDCN.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btunThoat);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btunThoat
            // 
            this.btunThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunThoat.BackgroundImage")));
            this.btunThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunThoat.Image = ((System.Drawing.Image)(resources.GetObject("btunThoat.Image")));
            this.btunThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunThoat.Location = new System.Drawing.Point(6, 19);
            this.btunThoat.Name = "btunThoat";
            this.btunThoat.Size = new System.Drawing.Size(87, 42);
            this.btunThoat.TabIndex = 0;
            this.btunThoat.Text = "Thoát";
            this.btunThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunThoat.UseVisualStyleBackColor = true;
            this.btunThoat.Click += new System.EventHandler(this.btunThoat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDS);
            this.groupBox4.Location = new System.Drawing.Point(7, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 317);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hiển Thị";
            // 
            // dgvDS
            // 
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDS.Location = new System.Drawing.Point(7, 20);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.Size = new System.Drawing.Size(740, 291);
            this.dgvDS.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CharHD";
            this.Column1.HeaderText = "Mã Hợp Đồng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CharID";
            this.Column2.HeaderText = "Mã Khách Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoVaTen";
            this.Column3.HeaderText = "Họ và Tên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CharP";
            this.Column4.HeaderText = "Mã Phòng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayBatDau";
            this.Column5.HeaderText = "Ngày Bắt Đầu";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayKetThuc";
            this.Column6.HeaderText = "Ngày Kết Thúc";
            this.Column6.Name = "Column6";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btunPrint);
            this.groupBox3.Controls.Add(this.btunThoat1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 64);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btunPrint
            // 
            this.btunPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunPrint.BackgroundImage")));
            this.btunPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunPrint.Image = ((System.Drawing.Image)(resources.GetObject("btunPrint.Image")));
            this.btunPrint.Location = new System.Drawing.Point(100, 19);
            this.btunPrint.Name = "btunPrint";
            this.btunPrint.Size = new System.Drawing.Size(53, 38);
            this.btunPrint.TabIndex = 1;
            this.btunPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunPrint.UseVisualStyleBackColor = true;
            this.btunPrint.Click += new System.EventHandler(this.btunPrint_Click);
            // 
            // btunThoat1
            // 
            this.btunThoat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunThoat1.BackgroundImage")));
            this.btunThoat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunThoat1.Image = ((System.Drawing.Image)(resources.GetObject("btunThoat1.Image")));
            this.btunThoat1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btunThoat1.Location = new System.Drawing.Point(8, 19);
            this.btunThoat1.Name = "btunThoat1";
            this.btunThoat1.Size = new System.Drawing.Size(86, 38);
            this.btunThoat1.TabIndex = 0;
            this.btunThoat1.Text = "Thoát";
            this.btunThoat1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btunThoat1.UseVisualStyleBackColor = true;
            this.btunThoat1.Click += new System.EventHandler(this.btunThoat1_Click);
            // 
            // CharHD
            // 
            this.CharHD.DataPropertyName = "CharHD";
            this.CharHD.HeaderText = "Mã Hợp Đồng";
            this.CharHD.Name = "CharHD";
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Tên Chủ Nhà";
            this.HoVaTen.Name = "HoVaTen";
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
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // FormHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hợp Đồng - Leo Program";
            this.Load += new System.EventHandler(this.FormHopDong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDCN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHDCN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btunThoat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btunThoat1;
        private System.Windows.Forms.Button btunPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
    }
}