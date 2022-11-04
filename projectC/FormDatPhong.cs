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

namespace projectC
{
    public partial class FormDatPhong : Form
    {
        string TK = "", MK = "", QuyenUser = "";
        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void btunThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK,MK,QuyenUser);
            f.Show();
            this.Hide();
        }

        private void dgvDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDP.CurrentRow.Index;
            txtbTenCN.Text = dgvDP.Rows[i].Cells[7].Value.ToString();
            txtbGia.Text = dgvDP.Rows[i].Cells[4].Value.ToString();
            txtbLoaiP.Text = dgvDP.Rows[i].Cells[3].Value.ToString();
            txtbDiaChi.Text = dgvDP.Rows[i].Cells[2].Value.ToString();
            txtbSDT.Text = dgvDP.Rows[i].Cells[8].Value.ToString();
            cmbCharP.Text = dgvDP.Rows[i].Cells[0].Value.ToString();
            cmbUser.Text = dgvDP.Rows[i].Cells[9].Value.ToString();
            byte[] bytes = (byte[])dgvDP.Rows[i].Cells[5].Value;
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            loandAnhPhong.Image = img;
        }

        public FormDatPhong(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
            txtbTenCN.Enabled = false;
            txtbSDT.Enabled = false;
            txtbDiaChi.Enabled = false;
            txtbGia.Enabled = false;
            txtbLoaiP.Enabled = false;
            loandAnhPhong.Enabled = false;
            LoandDP();
        }

        private void btunDT_Click(object sender, EventArgs e)
        {
            string insert = "insert into tb_DatPhong values('" + cmbUser.Text + "','" + cmbCharID.Text + "','" + cmbCharP.Text + "')";
            conectsql sql = new conectsql();
            sql.ExecuteQuery(insert);
            string update = "update tb_Phong set TinhTrang = N'Đang Chờ Thuê' where CharP in (select CharP from tb_DatPhong where CharP = CharP)";
            sql.ExecuteQuery(update);
            MessageBox.Show("Đặt thuê phòng trọ thành công, chủ nhà sẽ sớm liên hệ với bạn", "Thông báo");
            FormDatPhong_Load(sender, e);
        }

        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            string sql = "Exec infoDP";
            conectsql connectTo = new conectsql();
            dgvDP.DataSource = connectTo.ExecuteQuery(sql);
        }
        void LoandDP()
        {
            SqlConnection sqlconect = new SqlConnection(@"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True");
            sqlconect.Open();
            var cmd = new SqlCommand("select* from tb_KhachHang where UserName = '"+TK.ToString()+"'",sqlconect);
            var er = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(er);
            er.Dispose();
            cmbCharID.DisplayMember = "CharID";
            cmbCharID.DataSource = dt;
            sqlconect.Close();
        }
    }
}
