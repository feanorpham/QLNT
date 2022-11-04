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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }
        private void btunDK_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            string check = "select* from tb_User where UserName = '" + txtbUser.Text + "'";
            SqlCommand cmd = new SqlCommand(check, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("User đã tồn tại", "Thông báo");
                sqlConnection.Close();

            }
            else
            {
                sqlConnection.Open();
                cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "insert into tb_User values('" + txtbUser.Text + "','" + txtbPass.Text + "',N'" + cmbPL.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công","Thông báo",MessageBoxButtons.OK);
                sqlConnection.Close();
                FormLogin f = new FormLogin();
                f.Show();
                this.Hide();
            }
        }
        void loandPL()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlConnection.Open();
            var cmd = new SqlCommand("select* from tb_User", sqlConnection);
            var dr = cmd.ExecuteReader();
            var tabale = new DataTable();
            tabale.Load(dr);
            dr.Dispose();
            cmbPL.DisplayMember = "PhanLoai";
            cmbPL.DataSource = tabale;
            sqlConnection.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtbPass.UseSystemPasswordChar = true;
            else
                txtbPass.UseSystemPasswordChar = false;
        }

        private void btunThoat_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }
    }
}
