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

namespace AppQL_NhanSu
{
    public partial class fmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        clsdatabase cls = new clsdatabase();
        public fmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void fmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet16.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.qLNhanSuDataSet16.Users);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                
                string insert = "insert into Users values('" + txt_username.Text + "','" + txt_pass.Text + "','" + comboBox1.Text + "')";
                if (cls.kttrungkhoa(txt_username.Text, "select * from Users") == true)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn có thể thử tên khác");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                   
                    //this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           txt_username.Text = "";
           txt_pass.Text = "";
            comboBox1.Text = "";
           
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.qLNhanSuDataSet16.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}