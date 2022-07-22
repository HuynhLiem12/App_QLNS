namespace AppQL_NhanSu
{
    partial class fmChamNgayCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tongngcong = new System.Windows.Forms.TextBox();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xóa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_chinhsua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chamCongNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhanSuDataSet9 = new AppQL_NhanSu.QLNhanSuDataSet9();
            this.cbx_manv = new System.Windows.Forms.ComboBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_ngaynghi = new System.Windows.Forms.TextBox();
            this.txt_songaycong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chamCongNVTableAdapter = new AppQL_NhanSu.QLNhanSuDataSet9TableAdapters.ChamCongNVTableAdapter();
            this.qLNhanSuDataSet10 = new AppQL_NhanSu.QLNhanSuDataSet10();
            this.chamCongNVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chamCongNVTableAdapter1 = new AppQL_NhanSu.QLNhanSuDataSet10TableAdapters.ChamCongNVTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongNgayCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongNVBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(376, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số ngày công";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txt_tongngcong);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_xóa);
            this.groupBox1.Controls.Add(this.btn_chinhsua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cbx_manv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_ngaynghi);
            this.groupBox1.Controls.Add(this.txt_songaycong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 513);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chấm công";
            // 
            // txt_tongngcong
            // 
            this.txt_tongngcong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tongngcong.Enabled = false;
            this.txt_tongngcong.Location = new System.Drawing.Point(530, 129);
            this.txt_tongngcong.Name = "txt_tongngcong";
            this.txt_tongngcong.Size = new System.Drawing.Size(64, 30);
            this.txt_tongngcong.TabIndex = 8;
            this.txt_tongngcong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tongngcong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tongngaycong_KeyPress);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ImageOptions.Image = global::AppQL_NhanSu.Properties.Resources.cancel_32x321;
            this.btn_thoat.Location = new System.Drawing.Point(584, 210);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(150, 51);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xóa
            // 
            this.btn_xóa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xóa.Appearance.Options.UseFont = true;
            this.btn_xóa.ImageOptions.Image = global::AppQL_NhanSu.Properties.Resources.removeitem_32x32;
            this.btn_xóa.Location = new System.Drawing.Point(394, 210);
            this.btn_xóa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(150, 51);
            this.btn_xóa.TabIndex = 6;
            this.btn_xóa.Text = "Xóa";
            this.btn_xóa.Click += new System.EventHandler(this.btn_xóa_Click);
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chinhsua.Appearance.Options.UseFont = true;
            this.btn_chinhsua.ImageOptions.Image = global::AppQL_NhanSu.Properties.Resources.modifytablestyle_32x32;
            this.btn_chinhsua.Location = new System.Drawing.Point(211, 210);
            this.btn_chinhsua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(150, 51);
            this.btn_chinhsua.TabIndex = 5;
            this.btn_chinhsua.Text = "Chỉnh sửa";
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ImageOptions.Image = global::AppQL_NhanSu.Properties.Resources.additem_32x32;
            this.btn_them.Location = new System.Drawing.Point(30, 210);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 51);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.soNgayCongDataGridViewTextBoxColumn,
            this.soNgayNghiDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.tongNgayCongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chamCongNVBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(68, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(629, 198);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chamCongNVBindingSource
            // 
            this.chamCongNVBindingSource.DataMember = "ChamCongNV";
            this.chamCongNVBindingSource.DataSource = this.qLNhanSuDataSet9;
            // 
            // qLNhanSuDataSet9
            // 
            this.qLNhanSuDataSet9.DataSetName = "QLNhanSuDataSet9";
            this.qLNhanSuDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx_manv
            // 
            this.cbx_manv.FormattingEnabled = true;
            this.cbx_manv.Location = new System.Drawing.Point(221, 46);
            this.cbx_manv.Name = "cbx_manv";
            this.cbx_manv.Size = new System.Drawing.Size(129, 30);
            this.cbx_manv.TabIndex = 0;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ghichu.Location = new System.Drawing.Point(147, 95);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(203, 64);
            this.txt_ghichu.TabIndex = 3;
            this.txt_ghichu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ghichu_KeyDown);
            // 
            // txt_ngaynghi
            // 
            this.txt_ngaynghi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ngaynghi.Location = new System.Drawing.Point(515, 85);
            this.txt_ngaynghi.Name = "txt_ngaynghi";
            this.txt_ngaynghi.Size = new System.Drawing.Size(48, 30);
            this.txt_ngaynghi.TabIndex = 2;
            this.txt_ngaynghi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ngaynghi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_songaynghi_KeyDown);
            this.txt_ngaynghi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_songaynghi_KeyPress);
            // 
            // txt_songaycong
            // 
            this.txt_songaycong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_songaycong.Enabled = false;
            this.txt_songaycong.Location = new System.Drawing.Point(515, 36);
            this.txt_songaycong.Name = "txt_songaycong";
            this.txt_songaycong.Size = new System.Drawing.Size(48, 30);
            this.txt_songaycong.TabIndex = 1;
            this.txt_songaycong.Text = "26";
            this.txt_songaycong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_songaycong.TextChanged += new System.EventHandler(this.txt_songaycong_TextChanged);
            this.txt_songaycong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_songaycong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(376, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số ngày nghĩ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(376, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng ngày công";
            // 
            // chamCongNVTableAdapter
            // 
            this.chamCongNVTableAdapter.ClearBeforeFill = true;
            // 
            // qLNhanSuDataSet10
            // 
            this.qLNhanSuDataSet10.DataSetName = "QLNhanSuDataSet10";
            this.qLNhanSuDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamCongNVBindingSource1
            // 
            this.chamCongNVBindingSource1.DataMember = "ChamCongNV";
            this.chamCongNVBindingSource1.DataSource = this.qLNhanSuDataSet10;
            // 
            // chamCongNVTableAdapter1
            // 
            this.chamCongNVTableAdapter1.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 159;
            // 
            // soNgayCongDataGridViewTextBoxColumn
            // 
            this.soNgayCongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.soNgayCongDataGridViewTextBoxColumn.DataPropertyName = "SoNgayCong";
            this.soNgayCongDataGridViewTextBoxColumn.HeaderText = "Số Ngày Công";
            this.soNgayCongDataGridViewTextBoxColumn.Name = "soNgayCongDataGridViewTextBoxColumn";
            this.soNgayCongDataGridViewTextBoxColumn.Width = 159;
            // 
            // soNgayNghiDataGridViewTextBoxColumn
            // 
            this.soNgayNghiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.soNgayNghiDataGridViewTextBoxColumn.DataPropertyName = "SoNgayNghi";
            this.soNgayNghiDataGridViewTextBoxColumn.HeaderText = "Số Ngày Nghĩ";
            this.soNgayNghiDataGridViewTextBoxColumn.Name = "soNgayNghiDataGridViewTextBoxColumn";
            this.soNgayNghiDataGridViewTextBoxColumn.Width = 156;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 112;
            // 
            // tongNgayCongDataGridViewTextBoxColumn
            // 
            this.tongNgayCongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tongNgayCongDataGridViewTextBoxColumn.DataPropertyName = "TongNgayCong";
            this.tongNgayCongDataGridViewTextBoxColumn.HeaderText = "Tổng Ngày Công";
            this.tongNgayCongDataGridViewTextBoxColumn.Name = "tongNgayCongDataGridViewTextBoxColumn";
            this.tongNgayCongDataGridViewTextBoxColumn.Width = 163;
            // 
            // fmChamNgayCong
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 512);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.LargeImage = global::AppQL_NhanSu.Properties.Resources.botask_32x32;
            this.Name = "fmChamNgayCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmChamNgayCong";
            this.Load += new System.EventHandler(this.fmChamNgayCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongNVBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_ngaynghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_manv;
        private QLNhanSuDataSet9 qLNhanSuDataSet9;
        private System.Windows.Forms.BindingSource chamCongNVBindingSource;
        private QLNhanSuDataSet9TableAdapters.ChamCongNVTableAdapter chamCongNVTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_xóa;
        private DevExpress.XtraEditors.SimpleButton btn_chinhsua;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.TextBox txt_songaycong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tongngcong;
        private QLNhanSuDataSet10 qLNhanSuDataSet10;
        private System.Windows.Forms.BindingSource chamCongNVBindingSource1;
        private QLNhanSuDataSet10TableAdapters.ChamCongNVTableAdapter chamCongNVTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayNghiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongNgayCongDataGridViewTextBoxColumn;
    }
}