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
    public partial class fmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public fmChucVu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter data = new SqlDataAdapter();
        DataTable tb = new DataTable();
        public void Loaddulieu()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from ChucVu";
            data.SelectCommand = cmd;
            tb.Clear();
            data.Fill(tb);
            dataGridView1.DataSource = tb;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet6.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter1.Fill(this.qLNhanSuDataSet6.ChucVu);

            conn.Open();
            Loaddulieu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            cbx_macv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_tencv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbx_pccv.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into ChucVu values('" + cbx_macv.Text + "',N'" + txt_tencv.Text + "','" + cbx_pccv.Text + "')";
                cmd.ExecuteNonQuery();
                Loaddulieu(); MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!!"+ex);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update ChucVu set MaCV='" + cbx_macv.Text + "',TenCV=N'" + txt_tencv.Text + "',PCCV='" + cbx_pccv.Text + "' where MaCV='" + cbx_macv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu(); MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉnh sửa thất bại!!"+ex);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from ChucVu where MaCV='" + cbx_macv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu(); MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_tencv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_them.PerformClick();

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát Không !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                this.Close();
        }
    }
}