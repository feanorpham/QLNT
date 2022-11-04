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
using System.Diagnostics;
using System.Runtime.InteropServices;
using excel = Microsoft.Office.Interop.Excel;

namespace projectC
{
    public partial class FormHopDong : Form
    {
        string TK = "", MK = "", QuyenUser = "";
        public FormHopDong()
        {
            InitializeComponent();
        }
        public FormHopDong(string TK, string MK, string QuyenUser)
        {
            InitializeComponent();
            this.TK = TK;
            this.MK = MK;
            this.QuyenUser = QuyenUser;
            check();
        }

        private void btunThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void btunThoat1_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain(TK, MK, QuyenUser);
            f.Show();
            this.Hide();
        }

        private void btunPrint_Click(object sender, EventArgs e)
        {
            if (dgvDS.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet ws = null;
                ws = wb.Sheets["Sheet1"];
                ws = wb.ActiveSheet;
                app.Visible = true;
                for (int i = 1; i < dgvDS.Columns.Count; i++)
                {
                    app.Cells[1, i] = dgvDS.Columns[i - 1].HeaderText;
                }
                for( int i=0;i < dgvDS.Rows.Count; i++)
                {
                    for(int j=0;j < dgvDS.Columns.Count; j++)
                    {
                        if (dgvDS.Rows[i].Cells[j].Value != null)
                        {
                            app.Cells[i + 2, j + 1] = dgvDS.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
        }
            private void FormHopDong_Load(object sender, EventArgs e)
        {
            string output = "exec HDCN '" + TK.ToString() + "'";
            string outputDS = "exec DSHD '" + TK.ToString() + "'";
            conectsql sql = new conectsql();
            dgvHDCN.DataSource = sql.ExecuteQuery(output);
            dgvDS.DataSource = sql.ExecuteQuery(outputDS);
        }
        void check()
        {
            if(QuyenUser == "Chủ Nhà")
            {
                tabControl1.TabPages.Remove(tabPage1);
            }
            else if(QuyenUser =="Người Thuê Nhà")
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
        }
    }
}
