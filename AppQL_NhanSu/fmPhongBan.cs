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
    public partial class fmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public fmPhongBan()
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
            cmd.CommandText = "select *from PhongBan";
            data.SelectCommand = cmd;
            tb.Clear();
            data.Fill(tb);
            dataGridView1.DataSource = tb;
        }
        private void fmPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet7.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter1.Fill(this.qLNhanSuDataSet7.PhongBan);

            conn.Open();
            Loaddulieu();
       

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            cbx_mapb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_tenpb.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into PhongBan values('" + cbx_mapb.Text + "',N'" + txt_tenpb.Text + "','" + txt_sdt.Text + "')";
                cmd.ExecuteNonQuery();
                Loaddulieu(); MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!!" +ex);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update PhongBan set MaPB='" + cbx_mapb.Text + "',TenPB=N'" + txt_tenpb.Text + "',SDT='" + txt_sdt.Text + "' where MaPB='" + cbx_mapb.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu(); MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉnh sửa thất bại!!" +ex);
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                 cmd = conn.CreateCommand();
                 cmd.CommandText = "delete from PhongBan where MaPB='" + cbx_mapb.Text + "'";
                 cmd.ExecuteNonQuery();
                 Loaddulieu(); MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!!" + ex);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát Không !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_them.PerformClick();

            }
        }
    }
}