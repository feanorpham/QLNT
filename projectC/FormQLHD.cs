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
    public partial class FormQLHD : Form
    {
        string TK = "", MK = "", QuyenUser = "";
        public FormQLHD()
        {
            InitializeComponent();
        }
        private void rdSuaHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSuaHD.Checked == true)
            {
                dtpickerNBD.Enabled = false;
                dtpickerNKT.Enabled = true;
                txtbMKH.Enabled = false;
                cmbCharP.Enabled = false;
            }
            else
            {
                dtpickerNBD.Enabled = true;
                dtpickerNKT.Enabled = true;
                txtbMKH.Enabled = true;
                cmbCharP.Enabled = true;
            }
        }

        public FormQLHD(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
            txtbXoa.Enabled = false;
            btunUpdate.Enabled = false;
            loand();
        }

        private void btunKT_Click(object sender, EventArgs e)
        {
            if(rdThemHD.Checked == true)
            {
                if(MessageBox.Show("Bạn muốn để ngày kết thúc là null không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                    sqlconect.Open();
                    string insert = "insert into HopDong values(@CharID,@CharP,@NgayBatDau,NULL,@UserName)";
                    SqlCommand cmd = new SqlCommand();
                    cmd = sqlconect.CreateCommand();
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@CharID", txtbMKH.Text);
                    cmd.Parameters.AddWithValue("@CharP", cmbCharP.Text);
                    cmd.Parameters.AddWithValue("@NgayBatDau", dtpickerNBD.Text);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", dtpickerNKT.Text);
                    cmd.Parameters.AddWithValue("@UserName", TK.ToString());
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1 = sqlconect.CreateCommand();
                    string updateP = "update tb_Phong set TinhTrang = N'Đã Thuê' where CharP in (select CharP from HopDong where CharP = '" + cmbCharP.Text + "')";
                    cmd1.CommandText = updateP;
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2 = sqlconect.CreateCommand();
                    string deleteDP = "delete tb_DatPhong where CharID = '" + txtbMKH.Text + "'";
                    cmd2.CommandText = deleteDP;
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    FormQLHD_Load(sender, e);
                    sqlconect.Close();
                }
                else
                {
                    if(dtpickerNBD.Value.Year > dtpickerNKT.Value.Year)
                    {
                        MessageBox.Show("Hãy nhập năm kết thúc lớn hơn năm bắt đấu", "Thông báo");
                    }
                    else
                    {
                        SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                        sqlconect.Open();
                        string insert = "insert into HopDong values(@CharID,@CharP,@NgayBatDau,@NgayKetThuc,@UserName)";
                        SqlCommand cmd = new SqlCommand();
                        cmd = sqlconect.CreateCommand();
                        cmd.CommandText = insert;
                        cmd.Parameters.AddWithValue("@CharID", txtbMKH.Text);
                        cmd.Parameters.AddWithValue("@CharP", cmbCharP.Text);
                        cmd.Parameters.AddWithValue("@NgayBatDau", dtpickerNBD.Text);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", dtpickerNKT.Text);
                        cmd.Parameters.AddWithValue("@UserName", TK.ToString());
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1 = sqlconect.CreateCommand();
                        string updateP = "update tb_Phong set TinhTrang = N'Đã Thuê' where CharP in (select CharP from HopDong where CharP = '" + cmbCharP.Text + "')";
                        cmd1.CommandText = updateP;
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2 = sqlconect.CreateCommand();
                        string deleteDP = "delete tb_DatPhong where CharID = '" + txtbMKH.Text + "'";
                        cmd2.CommandText = deleteDP;
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        FormQLHD_Load(sender, e);
                        sqlconect.Close();
                    }
                    
                }

            }
            if(rdSuaHD.Checked == true)
            {
                SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
                sqlconect.Open();
                string update = "update HopDong set NgayKetThuc = '" + dtpickerNKT.Text + "' where CharHD = CharHD";
                SqlCommand cmd = new SqlCommand();
                cmd = sqlconect.CreateCommand();
                cmd.CommandText = update;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công","Thông báo",MessageBoxButtons.OK);
                FormQLHD_Load(sender, e);
                sqlconect.Close();
            }
        }

        private void FormQLHD_Load(object sender, EventArgs e)
        {
            string output = "exec QLHD '" + TK.ToString() + "'";
            conectsql sql = new conectsql();
            dgvQLHD.DataSource = sql.ExecuteQuery(output);
        }

        private void rdThemHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThemHD.Checked == true)
                loandCharID();
            else
                loand();
        }

        private void btunThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void rdXoaHD_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            i = dgvQLHD.CurrentRow.Index;
            if (rdXoaHD.Checked == true)
            {
                txtbXoa.Text = dgvQLHD.Rows[i].Cells[0].Value.ToString();
                txtbXoa.Enabled = true;
                txtbMKH.Enabled = false;
                cmbCharP.Enabled = false;
            }
            else
            {
                txtbXoa.Enabled = false;
                txtbXoa.Text = "";
                txtbMKH.Enabled = true;
                cmbCharP.Enabled = true;
            }
            
        }

        private void btunXoa_Click(object sender, EventArgs e)
        {
            txtbMKH.Text = "";
            cmbCharP.Text = "";
            if (rdXoaHD.Checked == true)
            {
                string delete = "delete HopDong where CharHD = '" + txtbXoa.Text + "'";
                string updateP = "update tb_Phong set TinhTrang = N'Chưa Thuê' where CharP not in (select CharP from HopDong where CharP = CharP)";
                conectsql sql = new conectsql();
                sql.ExecuteQuery(delete);
                sql.ExecuteQuery(updateP);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                txtbXoa.Text = "";
                FormQLHD_Load(sender, e);
            }
        }

        private void dgvQLHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvQLHD.CurrentRow.Index;
            txtbMKH.Text = dgvQLHD.Rows[i].Cells[1].Value.ToString();
            cmbCharP.Text = dgvQLHD.Rows[i].Cells[3].Value.ToString();
        }

        private void dgvQLHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
                e.Value = new string('*', e.Value.ToString().Length);
        }

        void loand()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            var cmd = new SqlCommand("exec outputP '" + TK.ToString() + "'", sqlconect);
            var er = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(er);
            er.Dispose();
            if (dt.Rows.Count == 0)
            {
                cmbCharP.Text = "";
                txtbMKH.Text = "";
            }
            else
            {
                cmbCharP.DisplayMember = "CharP";
                cmbCharP.DataSource = dt;
                txtbMKH.Text = dt.Rows[0][2].ToString();
            }
            sqlconect.Close();
        }
        void loandCharID()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            var cmd = new SqlCommand("select* from tb_DatPhong where UserName = '" + TK.ToString() + "'", sqlconect);
            var er = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(er);
            er.Dispose();
            if (dt.Rows.Count == 0)
            {
                cmbCharP.Text = "";
                txtbMKH.Text = "";
            }
            else
            {
                cmbCharP.DisplayMember = "charP";
                cmbCharP.DataSource = dt;
                txtbMKH.Text = dt.Rows[0][1].ToString();
            }
            sqlconect.Close();
        }
    }
}
