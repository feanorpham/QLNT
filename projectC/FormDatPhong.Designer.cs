namespace projectC
{
    partial class FormDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btunThoat = new System.Windows.Forms.Button();
            this.btunDT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbCharP = new System.Windows.Forms.ComboBox();
            this.cmbCharID = new System.Windows.Forms.ComboBox();
            this.loandAnhPhong = new System.Windows.Forms.PictureBox();
            this.txtbGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbLoaiP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTenCN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDP = new System.Windows.Forms.DataGridView();
            this.TenP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageP = new System.Windows.Forms.DataGridViewImageColumn();
            this.CharP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loandAnhPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btunThoat);
            this.groupBox1.Controls.Add(this.btunDT);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btunThoat
            // 
            this.btunThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunThoat.BackgroundImage")));
            this.btunThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunThoat.Image = ((System.Drawing.Image)(resources.GetObject("btunThoat.Image")));
            this.btunThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btunThoat.Location = new System.Drawing.Point(124, 24);
            this.btunThoat.Name = "btunThoat";
            this.btunThoat.Size = new System.Drawing.Size(83, 55);
            this.btunThoat.TabIndex = 1;
            this.btunThoat.Text = "Thoát";
            this.btunThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btunThoat.UseVisualStyleBackColor = true;
            this.btunThoat.Click += new System.EventHandler(this.btunThoat_Click);
            // 
            // btunDT
            // 
            this.btunDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btunDT.BackgroundImage")));
            this.btunDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunDT.Image = ((System.Drawing.Image)(resources.GetObject("btunDT.Image")));
            this.btunDT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btunDT.Location = new System.Drawing.Point(23, 24);
            this.btunDT.Name = "btunDT";
            this.btunDT.Size = new System.Drawing.Size(83, 55);
            this.btunDT.TabIndex = 0;
            this.btunDT.Text = "Đặt Phòng";
            this.btunDT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btunDT.UseVisualStyleBackColor = true;
            this.btunDT.Click += new System.EventHandler(this.btunDT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.cmbUser);
            this.groupBox2.Controls.Add(this.cmbCharP);
            this.groupBox2.Controls.Add(this.cmbCharID);
            this.groupBox2.Controls.Add(this.loandAnhPhong);
            this.groupBox2.Controls.Add(this.txtbGia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbSDT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbDiaChi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbLoaiP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbTenCN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(15, 269);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(112, 21);
            this.cmbUser.TabIndex = 13;
            this.cmbUser.Visible = false;
            // 
            // cmbCharP
            // 
            this.cmbCharP.FormattingEnabled = true;
            this.cmbCharP.Location = new System.Drawing.Point(15, 269);
            this.cmbCharP.Name = "cmbCharP";
            this.cmbCharP.Size = new System.Drawing.Size(112, 21);
            this.cmbCharP.TabIndex = 12;
            this.cmbCharP.Visible = false;
            // 
            // cmbCharID
            // 
            this.cmbCharID.FormattingEnabled = true;
            this.cmbCharID.Location = new System.Drawing.Point(15, 269);
            this.cmbCharID.Name = "cmbCharID";
            this.cmbCharID.Size = new System.Drawing.Size(112, 21);
            this.cmbCharID.TabIndex = 11;
            this.cmbCharID.Visible = false;
            // 
            // loandAnhPhong
            // 
            this.loandAnhPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loandAnhPhong.BackgroundImage")));
            this.loandAnhPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loandAnhPhong.Location = new System.Drawing.Point(401, 15);
            this.loandAnhPhong.Name = "loandAnhPhong";
            this.loandAnhPhong.Size = new System.Drawing.Size(457, 264);
            this.loandAnhPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loandAnhPhong.TabIndex = 10;
            this.loandAnhPhong.TabStop = false;
            // 
            // txtbGia
            // 
            this.txtbGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbGia.Location = new System.Drawing.Point(139, 71);
            this.txtbGia.Multiline = true;
            this.txtbGia.Name = "txtbGia";
            this.txtbGia.Size = new System.Drawing.Size(245, 35);
            this.txtbGia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(17, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // txtbSDT
            // 
            this.txtbSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSDT.Location = new System.Drawing.Point(139, 227);
            this.txtbSDT.Multiline = true;
            this.txtbSDT.Name = "txtbSDT";
            this.txtbSDT.Size = new System.Drawing.Size(245, 35);
            this.txtbSDT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(17, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ Phòng:";
            // 
            // txtbDiaChi
            // 
            this.txtbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDiaChi.Location = new System.Drawing.Point(139, 176);
            this.txtbDiaChi.Multiline = true;
            this.txtbDiaChi.Name = "txtbDiaChi";
            this.txtbDiaChi.Size = new System.Drawing.Size(245, 35);
            this.txtbDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại Phòng:";
            // 
            // txtbLoaiP
            // 
            this.txtbLoaiP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbLoaiP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoaiP.Location = new System.Drawing.Point(139, 120);
            this.txtbLoaiP.Multiline = true;
            this.txtbLoaiP.Name = "txtbLoaiP";
            this.txtbLoaiP.Size = new System.Drawing.Size(245, 35);
            this.txtbLoaiP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá Phòng:";
            // 
            // txtbTenCN
            // 
            this.txtbTenCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbTenCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenCN.Location = new System.Drawing.Point(139, 19);
            this.txtbTenCN.Multiline = true;
            this.txtbTenCN.Name = "txtbTenCN";
            this.txtbTenCN.Size = new System.Drawing.Size(245, 35);
            this.txtbTenCN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủ Nhà:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.dgvDP);
            this.groupBox3.Location = new System.Drawing.Point(12, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 273);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển Thị";
            // 
            // dgvDP
            // 
            this.dgvDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenP,
            this.DiaChiP,
            this.LoaiP,
            this.GiaPhong,
            this.TinhTrang,
            this.HoVaTen,
            this.SDT,
            this.ImageP,
            this.CharP,
            this.UserName});
            this.dgvDP.Location = new System.Drawing.Point(6, 18);
            this.dgvDP.Name = "dgvDP";
            this.dgvDP.Size = new System.Drawing.Size(853, 248);
            this.dgvDP.TabIndex = 0;
            this.dgvDP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDP_CellContentClick);
            // 
            // TenP
            // 
            this.TenP.DataPropertyName = "TenP";
            this.TenP.HeaderText = "Tên Phòng";
            this.TenP.Name = "TenP";
            // 
            // DiaChiP
            // 
            this.DiaChiP.DataPropertyName = "DiaChiP";
            this.DiaChiP.FillWeight = 220F;
            this.DiaChiP.HeaderText = "Địa Chỉ";
            this.DiaChiP.Name = "DiaChiP";
            this.DiaChiP.Width = 220;
            // 
            // LoaiP
            // 
            this.LoaiP.DataPropertyName = "LoaiP";
            this.LoaiP.HeaderText = "Loại Phòng";
            this.LoaiP.Name = "LoaiP";
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá Phòng";
            this.GiaPhong.Name = "GiaPhong";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Chủ Phòng";
            this.HoVaTen.Name = "HoVaTen";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            // 
            // ImageP
            // 
            this.ImageP.DataPropertyName = "ImageP";
            this.ImageP.FillWeight = 240F;
            this.ImageP.HeaderText = "Hình Ảnh";
            this.ImageP.Name = "ImageP";
            this.ImageP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImageP.Visible = false;
            this.ImageP.Width = 240;
            // 
            // CharP
            // 
            this.CharP.DataPropertyName = "CharP";
            this.CharP.HeaderText = "Column2";
            this.CharP.Name = "CharP";
            this.CharP.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Column1";
            this.UserName.Name = "UserName";
            this.UserName.Visible = false;
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(893, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phòng - Leo Progarm";
            this.Load += new System.EventHandler(this.FormDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loandAnhPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbLoaiP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTenCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btunDT;
        private System.Windows.Forms.Button btunThoat;
        private System.Windows.Forms.PictureBox loandAnhPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDP;
        private System.Windows.Forms.ComboBox cmbCharP;
        private System.Windows.Forms.ComboBox cmbCharID;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewImageColumn ImageP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}