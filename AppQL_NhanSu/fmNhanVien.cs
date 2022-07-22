using DevExpress.XtraEditors;
using System;
using System.IO;
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
    public partial class fmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public fmNhanVien()
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
            cmd.CommandText = "select *from NhanVien";
            data.SelectCommand = cmd;
            tb.Clear();
            data.Fill(tb);
            dataGridView1.DataSource = tb;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        //kiểm tra thông tin
        private bool KiemTraThongTin()
        {
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Vui lòng điền họ và tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennv.Focus();
                return false;
            }
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return false;
            }
            if (txt_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return false;
            }
            if (cbx_gioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return false;
            }
            if (dtp_ngaysinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ngày sinh của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_ngaysinh.Focus();
                return false;
            }
            
            if (dtp_ngayvaolam.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ngày vào làm của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_ngayvaolam.Focus();
                return false;
            }
            return true;
        }
        private void fmNhanVien_Load(object sender, EventArgs e)
        {
          

            conn.Open();
            Loaddulieu();
            try
            {
                Loaddulieu();

                cbx_manv.DisplayMember = "MaNV";//Word là tên trường bạn muốn hiển thị trong combobox
                cbx_manv.ValueMember = "TenNV";
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
            cbx_cv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbx_phongban.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_tennv.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dtp_ngaysinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            cbx_gioitinh.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txt_urlanh.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            //byte[] imgdata = (byte[])dataGridView1.CurrentRow.Cells[8].Value;
            //MemoryStream ms = new MemoryStream(imgdata);
            //pcbx_anhnv.Image = Image.FromStream(ms);
            cbx_hsl.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            dtp_ngayvaolam.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                KiemTraThongTin();
                cmd = conn.CreateCommand();
               
                cmd.Parameters.AddWithValue("@urlanh", convertImageTobytes());

                cmd.CommandText = "insert into NhanVien values('" + cbx_manv.Text + "','" + cbx_cv.Text + "','" + cbx_phongban.Text + "',N'" + txt_tennv.Text + "','" + dtp_ngaysinh.Text + "',N'" + txt_diachi.Text + "',N'" + cbx_gioitinh.Text + "','" + txt_sdt.Text + "',@urlanh,'" + dtp_ngayvaolam.Text + "','" + cbx_hsl.Text + "')";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                conn.Close();
                txt_urlanh.Text = cbx_manv.Text = "";
                MessageBox.Show("Thêm nhân viên thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        //chuyen doi du lieu
        private byte[] convertImageTobytes()
        {
            FileStream fs;
            fs = new FileStream(txt_urlanh.Text, FileMode.Open, FileAccess.Read);
            //a byte array to read the image

            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;

        }



        Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void btn_themanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pcbx_anhnv.ImageLocation = openFileDialog1.FileName;
                txt_urlanh.Text = openFileDialog1.FileName;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update NhanVien set MaNV='" + cbx_manv.Text + "',MaCV='" + cbx_cv.Text + "',MaPB='" + cbx_phongban.Text + "',TenNV=N'" + txt_tennv.Text + "',NgaySinh='" + dtp_ngaysinh.Text + "',DiaChi=N'" + txt_diachi.Text + "',GioiTinh=N'" + cbx_gioitinh.Text + "',SDT='" + txt_sdt.Text + "',UrlAnh='" + txt_urlanh.Text + "',HeSoLuong='" + cbx_hsl.Text + "',NgayVaoLam='" + dtp_ngayvaolam.Text + "' where MaNV='" + cbx_manv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
                cmd.CommandText = "delete from NhanVien where MaNV='" + cbx_manv.Text + "'";
                cmd.ExecuteNonQuery();
                Loaddulieu();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa không thành công!!"+ex,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning );
            }
           
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát Không !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            In_nhanvien nv = new In_nhanvien();
            nv.Show();
        }

        private void pcbx_anhnv_Click(object sender, EventArgs e)
        {
           
        }

        //public Image ConvertByteArrayToImage(byte[]data)
        //{
        //    using (FileStream fs = new FileStream(txt_urlanh.Text, FileMode.Open, FileAccess.Read))
        //    {
        //        return Image.FromStream(fs);
        //    }
        //}
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

                MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[8].Value);
                pcbx_anhnv.Image = Image.FromStream(ms);
            }
            catch
            {
                pcbx_anhnv.Image = null;

            }

        }


        private void pcbx_anhnv_LocationChanged(object sender, EventArgs e)
        {
            //pcbx_anhnv.Image = Image.FromFile(Filename);
            //pcbx_anhnv.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dt = dataGridView1.DataSource as DataTable;
            //if (dt != null)
            //{
            //    DataRow row = dt.Rows[e.RowIndex];
            //    pcbx_anhnv.Image = ConvertByteArrayToImage((byte[])row["UrlAnh"]);
            //}
        }
    }
}