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
    public partial class fmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        clsdatabase cls = new clsdatabase();
        public fmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string update = "update Users set MatKhau='" + txt_mkmoi.Text + "' where(TaiKhoan='" + txt_tk.Text + "' and MatKhau='" + txt_mkcu.Text + "')";
            string ten = txt_mkmoi.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên Tài Khoản");
            }
            else
            {
                if (txt_mkcu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập Mật Khẩu");
                }
                else
                {
                    if (txt_mkmoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Mật Khẩu Mới");
                    }
                    else
                    {
                        if (txt_nhaplai.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại Mật Khẩu");
                        }
                        else
                        {
                            if (txt_mkmoi.Text == txt_nhaplai.Text)
                            {
                                cls.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi Mật Khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại Mật Khẩu không đúng!");
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupControl1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        private void simpon3_Click(object sender, EventArgs e)
        {
               DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chk_hienthi1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radio_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radio_hienthi2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_hienthi2.Checked)
            {
                txt_mkmoi.PasswordChar = (char)0;
                txt_mkcu.PasswordChar = (char)0;
                txt_nhaplai.PasswordChar = (char)0;

            }
            else
            {
                txt_mkmoi.PasswordChar = '*';
                txt_mkcu.PasswordChar = '*';
                txt_nhaplai.PasswordChar = '*';

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}