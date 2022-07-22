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

namespace AppQL_NhanSu
{
    public partial class fmTimKiem : DevExpress.XtraEditors.XtraForm
    {
        clsdatabase cls = new clsdatabase();
        public fmTimKiem()
        {
            InitializeComponent();

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if ((txt_timkiem.Text == "") || (txt_timkiem.Text == "Nhập vào từ khóa tìm kiếm"))
            //    {
            //        MessageBox.Show("bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    }
            //    else
            //    {
            //        if (i == 1)
            //        {
            //            cls.loaddatagridview(dataGridView1, "select * from NhanVien where MaNV=N'" + txt_timkiem.Text + "'");
            //        }
            //        if (i == 2)
            //        {
            //            cls.loaddatagridview(dataGridView1, "select * from NhanVien where TenNV=N'" + txt_timkiem.Text + "'");
            //        }

            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Tìm kiếm sai");
            //}



            try
            {

                if ((txt_timkiem.Text == "") || (txt_timkiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    cls.loaddatagridview(dataGridView1, "select * from NhanVien");
                    MessageBox.Show("bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (i == 1)
                    {
                        cls.loatextbox(txt_timkiem, "select * from NhanVien where MaNV like N'%" + txt_timkiem.Text + "%'", 2);
                        cls.loaddatagridview(dataGridView1, "select * from NhanVien where MaNV like N'" + txt_timkiem.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(txt_timkiem, "select * from NhanVien where MaNV like N'%" + txt_timkiem.Text + "%'", 3);
                        cls.loaddatagridview(dataGridView1, "select * from NhanVien where TenNV like N'%" + txt_timkiem.Text + "%'");
                    }

                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

            //try
            //{

            //    if ((txt_timkiem.Text == "") || (txt_timkiem.Text == "Nhập vào từ khóa tìm kiếm"))
            //    {
            //        cls.loaddatagridview(dataGridView1, "select * from NhanVien");
            //    }
            //    else
            //    {

            //        if (i == 1)
            //        {
            //            cls.loatextbox(txt_timkiem, "select * from NhanVien where MaNV like N'%" + txt_timkiem.Text + "%'", 2);
            //            cls.loaddatagridview(dataGridView1, "select * from NhanVien where MaNV like N'" + txt_timkiem.Text + "%'");
            //        }
            //        if (i == 2)
            //        {
            //            cls.loatextbox(txt_timkiem, "select * from NhanVien where MaNV like N'%" + txt_timkiem.Text + "%'", 3);
            //            cls.loaddatagridview(dataGridView1, "select * from NhanVien where TenNV like N'%" + txt_timkiem.Text + "%'");
            //        }

            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("tìm kiếm sai");
            //}
        }
        int i = 0;
        private void rdio_manv_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;

        }

        private void rdio_tennv_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void fmTimKiem_Load(object sender, EventArgs e)
        {
            rdio_manv.Checked = true;
            cls.loaddatagridview(dataGridView1, "select * from NhanVien");
        }

        private void txt_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_tim.PerformClick();

            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
            try
            {

                if ((txt_timkiem.Text == "") || (txt_timkiem.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    cls.loaddatagridview(dataGridView1, "select * from NhanVien");
                }
                else
                {

                    if (i == 1)
                    {
                        cls.loatextbox(txt_timkiem, "select * from NhanVien where MaNV like N'%" + txt_timkiem.Text + "%'", 2);
                        cls.loaddatagridview(dataGridView1, "select * from NhanVien where MaNV like N'" + txt_timkiem.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(txt_timkiem, "select * from NhanVien where MaNV like N'%" + txt_timkiem.Text + "%'", 3);
                        cls.loaddatagridview(dataGridView1, "select * from NhanVien where TenNV like N'%" + txt_timkiem.Text + "%'");
                    }

                }
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }
    }
}