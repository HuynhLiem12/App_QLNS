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
using System.Configuration;
namespace AppQL_NhanSu
{
    public partial class fmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public object ConfigurationManager { get; private set; }
        public static string UserName = "";
        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void fmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
            DataTable tb = new DataTable();
            try
            {
               
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AuthoLogin";
                cmd.Parameters.AddWithValue("@UserName", txt_username.Text);
                cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                cmd.Connection = conn;
                UserName = txt_username.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fmMain frm = new fmMain();
                    frm.Show();
                    cmd.Dispose();
                    

                }
                else if (code == 1)
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fmMain frm = new fmMain();
                    frm.Show();
                    cmd.Dispose();
                    
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_pass.Text = "";
                    txt_username.Text = "";
                    txt_username.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_pass.Text = "";
                    txt_username.Text = "";
                    txt_username.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            //        reader.Read();
            //        MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        fmMain.quyen = "admin";
            //        this.Show();
            //        // this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng nhập vào hệ thống (Quyền nhanvien) !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        fmMain.quyen = "nhanvien";
            //        this.Show();
            //        //.Close();
            //    }

            //}

            //fmMain frm = new fmMain();
            //    //frm.Show();
            //    frm.ShowDialog();
            //    cmd.Dispose();
            //    reader.Close();
            //    reader.Dispose();
            
           
            

           
        }

        private void rdio_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_hienthimk.Checked)
            {
                txt_pass.PasswordChar = (char)0;
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void txt_username_MouseClick(object sender, MouseEventArgs e)
        {
            txt_username.SelectAll();
        }

        private void txt_pass_MouseClick(object sender, MouseEventArgs e)
        {
            txt_pass.SelectAll();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
    }
}