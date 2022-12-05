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
using System.Diagnostics;
using System.Runtime.InteropServices;
using excel = Microsoft.Office.Interop.Excel;

namespace projectC
{
    public partial class FormQLND : Form
    {
        string TK = "", MK = "", QuyenUser = "";
        public FormQLND()
        {
            InitializeComponent();
        }
        bool CheckValuesInputUser()
        {
            if(txtbUser.Text.Trim() == "" || txtbPass.Text.Trim() == "" || cmbQuyenUs.Text == "")
                return false;
            else
                return true;
        }
        bool CheckValuesInputMember()
        {
            if(txtbTen.Text.Trim() == "" || txtbDiaChi.Text.Trim() == "" || cmbGT.Text.Trim() == "" || txtbEmail.Text.Trim() == "" || txtbSDT.Text.Trim() == "" || cmbUser.Text.Trim() == "" || dtpickerNS.Text.Trim() == "")
                return false;
            else
                return true;
        }
        private void btunKT_Click(object sender, EventArgs e)
        {
            if(rdThemUs.Checked == true)
            {
                if(CheckValuesInputUser() == false)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                }
                else
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
                        string insert = "insert into tb_User values('" + txtbUser.Text + "','" + txtbPass.Text + "',N'" + cmbQuyenUs.Text + "')";
                        conectsql sql = new conectsql();
                        sql.ExecuteQuery(insert);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        FormQLND_Load(sender, e);
                    }
                }
            }
            if (rdSuaUs.Checked == true)
            {
                if (CheckValuesInputUser() == false)
                {
                    MessageBox.Show("Bạn chưa nhập đủ hoặc nhập sai", "Thông báo");
                }
                else
                {
                    string update = "update tb_User set PhanLoai = N'" + cmbQuyenUs.Text + "' where UserName = '" + txtbUser.Text + "'";
                    conectsql sql = new conectsql();
                    sql.ExecuteQuery(update);
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    FormQLND_Load(sender, e);
                }
            }
        }
        private void rdXoaUs_CheckedChanged(object sender, EventArgs e)
        {
            if (rdXoaUs.Checked == true)
                txtbXoaUs.Enabled = true;
            else
                txtbXoaUs.Enabled = false;
        }

        private void btunXoa_Click(object sender, EventArgs e)
        {
            txtbUser.Text = "";
            txtbPass.Text = "";
            if(rdXoaUs.Checked == true)
            {
                if(txtbXoaUs.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã để xóa", "Thông báo");
                }
                else
                {
                    string delete = "delete tb_User where UserName = '" + txtbXoaUs.Text + "'";
                    conectsql sql = new conectsql();
                    sql.ExecuteQuery(delete);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    txtbXoaUs.Text = "";
                    txtbUser.Focus();
                    FormQLND_Load(sender, e);
                }
            }
        }

        private void btunKTKH_Click(object sender, EventArgs e)
        {
            if(rdThemKH.Checked == true)
            {
                if (CheckValuesInputMember() == false)
                {
                    MessageBox.Show("Chưa nhập dữ liệu hoặc chưa nhập đủ", "Thông báo");
                }
                else
                {
                    string insert = "insert into tb_KhachHang values(N'" + txtbTen.Text + "','" + dtpickerNS.Text + "',N'" + cmbGT.Text + "','" + txtbSDT.Text + "',N'" + txtbDiaChi.Text + "','" + txtbEmail.Text + "','" + cmbUser.Text + "')";
                    conectsql sql = new conectsql();
                    sql.ExecuteQuery(insert);
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                    FormQLND_Load(sender, e);
                }
            }
            if(rdSuaKH.Checked == true)
            {
                if (CheckValuesInputMember() == false || txtbCharID.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập giá dữ liệu hoặc chưa nhập đủ", "Thông báo");
                }
                else
                {
                    string update = "update tb_KhachHang set HoVaTen = N'" + txtbTen.Text + "',NgaySinh = '" + dtpickerNS.Text + "',GioiTinh = N'" + cmbGT.Text + "',SDT = '" + txtbSDT.Text + "',DiaChi = N'" + txtbDiaChi.Text + "',Email = '" + txtbEmail.Text + "',UserName = '" + cmbUser.Text + "' where CharID = '"+txtbCharID.Text+"'";
                    conectsql sql = new conectsql();
                    sql.ExecuteQuery(update);
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                    FormQLND_Load(sender, e);
                }
            }

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvUser.CurrentRow.Index;
            txtbUser.Text = dgvUser.Rows[i].Cells[0].Value.ToString();
            txtbPass.Text = dgvUser.Rows[i].Cells[1].Value.ToString();
            cmbQuyenUs.Text = dgvUser.Rows[i].Cells[2].Value.ToString();
            if (rdXoaUs.Checked == true)
                txtbXoaUs.Text = dgvUser.Rows[i].Cells[0].Value.ToString();
            else
                txtbXoaUs.Text = "";
        }

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void rdSuaUs_CheckedChanged(object sender, EventArgs e)
        {
            if(rdSuaUs.Checked == true)
            {
                txtbUser.Enabled = false;
                txtbPass.Enabled = false;
            }
            else
            {
                txtbUser.Enabled = true;
                txtbPass.Enabled = true;
            }
        }

        public FormQLND(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
            txtbCharID.Enabled = false;
            txtbXoaUs.Enabled = false;
            txtbXoaKH.Enabled = false;
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            txtbTen.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            dtpickerNS.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            cmbGT.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
            txtbSDT.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
            txtbDiaChi.Text = dgvKH.Rows[i].Cells[6].Value.ToString();
            txtbEmail.Text = dgvKH.Rows[i].Cells[7].Value.ToString();
            cmbUser.Text = dgvKH.Rows[i].Cells[8].Value.ToString();
            txtbCharID.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            if (rdXoaKH.Checked == true)
                txtbXoaKH.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            else
                txtbXoaKH.Text = "";

        }

        private void btunThoat1_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK,MK,QuyenUser);
            f.Show();
            this.Hide();
        }

        private void btunThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void rdXoaKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdXoaKH.Checked == true)
                txtbXoaKH.Enabled = true;
            else
                txtbXoaKH.Enabled = false;
        }

        private void btunXoaKH_Click(object sender, EventArgs e)
        {
            txtbTen.Text = "";
            cmbGT.Text = "";
            txtbSDT.Text = "";
            txtbDiaChi.Text = "";
            txtbEmail.Text = "";
            cmbUser.Text = "";
            txtbCharID.Text = "";
            if(rdXoaKH.Checked == true)
            {
                if(txtbXoaKH.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã khách hàng muốn xóa", "Thông báo");
                }
                else
                {
                    conectsql sql = new conectsql();
                    string delete = "delete from tb_KhachHang where CharID = '" + txtbXoaKH.Text + "' ";
                    sql.ExecuteQuery(delete);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    FormQLND_Load(sender, e);
                    txtbXoaKH.Text = "";
                    txtbTen.Focus();
                }
            }
        }

        private void btunExport_Click(object sender, EventArgs e)
        {
            if(dgvUser.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet ws = null;
                ws = wb.Sheets["Sheet1"];
                ws = wb.ActiveSheet;
                app.Visible = true;
                for (int i = 1; i < dgvUser.Columns.Count; i++)
                {
                    app.Cells[1, i] = dgvUser.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvUser.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvUser.Columns.Count; j++)
                    {
                        if (dgvUser.Rows[i].Cells[j].Value != null)
                        {
                            app.Cells[i + 2, j + 1] = dgvUser.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
        }

        private void btunEpKH_Click(object sender, EventArgs e)
        {
            if (dgvKH.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet ws = null;
                ws = wb.Sheets["Sheet1"];
                ws = wb.ActiveSheet;
                app.Visible = true;
                for (int i = 1; i < dgvKH.Columns.Count; i++)
                {
                    app.Cells[1, i] = dgvKH.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvKH.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKH.Columns.Count; j++)
                    {
                        if (dgvKH.Rows[i].Cells[j].Value != null)
                        {
                            app.Cells[i + 2, j + 1] = dgvKH.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
        }

        private void FormQLND_Load(object sender, EventArgs e)
        {
            string user = "select* from tb_User";
            string kh = "select* from tb_KhachHang";
            conectsql sql = new conectsql();
            dgvUser.DataSource = sql.ExecuteQuery(user);
            dgvKH.DataSource = sql.ExecuteQuery(kh);
            loandUser();
        }
        void loandUser()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            var cmd = new SqlCommand("select * from tb_User", sqlconect);
            var er = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(er);
            er.Dispose();
            cmbUser.DisplayMember = "UserName";
            cmbUser.DataSource = dt;
            sqlconect.Close();
        }
    }
}
