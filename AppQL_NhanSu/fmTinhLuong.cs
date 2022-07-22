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
    public partial class fmTinhLuong : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter data = new SqlDataAdapter();
        DataTable tb = new DataTable();
        
      
        public void Loaddulieu()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select nv.MaNV , nv.TenNV,pb.TenPB, nv.HeSoLuong, cv.PCCV,cc.SoNgayCong,cc.SoNgayNghi,cc.TongNgayCong, l.Luong, l.TongLuong,l.GhiChu from NhanVien nv,ChucVu cv,ChamCongNV cc,Luong l, PhongBan pb where nv.MaNV = l.MaNV and  nv.MaCV = cv.MaCV and nv.MaNV = cc.MaNV  and nv.MaPB = pb.MaPB  ";
            data.SelectCommand = cmd;
            tb.Clear();
            data.Fill(tb);
            dataGridView1.DataSource = tb;
        }
        public fmTinhLuong()
        {
            InitializeComponent();
           
          //  Loaddulieu();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double flTien = double.Parse(txt_tongluongnhan.Text.Replace(",", ""));
                txt_tongluongnhan.Text = flTien.ToString("0,00.##");
                txt_tongluongnhan.Select(txt_tongluongnhan.TextLength, 0);
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //conect
        public void connect()
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }
        //disconect
        public void disconect()
        {
            conn.Close();
        }

        private void txt_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader a = null;
            cmd = conn.CreateCommand();
            cmd.CommandText = "select  nv.TenNV,nv.MaPB,pb.TenPB, nv.HeSoLuong, cv.PCCV,cc.SoNgayCong,cc.SoNgayNghi,cc.TongNgayCong from NhanVien nv,ChucVu cv,ChamCongNV cc, PhongBan pb where nv.MaNV= '" + cbx_manv.Text + "'  and nv.MaCV = cv.MaCV and nv.MaNV = cc.MaNV  and nv.MaPB = pb.MaPB ";
            try
            {

                connect();
                a = cmd.ExecuteReader();
                cmd.Dispose();

                while (a.Read())
                {
                    txt_tennv.Text = a["TenNV"].ToString();
                    cbx_mapb.Text = a["MaPB"].ToString();
                    txt_pb.Text = a["TenPB"].ToString();
                    txt_hsl.Text = a["HeSoluong"].ToString();
                    txt_pccv.Text = a["PCCV"].ToString();
                    txt_songaycong.Text = a["SoNgayCong"].ToString();
                    txt_songaynghi.Text = a["SoNgayNghi"].ToString();
                    txt_ngaycongthuc.Text = a["TongNgayCong"].ToString();
                    //cbx_ghichu.Text = a["GhiChu"].ToString();


                    //txt_tongluongnhan.Text = a["TongLuong"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra!" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (a != null)
                {
                    conn.Close();
                }
                //if (conn!=null)
                // {
                //     conn.Close();
                //}
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dataGridView1.CurrentRow.Index;
            cbx_manv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_tennv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
           // cbx_mapb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_pb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_hsl.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_pccv.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_songaycong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_songaynghi.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_ngaycongthuc.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt_luong.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            txt_tongluongnhan.Text= dataGridView1.Rows[i].Cells[9].Value.ToString();
            cbx_ghichu.Text= dataGridView1.Rows[i].Cells[10].Value.ToString();
        }

        private void fmTinhLuong_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            Loaddulieu();
            try
            {
                cbx_manv.DisplayMember = "MaNV";//MaNV là tên trường muốn hiển thị trong combobox
                cbx_manv.ValueMember = "TenNV";
                cbx_manv.DataSource = tb;
                cbx_manv.Items.Clear();
            }
            catch(Exception)
            {
                return;
            }
          
             
        
            
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            int lcb = Convert.ToInt32(txt_luong.Text);
            int pccv = Convert.ToInt32(txt_pccv.Text);
            int ngaycong = Convert.ToInt32(txt_ngaycongthuc.Text);
           
            float hsl1;
            hsl1 = float.Parse(txt_hsl.Text);

            float luong = ((lcb * hsl1) / 26) * ngaycong + pccv;
            //bhyt and bhxh
            float Tinhbhyt = (luong * 5) / 100;
            float Tinhbhxh = (luong * 1) / 100;

            //lương lãnh
            float luonglanh = luong - (Tinhbhyt - Tinhbhxh);
            txt_tongluongnhan.Text = luonglanh.ToString();
        }

        private void txt_songaynghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_hsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_pccv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_songaycong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_tongluongnhan_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_tongluongnhan.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txt_tongluongnhan.Text);
                txt_tongluongnhan.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void txt_songaynghi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_luong.PerformClick();

            }
        }

        private void txt_luong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_luong.PerformClick();

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try{
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into Luong values('" + cbx_manv.Text + "','" + cbx_mapb.Text + "','" + txt_luong.Text + "',N'" + cbx_ghichu + "','" + txt_tongluongnhan.Text + "')";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công"+ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void cbx_manv_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "update Luong set MaNV ='" + cbx_manv.Text + "',MaPB='" + cbx_mapb.Text + "',Luong='" + txt_luong.Text + "',Ghichu=N'" + cbx_ghichu.Text + "',TongLuong='" + txt_tongluongnhan.Text + "'where MaNV='" + cbx_manv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from Luong where MaNV = '" + cbx_manv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_in_Click(object sender, EventArgs e)
        {

            fmBaoCao bc = new fmBaoCao();

            bc.Show();
        }
    }
}