using DevExpress.XtraEditors;
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

namespace AppQL_NhanSu
{
    public partial class fmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public fmBaoCao()
        {
            InitializeComponent();
        }

        private void fmBaoCao_Load(object sender, EventArgs e)
        {
           // SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
           // SqlCommand cmd = new SqlCommand();
           // cmd = conn.CreateCommand();
           ///// cmd.CommandText = "select *from Luong where MaNV = '"+comboBox1.Text+"'";
           // SqlDataAdapter data = new SqlDataAdapter(cmd);
           // DataTable dt = new DataTable();
           // data.Fill(dt);
           // //crysreport_luong rpt = new crysreport_luong();
           //// rpt.SetDataSource(dt);
           // //crystalReportViewer1.ReportSource = rpt;

        }

        private void fmBaoCao_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet15.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.qLNhanSuDataSet15.Luong);
            SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Luong ";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            crystalreport_luong rpt = new crystalreport_luong();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Luong where MaNV=N'" + comboBox1.Text + "'";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            crystalreport_luong rpt = new crystalreport_luong();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void btn_hientatca_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Luong ";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            crystalreport_luong rpt = new crystalreport_luong();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}