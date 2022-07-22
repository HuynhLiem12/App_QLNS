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
    public partial class fmChamNgayCong : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter data = new SqlDataAdapter();
        DataTable tb = new DataTable();
        public void Loaddulieu()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from ChamCongNV";
            data.SelectCommand = cmd;
            tb.Clear();
            data.Fill(tb);
            dataGridView1.DataSource = tb;
        }
        public fmChamNgayCong()
        {
            InitializeComponent();
        }

        private void fmChamNgayCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet10.ChamCongNV' table. You can move, or remove it, as needed.
            this.chamCongNVTableAdapter1.Fill(this.qLNhanSuDataSet10.ChamCongNV);
            conn.Open();
            Loaddulieu();
            try
            {

                cbx_manv.DisplayMember = "MaNV";//Word là tên trường bạn muốn hiển thị trong combobox
                
                cbx_manv.DataSource = tb;
                cbx_manv.Items.Clear();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            cbx_manv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_songaycong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_ngaynghi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_ghichu.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

        }

        private void txt_songaynghi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int sngaynghi;
                sngaynghi = int.Parse(txt_ngaynghi.Text);
                
                int tngaycong;
               

                int ngaycong = Convert.ToInt32(txt_songaycong.Text);
                

                tngaycong = ngaycong - sngaynghi;
                txt_tongngcong.Text = tngaycong.ToString();

            }
        }

        private void txt_ghichu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_them.PerformClick();

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into ChamCongNV(MaNV,SoNgayCong,SoNgayNghi,GhiChu,TongNgayCong) values('" + cbx_manv.Text + "','" + txt_songaycong.Text + "','" + txt_ngaynghi.Text + "','" + txt_ghichu.Text + "','" + txt_tongngcong.Text + "')";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Thêm thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm đã bị lỗi!" +ex,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void btn_xóa_Click(object sender, EventArgs e)

        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete ChamCongNV where MaNV='" + cbx_manv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lỗi!" +ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void txt_songaycong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void songaycongmacdinh()
        {
            int songaycong;
            songaycong = int.Parse(txt_songaycong.Text);
            
            songaycong = 30 - 4;
        }
        private void txt_songaycong_TextChanged(object sender, EventArgs e)
        {

            songaycongmacdinh();

        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update ChamCongNV set MaNV='" + cbx_manv.Text + "',SoNgayCong='" + txt_songaycong.Text + "',SoNgayNghi='" + txt_ngaynghi.Text + "',GhiChu='" + txt_ghichu.Text + "',TongNgayCong='" + txt_tongngcong.Text + "' where MaNV ='" + cbx_manv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Chỉnh sửa thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉnh sửa thất bại!!"+ex);
            }
           
        }

        private void txt_songaynghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_tongngaycong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}