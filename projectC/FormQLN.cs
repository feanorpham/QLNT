using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace projectC
{
    public partial class FormQLN : Form
    {
        string imageUrl = null;
        string TK = "", MK = "", QuyenUser = "";
        public FormQLN()
        {
            InitializeComponent();
     //       loadIDP();
            cmdMP.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            txtbXoa.Enabled = false;
        }
        public FormQLN(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            txtbCharID.Enabled = false;
            cmdMP.Enabled = false;
            txtbXoa.Enabled = false;
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
            loandCharID();
            loandIDPhong();
            loandLP();
            loandSumP();
        }
        void loandSumP()
        {
            txtbSL.Enabled = false;
            txtbCT.Enabled = false;
            txtbDT.Enabled = false;
            txtbDCT.Enabled = false;
            string KT = "Chưa Thuê";
            string KT1 = "Đã Thuê";
            string KT2 = "Đang Chờ Thuê";
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            SqlCommand cmd = new SqlCommand("exec Count_P '" + txtbCharID.Text + "'", sqlconect);
            SqlCommand cmd1 = new SqlCommand("exec Count_TinhTrang '" + txtbCharID.Text + "',N'" + KT.ToString() + "'", sqlconect);
            SqlCommand cmd2 = new SqlCommand("exec Count_TinhTrang '" + txtbCharID.Text + "',N'" + KT1.ToString() + "'", sqlconect);
            SqlCommand cmd3 = new SqlCommand("exec Count_TinhTrang '" + txtbCharID.Text + "',N'" + KT2.ToString() + "'", sqlconect);
            var count1 = cmd.ExecuteScalar();
            var count2 = cmd1.ExecuteScalar();
            var count3 = cmd2.ExecuteScalar();
            var count4 = cmd3.ExecuteScalar();
            txtbSL.Text = count1.ToString();
            txtbCT.Text = count2.ToString();
            txtbDT.Text = count3.ToString();
            txtbDCT.Text = count4.ToString();
            sqlconect.Close();
        }
        void loandCharID()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            SqlCommand cmd = new SqlCommand("select* from tb_KhachHang where UserName = '"+TK.ToString()+"'",sqlconect);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtbCharID.Text = reader.GetValue(1).ToString();
            }
            sqlconect.Close();
        }
        void loandIDPhong()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            var cmd = new SqlCommand("select* from tb_Phong where CharID = '" + txtbCharID.Text + "'", sqlconect);
            var ex = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(ex);
            ex.Dispose();
            cmdMP.DisplayMember = "CharP";
            cmdMP.DataSource = dt;
            sqlconect.Close();
        }
        void loandLP()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            var cmd = new SqlCommand("select distinct LoaiP from tb_Phong ", sqlconect);
            var ex = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(ex);
            ex.Dispose();
            cmbLoaiP.DisplayMember = "LoaiP";
            cmbLoaiP.DataSource = dt;
            sqlconect.Close();
        }
        bool CheckValuesInput()
        {
            if (txtbTenP.Text.Trim() == "" || txtbDiaChiP.Text.Trim() == "" || cmbLoaiP.Text.Trim() == "" || txtbGiaP.Text.Trim() == "" || cmbTT.Text.Trim() == "" || txtbFileAnh.Text.Trim() == "")
                return false;
            else
                return true;
        }
        bool CheckValuesTenP() // kiểm tra tên phòng đã tồn tại chưa
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            string check = "select TenP from tb_Phong where TenP = '" + txtbTenP.Text + "'";
            SqlCommand cmd = new SqlCommand(check, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return false;
                sqlConnection.Close();

            }
            else
            {
                return true;
                sqlConnection.Close();
            }
    }
        bool CheckValuesTenP1() // kiểm tra tên phòng tồn tại chưa để sửa
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            string check = "exec Check_TenP '" + cmdMP.Text + "',N'" + txtbTenP.Text + "'";
            SqlCommand cmd = new SqlCommand(check, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
                sqlConnection.Close();

            }
            else
            {
                return false;
                sqlConnection.Close();
            }
        }
        void DeleteHD()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            string update = "exec XoaHD '" + cmdMP.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd = sqlconect.CreateCommand();
            cmd.CommandText = update;
            cmd.ExecuteNonQuery();
            sqlconect.Close();
        }
        bool CheckValuesDelete_P()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            string check = "select TenP from tb_Phong where TenP = N'" + txtbXoa.Text + "' and CharID in (select CharID from tb_KhachHang where UserName in (select UserName from tb_User where UserName = '" + TK.ToString() + "'))";
            SqlCommand cmd = new SqlCommand(check, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
                sqlConnection.Close();

            }
            else
            {
                return false;
                sqlConnection.Close();
            }
        }
        private void btunKT_Click(object sender, EventArgs e)
        {
            if (rdThemP.Checked == true)
            {
               if(CheckValuesInput() == false || CheckValuesTenP() == false)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin hoặc tên phòng đã tồn tại", "Thông báo");
                }
                else
                {
                    Image img = pbLoadImager.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                    sqlconect.Open();
                    string insert = "insert into tb_Phong values(@TenP,@DiaChiP,@LoaiP,@GiaP,@Image,@UrlImage,@CharID,@TinhTrang)";
                    SqlCommand cmd = new SqlCommand();
                    cmd = sqlconect.CreateCommand();
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@TenP", txtbTenP.Text);
                    cmd.Parameters.AddWithValue("@DiaChiP", txtbDiaChiP.Text);
                    cmd.Parameters.AddWithValue("@LoaiP", cmbLoaiP.Text);
                    cmd.Parameters.AddWithValue("GiaP", txtbGiaP.Text);
                    cmd.Parameters.AddWithValue("@Image", arr);
                    cmd.Parameters.AddWithValue("@UrlImage", txtbFileAnh.Text);
                    cmd.Parameters.AddWithValue("@CharID", txtbCharID.Text);
                    cmd.Parameters.AddWithValue("@TinhTrang", cmbTT.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm phòng thành công", "Thông báo");
                    FormQLN_Load(sender, e);
                }
            }
            if (rdhtP.Checked == true)
            {
                string ht = "exec Phong_QLCN '" + txtbCharID.Text + "'";
                conectsql sqlconect = new conectsql();
                dgvQLN.DataSource = sqlconect.ExecuteQuery(ht);
            }
            if (rdSuaP.Checked == true)
            {
                if(CheckValuesInput() == false)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                }
                else
                {
                    if (CheckValuesTenP1() == true)
                    {
                        SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                        string check = "exec SavePHD '" + cmdMP.Text + "', '" + TK.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(check, sqlConnection);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            if (MessageBox.Show("Nếu bạn thay đổi tình trạng phòng thì sẽ xóa hợp đồng bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                DeleteHD();
                                Image img = pbLoadImager.Image;
                                byte[] arr;
                                ImageConverter converter = new ImageConverter();
                                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                                SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                                sqlconect.Open();
                                string insert = "update tb_Phong set TenP = @TenP, DiaChiP = @DiaChiP, LoaiP = @LoaiP, GiaPhong = @GiaP, ImageP = @Image, CharID = @CharID, TinhTrang = @TinhTrang where CharP = '" + cmdMP.Text + "'";
  //                              SqlCommand cmd = new SqlCommand();
                                cmd = sqlconect.CreateCommand();
                                cmd.CommandText = insert;
                                cmd.Parameters.AddWithValue("@TenP", txtbTenP.Text);
                                cmd.Parameters.AddWithValue("@DiaChiP", txtbDiaChiP.Text);
                                cmd.Parameters.AddWithValue("@LoaiP", cmbLoaiP.Text);
                                cmd.Parameters.AddWithValue("GiaP", txtbGiaP.Text);
                                cmd.Parameters.AddWithValue("@Image", arr);
                                cmd.Parameters.AddWithValue("@CharID", txtbCharID.Text);
                                cmd.Parameters.AddWithValue("@TinhTrang", cmbTT.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Sửa phòng thành công", "Thông báo");
                                FormQLN_Load(sender, e);
                            }
                            else
                            {
                                txtbTenP.Focus();
                            }
                        }
                        else
                        {
                            Image img = pbLoadImager.Image;
                            byte[] arr;
                            ImageConverter converter = new ImageConverter();
                            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                            sqlconect.Open();
                            string insert = "update tb_Phong set TenP = @TenP, DiaChiP = @DiaChiP, LoaiP = @LoaiP, GiaPhong = @GiaP, ImageP = @Image, CharID = @CharID, TinhTrang = @TinhTrang where CharP = '" + cmdMP.Text + "'";
 //                           SqlCommand cmd = new SqlCommand();
                            cmd = sqlconect.CreateCommand();
                            cmd.CommandText = insert;
                            cmd.Parameters.AddWithValue("@TenP", txtbTenP.Text);
                            cmd.Parameters.AddWithValue("@DiaChiP", txtbDiaChiP.Text);
                            cmd.Parameters.AddWithValue("@LoaiP", cmbLoaiP.Text);
                            cmd.Parameters.AddWithValue("GiaP", txtbGiaP.Text);
                            cmd.Parameters.AddWithValue("@Image", arr);
                            cmd.Parameters.AddWithValue("@CharID", txtbCharID.Text);
                            cmd.Parameters.AddWithValue("@TinhTrang", cmbTT.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sửa phòng thành công", "Thông báo");
                            FormQLN_Load(sender, e);
                        }

                    }
                    else 
                    {
                        if(CheckValuesTenP() == false)
                        {
                            MessageBox.Show("Tên phòng đã tồn tại", "Thông báo");
                        }
                        else
                        {
                            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                            string check = "exec SavePHD '" + cmdMP.Text + "', '" + TK.ToString() + "'";
                            SqlCommand cmd = new SqlCommand(check, sqlConnection);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                if (MessageBox.Show("Nếu bạn thay đổi tình trạng phòng thì sẽ xóa hợp đồng bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    DeleteHD();
                                    Image img = pbLoadImager.Image;
                                    byte[] arr;
                                    ImageConverter converter = new ImageConverter();
                                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                                    SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                                    sqlconect.Open();
                                    string insert = "update tb_Phong set TenP = @TenP, DiaChiP = @DiaChiP, LoaiP = @LoaiP, GiaPhong = @GiaP, ImageP = @Image, CharID = @CharID, TinhTrang = @TinhTrang where CharP = '" + cmdMP.Text + "'";
 //                                   SqlCommand cmd = new SqlCommand();
                                    cmd = sqlconect.CreateCommand();
                                    cmd.CommandText = insert;
                                    cmd.Parameters.AddWithValue("@TenP", txtbTenP.Text);
                                    cmd.Parameters.AddWithValue("@DiaChiP", txtbDiaChiP.Text);
                                    cmd.Parameters.AddWithValue("@LoaiP", cmbLoaiP.Text);
                                    cmd.Parameters.AddWithValue("GiaP", txtbGiaP.Text);
                                    cmd.Parameters.AddWithValue("@Image", arr);
                                    cmd.Parameters.AddWithValue("@CharID", txtbCharID.Text);
                                    cmd.Parameters.AddWithValue("@TinhTrang", cmbTT.Text);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Sửa phòng thành công", "Thông báo");
                                    FormQLN_Load(sender, e);
                                }
                                else
                                {
                                    txtbTenP.Focus();
                                }
                            }
                            else
                            {
                                Image img = pbLoadImager.Image;
                                byte[] arr;
                                ImageConverter converter = new ImageConverter();
                                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                                SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                                sqlconect.Open();
                                string insert = "update tb_Phong set TenP = @TenP, DiaChiP = @DiaChiP, LoaiP = @LoaiP, GiaPhong = @GiaP, ImageP = @Image, CharID = @CharID, TinhTrang = @TinhTrang where CharP = '" + cmdMP.Text + "'";
 //                               SqlCommand cmd = new SqlCommand();
                                cmd = sqlconect.CreateCommand();
                                cmd.CommandText = insert;
                                cmd.Parameters.AddWithValue("@TenP", txtbTenP.Text);
                                cmd.Parameters.AddWithValue("@DiaChiP", txtbDiaChiP.Text);
                                cmd.Parameters.AddWithValue("@LoaiP", cmbLoaiP.Text);
                                cmd.Parameters.AddWithValue("GiaP", txtbGiaP.Text);
                                cmd.Parameters.AddWithValue("@Image", arr);
                                cmd.Parameters.AddWithValue("@CharID", txtbCharID.Text);
                                cmd.Parameters.AddWithValue("@TinhTrang", cmbTT.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Sửa phòng thành công", "Thông báo");
                                FormQLN_Load(sender, e);
                            }
                        }
                    }
                }
            }
        }

        private void btunBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog())
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                { 
                    imageUrl = dlg.FileName;
                    pbLoadImager.Image = Image.FromFile(dlg.FileName);
                    txtbFileAnh.Text = imageUrl;
                }
            }
        }

        private void rdSuaP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSuaP.Checked == true)
            {
                cmdMP.Enabled = true;
                cmbTT.Enabled = true;
            }
            else
            {
                cmdMP.Enabled = false;
                cmbTT.Enabled = false;
            }  
        }

        private void btunXoa_Click(object sender, EventArgs e)
        {
            txtbTenP.Text = "";
            txtbDiaChiP.Text = "";
            cmbLoaiP.Text = "";
            txtbGiaP.Text = "";
            txtbFileAnh.Text = "";
            cmdMP.Text = "";
            pbLoadImager.Image = null;
            txtbTenP.Focus();
            if (rdXoaP.Checked == true)
            {
                if(txtbXoa.Text.Trim() == "" || CheckValuesDelete_P() == false)
                {
                    MessageBox.Show("Hãy nhập tên phòng cần xóa hoặc tên phòng không tồn tại", "Thông báo");
                }
                else
                {
                    SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                    sqlconect.Open();
                    string insert = "exec XoaP N'" + txtbXoa.Text + "', '" + TK.ToString() + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd = sqlconect.CreateCommand();
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa phòng thành công", "Thông báo");
                    txtbXoa.Text = "";
                    txtbTenP.Focus();
                    FormQLN_Load(sender, e);
                }
            }
        }

        private void rdXoaP_CheckedChanged(object sender, EventArgs e)
        {
            if(rdXoaP.Checked == true)
                txtbXoa.Enabled = true;
            else
                txtbXoa.Enabled = false;
        }

        private void FormQLN_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain f = new FormMain(TK,MK,QuyenUser);
            f.Show();
            this.Hide();
        }

        private void rdThemP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThemP.Checked == true)
            {
                cmbTT.Enabled = false;
                cmbTT.Text = "Chưa Thuê";
            }
            else
                cmbTT.Enabled = true;
        }

        private void FormQLN_Load(object sender, EventArgs e)
        {
            string output = "exec Phong_QLCN '" + txtbCharID.Text + "'";
            conectsql conectTo = new conectsql();
            dgvQLN.DataSource = conectTo.ExecuteQuery(output);
            loandIDPhong();
            loandLP();
            loandCharID();
            loandSumP();
        }

        private void btunHD_Click(object sender, EventArgs e)
        {
            FormQLHD f = new FormQLHD(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void txtbGiaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK,MK,QuyenUser);
            f.Show();
            this.Hide();
        }

        private void dgvQLN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvQLN.CurrentRow.Index;
            txtbTenP.Text = dgvQLN.Rows[i].Cells[1].Value.ToString();
            txtbDiaChiP.Text = dgvQLN.Rows[i].Cells[2].Value.ToString();
            cmbLoaiP.Text = dgvQLN.Rows[i].Cells[3].Value.ToString();
            txtbGiaP.Text = dgvQLN.Rows[i].Cells[4].Value.ToString();
            cmdMP.Text = dgvQLN.Rows[i].Cells[0].Value.ToString();
            txtbFileAnh.Text = dgvQLN.Rows[i].Cells[6].Value.ToString();
            cmbTT.Text = dgvQLN.Rows[i].Cells[7].Value.ToString();
            byte[] bytes = (byte[])dgvQLN.Rows[i].Cells[5].Value;
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            pbLoadImager.Image = img;
            if (rdXoaP.Checked == true)
                txtbXoa.Text = dgvQLN.Rows[i].Cells[1].Value.ToString();
            else
                txtbXoa.Text = "";
        }
    }
}
