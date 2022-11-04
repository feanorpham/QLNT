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

namespace projectC
{
    public partial class FormMain : Form
    {
        string TK = "", MK = "", QuyenUser = "";
        public FormMain()
        {
            InitializeComponent();
            tlmenuHT.Enabled = false;
            tlmenuUser.Enabled = false;
            tlmenuSigout.Enabled = false;
        }
        public FormMain(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
            tlmenuUser.Enabled = true;
            tlmenuHT.Enabled = false;
            tlmenuSigout.Enabled = true;
            tlmenuLogin.Enabled = false;
            qlpt.Enabled = false;
            tlmenuND.Enabled = false;
            checkInfo();
            if (QuyenUser=="Chủ Nhà")
            {
                btunDP.Enabled = false;
                tlmenuHT.Enabled = true;
                qlpt.Enabled = true;
                loandCheckDT();
            }
            else if (QuyenUser == "Admin")
            {
                tlmenuHD.Enabled = false;
                tlmenuQLHD.Enabled = false;
                btunDP.Enabled = false;
                tlmenuHT.Enabled = true;
                tlmenuND.Enabled = true;
            }
            else
            {
                tlmenuHT.Enabled = false;
            }
        }
        void loandSumP()
        {
            txtb1.Enabled = false;
            txtb2.Enabled = false;
            txtb3.Enabled = false;
            txtb4.Enabled = false;
            string KT = "Chưa Thuê";
            string KT1 = "Đã Thuê";
            string KT2 = "Đang Chờ Thuê";
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            SqlCommand cmd = new SqlCommand("select count(CharP) from tb_Phong", sqlconect);
            SqlCommand cmd1 = new SqlCommand("select count(CharP) from tb_Phong where TinhTrang = N'Chưa Thuê'", sqlconect);
            SqlCommand cmd2 = new SqlCommand("select count(CharP) from tb_Phong where TinhTrang = N'Đã Thuê'", sqlconect);
            SqlCommand cmd3 = new SqlCommand("select count(CharP) from tb_Phong where TinhTrang = N'Đang Chờ Thuê'", sqlconect);
            var count1 = cmd.ExecuteScalar();
            var count2 = cmd1.ExecuteScalar();
            var count3 = cmd2.ExecuteScalar();
            var count4 = cmd3.ExecuteScalar();
            txtb1.Text = count1.ToString();
            txtb2.Text = count2.ToString();
            txtb3.Text = count3.ToString();
            txtb4.Text = count4.ToString();
            sqlconect.Close();
        }
        private void tlmenuLogin_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();

        }

        private void tlmenuSigout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất","Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát!!", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TTuser_Click(object sender, EventArgs e)
        {
            FormTTCN f = new FormTTCN(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }
        void loandCheckDT()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            string check = "select* from tb_DatPhong where UserName = '" + TK.ToString() + "'";
            SqlCommand cmd = new SqlCommand(check, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Có người đặt phòng hãy xem thông tin người đặt để liên lạc", "Thông báo", MessageBoxButtons.OK);
                sqlConnection.Close();
            }
        }
        void checkInfo()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            string check = "select* from tb_KhachHang where UserName = '" + TK.ToString() + "'";
            SqlCommand cmd = new SqlCommand(check, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Hãy cập nhập thông tin cá nhân để có thể sử dụng các chức năng", "Thông báo");
                btunDP.Enabled = false;
                tlmenuHT.Enabled = false;
                tlmenuHD.Enabled = false;
            }
            else
            {
                btunDP.Enabled = true;
                tlmenuHT.Enabled = true;
                tlmenuHD.Enabled = true;
            }
    
        }
        private void tlmenuInfoDP_Click(object sender, EventArgs e)
        {
            InfoNguoiDatPhong f = new InfoNguoiDatPhong(TK, MK, QuyenUser);
            f.Show();
        }

        private void btunDP_Click(object sender, EventArgs e)
        {
            if (TK == "")
            {
                if(MessageBox.Show("Bạn phải đăng nhập mới được đặt phóng \nNếu bạn chưa có tài khoản hãy đăng ký", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FormLogin f = new FormLogin();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                FormDatPhong f = new FormDatPhong(TK, MK, QuyenUser);
                f.Show();
                this.Hide();
            }
        }

        private void tlThemHD_Click(object sender, EventArgs e)
        {
            FormQLHD f = new FormQLHD(TK,MK,QuyenUser);
            f.Show();
            this.Hide();
        }

        private void tlSuaHD_Click(object sender, EventArgs e)
        {
            FormQLHD f = new FormQLHD(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void tlXoaHD_Click(object sender, EventArgs e)
        {
            FormQLHD f = new FormQLHD(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void tlmenuHD_Click(object sender, EventArgs e)
        {
            FormHopDong f = new FormHopDong(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void cmbGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGia.SelectedItem =="Từ thấp đến cao")
            {
                string output = "Exec SapXepTang";
                conectsql sql = new conectsql();
                dgvInfo.DataSource = sql.ExecuteQuery(output);
            }
            if(cmbGia.SelectedItem =="Từ cao đến thấp")
            {
                string output = "Exec SapXepGiam";
                conectsql sql = new conectsql();
                dgvInfo.DataSource = sql.ExecuteQuery(output);
            }
        }

        private void btunTK_Click(object sender, EventArgs e)
        {
            if (txtbTK.Text == "")
                MessageBox.Show("Hãy nhập thông tin để tìm kiếm", "Thông báo", MessageBoxButtons.OK);
            else
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                string search = "exec TKP N'" + txtbTK.Text + "'";
                SqlCommand cmd = new SqlCommand(search, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvInfo.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tim thấy hoặc chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tìm thấy phòng ở " + txtbTK.Text + " ", "Thông báo", MessageBoxButtons.OK);
                }
                
            }
        }

        private void tlSuaP_Click(object sender, EventArgs e)
        {
            FormQLN f = new FormQLN(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void tlXoaP_Click(object sender, EventArgs e)
        {
            FormQLN f = new FormQLN(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void tlThemKH_Click(object sender, EventArgs e)
        {
            FormQLND f = new FormQLND(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void tmSuaKH_Click(object sender, EventArgs e)
        {
            FormQLND f = new FormQLND(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void tlXoaKH_Click(object sender, EventArgs e)
        {
            FormQLND f = new FormQLND(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void cmbLocGiaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLocGiaP.SelectedIndex == 0)
            {
                string output = "select* from GiaTien";
                conectsql sql = new conectsql();
                dgvInfo.DataSource = sql.ExecuteQuery(output);
            }
            else if(cmbLocGiaP.SelectedIndex == 1)
            {
                string output = "select* from GiaTien1";
                conectsql sql = new conectsql();
                dgvInfo.DataSource = sql.ExecuteQuery(output);
            }
            else
            {
                string output = "select* from GiaTien2";
                conectsql sql = new conectsql();
                dgvInfo.DataSource = sql.ExecuteQuery(output);
            }
        }

        private void btunHT_Click(object sender, EventArgs e)
        {
            FormMain_Load(sender, e);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string sql = "Exec infoP";
            conectsql connectTo = new conectsql();
            dgvInfo.DataSource = connectTo.ExecuteQuery(sql);
            loandSumP();

        }

        private void tlThemP_Click(object sender, EventArgs e)
        {
            FormQLN f = new FormQLN(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }
    }
}
