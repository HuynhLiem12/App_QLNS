using DevExpress.XtraBars;
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
    public partial class fmMain : DevExpress.XtraEditors.XtraForm
    {

      

        public fmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmDoiMatKhau")
                {
                    f.Activate();
                    return;
                }
            fmDoiMatKhau mk = new fmDoiMatKhau();
            mk.MdiParent = this;
            mk.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmNhanVien")
                {
                    f.Activate();
                    return;
                }
            fmNhanVien nv = new fmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmChucVu")
                {
                    f.Activate();
                    return;
                }
            fmChucVu cv = new fmChucVu();
            cv.MdiParent = this;
            cv.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach(Form f in this.MdiChildren)
                if (f.Name == "fmPhongBan")
            {
                f.Activate();
                return;
            }
            fmPhongBan pb = new fmPhongBan();
            pb.MdiParent = this;
            pb.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmTinhLuong")
                {
                    f.Activate();
                    return;
                }
            fmTinhLuong tl = new fmTinhLuong();
            tl.MdiParent = this;
            tl.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmTroGiup")
                {
                    f.Activate();
                    return;
                }
            fmTroGiup tg = new fmTroGiup();
            tg.MdiParent = this;
            tg.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmGioiThieu")
                {
                    f.Activate();
                    return;
                }
            fmGioiThieu gt = new fmGioiThieu();
            gt.MdiParent = this;
            gt.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmTimKiem")
                {
                    f.Activate();
                    return;
                }
            fmTimKiem tk = new fmTimKiem();
            tk.MdiParent = this;
            tk.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmBaoCao")
                {
                    f.Activate();
                    return;
                }
            fmBaoCao bc = new fmBaoCao();
            bc.MdiParent = this;
            bc.Show();
        }

     
        private void register_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmTaoTaiKhoan")
                {
                    f.Activate();
                    return;
                }
            fmTaoTaiKhoan taoTaiKhoan = new fmTaoTaiKhoan();
            taoTaiKhoan.MdiParent = this;
            taoTaiKhoan.Show();
            register.Enabled = false;
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "fmChamNgayCong")
                {
                    f.Activate();
                    return;
                }
            fmChamNgayCong chamcong = new fmChamNgayCong();
            chamcong.MdiParent = this;
            chamcong.Show();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=HUYNHLIEM\SQLEXPRESS;Initial Catalog=QLNhanSu;Persist Security Info=True;User ID=sa;Password=Tl281012@");
        DataTable tb = new DataTable();
        
        private void fmMain_Load(object sender, EventArgs e)
        {
            
            //register.Enabled = false;
            //chamcong.Enabled = false;
            //hosonv.Enabled = false;
            //chucvu.Enabled = false;
            //phongban.Enabled = false;
            //doimatkhau.Enabled = false;
            //luong.Enabled = false;
            //chamcong.Enabled = false;
            //timkiem.Enabled = false;
            //baocao.Enabled = false;
            //baocaonv.Enabled = false;
            if ( fmDangNhap.UserName=="admin")
                {
                    register.Enabled = true;
                    chamcong.Enabled = true;
                    hosonv.Enabled = true;
                    chucvu.Enabled = true;
                    phongban.Enabled = true;
                    doimatkhau.Enabled = true;
                    luong.Enabled = true;
                    chamcong.Enabled = true;
                    timkiem.Enabled = true;
                    baocao.Enabled = true;
                    baocaonv.Enabled = true;
                }
            else
            {
                register.Enabled = false;
                chamcong.Enabled = true;
                hosonv.Enabled = true;
                chucvu.Enabled = true;
                phongban.Enabled = true;
                doimatkhau.Enabled = true;
                luong.Enabled = true;
                chamcong.Enabled = true;
                timkiem.Enabled = true;
                baocao.Enabled = true;
                baocaonv.Enabled = true;
            }
            
            


        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            In_nhanvien nv = new In_nhanvien();
            nv.Show();
        }

        private void dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn Đăng Xuất khỏi hệ thống ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}