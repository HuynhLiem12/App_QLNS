using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace AppQL_NhanSu
{
    public partial class In_nhanvien : DevExpress.XtraEditors.XtraForm
    {
        public In_nhanvien()
        {
            InitializeComponent();
        }

        private void In_nhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet17.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNhanSuDataSet17.NhanVien);
            SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from NhanVien ";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            CrystalReport_nhanvien rpt = new CrystalReport_nhanvien();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from NhanVien where MaNV ='"+comboBox1.Text+"' ";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            CrystalReport_nhanvien rpt = new CrystalReport_nhanvien();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void btn_tatca_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from NhanVien ";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            CrystalReport_nhanvien rpt = new CrystalReport_nhanvien();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}