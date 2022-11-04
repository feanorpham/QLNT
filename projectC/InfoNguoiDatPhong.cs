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
    public partial class InfoNguoiDatPhong : Form
    {
        string TK = "", MK = "", QuyenUser = "";
        public InfoNguoiDatPhong()
        {
            InitializeComponent();
        }
        public InfoNguoiDatPhong(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
        }
        private void InfoNguoiDatPhong_Load(object sender, EventArgs e)
        {
            string sql = "exec infoNguoiDatPhong '" + TK.ToString() + "'";
            conectsql connectTo = new conectsql();
            dgvInfo.DataSource = connectTo.ExecuteQuery(sql);
        }

    }
}
