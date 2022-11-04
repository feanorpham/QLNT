using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectC
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btunLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            string check = "select* from tb_User where UserName = '" + txtbUser.Text + "' and PassWord = '" + txtbPass.Text + "'";
            SqlCommand cmd = new SqlCommand(check, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thàng công", "Thông báo");
                FormMain f = new FormMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User hoặc Password sai!! hãy nhập lại", "Thông báo");
            }
            
        }
        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                txtbPass.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                cbPass.Text = "Hiển thị mật khẩu";
            }
            else
            {
                txtbPass.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                cbPass.Text = "Hiển thị mật khẩu";
            }
        }
        private void btunThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }

        private void btunSignin_Click(object sender, EventArgs e)
        {
            FormSignIn f = new FormSignIn();
            f.Show();
            this.Hide();
        }
        private void test{}
    }
}
