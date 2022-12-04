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
    public partial class FormTTCN : Form
    {
        string TK = "", MK = "", QuyenUser = "";
        public FormTTCN()
        {
            InitializeComponent();
        }
        public FormTTCN(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
            txtbCharID.Enabled = false;
            load();
            loadUser();
        }
        bool CheckValuesInput()
        {
            if (txtbTen.Text.Trim() == "" || txtbDC.Text.Trim() == "" || dtpicker.Text.Trim() == "" || txtbEmail.Text.Trim() == "" || txtbSDT.Text.Trim() == "")
                return false;
            else
                return true;
        }
        void load()
        {
            string sql = "select* from tb_KhachHang where UserName = '" + TK.ToString() + "'";
            conectsql connectTo = new conectsql();
            dgvInfo.DataSource = connectTo.ExecuteQuery(sql);
            if (dgvInfo.Rows.Count > 1)
                btunKT.Enabled = false;
            else
                btunKT.Enabled = true;
        }

        private void btunThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }
        void loadUser()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            SqlCommand cmd = new SqlCommand("select* from tb_KhachHang where UserName = '" + TK.ToString() + "'", sqlconect);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtbCharID.Text = reader.GetValue(1).ToString();
            }
            sqlconect.Close();
        }
        private void btunXoa_Click(object sender, EventArgs e)
        {
            txtbTen.Text = "";
            dtpicker.Text = "";
            cmbGT.Text = "";
            txtbSDT.Text = "";
            txtbDC.Text = "";
            txtbEmail.Text = "";
            txtbTen.Focus();
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvInfo.CurrentRow.Index;
            txtbTen.Text = dgvInfo.Rows[i].Cells[2].Value.ToString();
            dtpicker.Text = dgvInfo.Rows[i].Cells[3].Value.ToString();
            cmbGT.Text = dgvInfo.Rows[i].Cells[4].Value.ToString();
            txtbSDT.Text = dgvInfo.Rows[i].Cells[5].Value.ToString();
            txtbDC.Text = dgvInfo.Rows[i].Cells[6].Value.ToString();
            txtbEmail.Text = dgvInfo.Rows[i].Cells[7].Value.ToString();
        }

        private void txtbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btunSua_Click(object sender, EventArgs e)
        {
            if (CheckValuesInput() == false || txtbCharID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            }
            else
            {
                SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                sqlconect.Open();
                string insert = "update tb_KhachHang set HoVaTen = @Ten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDT = @SDT,DiaChi = @DiaChi, Email= @Email where CharID = @MaKH";
                SqlCommand cmd = new SqlCommand();
                cmd = sqlconect.CreateCommand();
                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@Ten", txtbTen.Text);
                cmd.Parameters.AddWithValue("NgaySinh", dtpicker.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cmbGT.Text);
                cmd.Parameters.AddWithValue("@SDT", txtbSDT.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtbDC.Text);
                cmd.Parameters.AddWithValue("@Email", txtbEmail.Text);
                cmd.Parameters.AddWithValue("@UserName", TK.ToString());
                cmd.Parameters.AddWithValue("@MaKH", txtbCharID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                load();
            }

        }
        private void btunKT_Click(object sender, EventArgs e)
        {
            if (CheckValuesInput() == false)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            }
            else
            {
                SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                sqlconect.Open();
                string insert = "insert into tb_KhachHang values(@Ten,@NgaySinh,@GioiTinh,@SDT,@DiaChi,@Email,@UserName)";
                string select = "select* from tb_KhachHang where UserName = '" + TK.ToString() + "'";
                SqlCommand cmd = new SqlCommand();
                cmd = sqlconect.CreateCommand();
                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@Ten", txtbTen.Text);
                cmd.Parameters.AddWithValue("NgaySinh", dtpicker.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cmbGT.Text);
                cmd.Parameters.AddWithValue("@SDT", txtbSDT.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtbDC.Text);
                cmd.Parameters.AddWithValue("@Email", txtbEmail.Text);
                cmd.Parameters.AddWithValue("@UserName", TK.ToString());
                cmd.Parameters.AddWithValue("@MaKH", txtbCharID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                conectsql sqlconect1 = new conectsql();
                dgvInfo.DataSource = sqlconect1.ExecuteQuery(select);
                loadUser();
                btunKT.Enabled = false;
            }
        }

    }
}
