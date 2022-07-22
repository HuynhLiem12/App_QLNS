
namespace AppQL_NhanSu
{
    partial class fmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmChucVu));
            this.gb_chucvu = new System.Windows.Forms.GroupBox();
            this.cbx_pccv = new System.Windows.Forms.ComboBox();
            this.chucVuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhanSuDataSet6 = new AppQL_NhanSu.QLNhanSuDataSet6();
            this.cbx_macv = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tencv = new System.Windows.Forms.TextBox();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhanSuDataSet = new AppQL_NhanSu.QLNhanSuDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chucVuTableAdapter = new AppQL_NhanSu.QLNhanSuDataSetTableAdapters.ChucVuTableAdapter();
            this.chucVuTableAdapter1 = new AppQL_NhanSu.QLNhanSuDataSet6TableAdapters.ChucVuTableAdapter();
            this.gb_chucvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_chucvu
            // 
            this.gb_chucvu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gb_chucvu.Controls.Add(this.cbx_pccv);
            this.gb_chucvu.Controls.Add(this.cbx_macv);
            this.gb_chucvu.Controls.Add(this.btn_xoa);
            this.gb_chucvu.Controls.Add(this.btn_sua);
            this.gb_chucvu.Controls.Add(this.btn_thoat);
            this.gb_chucvu.Controls.Add(this.label3);
            this.gb_chucvu.Controls.Add(this.txt_tencv);
            this.gb_chucvu.Controls.Add(this.btn_them);
            this.gb_chucvu.Controls.Add(this.label2);
            this.gb_chucvu.Controls.Add(this.label1);
            this.gb_chucvu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_chucvu.ForeColor = System.Drawing.Color.Blue;
            this.gb_chucvu.Location = new System.Drawing.Point(6, 6);
            this.gb_chucvu.Margin = new System.Windows.Forms.Padding(4);
            this.gb_chucvu.Name = "gb_chucvu";
            this.gb_chucvu.Padding = new System.Windows.Forms.Padding(4);
            this.gb_chucvu.Size = new System.Drawing.Size(475, 336);
            this.gb_chucvu.TabIndex = 0;
            this.gb_chucvu.TabStop = false;
            this.gb_chucvu.Text = "Quản lý chức vụ";
            // 
            // cbx_pccv
            // 
            this.cbx_pccv.DataSource = this.chucVuBindingSource1;
            this.cbx_pccv.DisplayMember = "PCCV";
            this.cbx_pccv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_pccv.FormattingEnabled = true;
            this.cbx_pccv.Location = new System.Drawing.Point(146, 137);
            this.cbx_pccv.Name = "cbx_pccv";
            this.cbx_pccv.Size = new System.Drawing.Size(172, 30);
            this.cbx_pccv.TabIndex = 2;
            // 
            // chucVuBindingSource1
            // 
            this.chucVuBindingSource1.DataMember = "ChucVu";
            this.chucVuBindingSource1.DataSource = this.qLNhanSuDataSet6;
            // 
            // qLNhanSuDataSet6
            // 
            this.qLNhanSuDataSet6.DataSetName = "QLNhanSuDataSet6";
            this.qLNhanSuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx_macv
            // 
            this.cbx_macv.DataSource = this.chucVuBindingSource1;
            this.cbx_macv.DisplayMember = "MaCV";
            this.cbx_macv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_macv.FormattingEnabled = true;
            this.cbx_macv.Location = new System.Drawing.Point(114, 39);
            this.cbx_macv.Name = "cbx_macv";
            this.cbx_macv.Size = new System.Drawing.Size(204, 30);
            this.cbx_macv.TabIndex = 0;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(340, 140);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(117, 37);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(340, 80);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 37);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Chỉnh sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(340, 202);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(117, 37);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phụ cấp chức vụ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_tencv
            // 
            this.txt_tencv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tencv.Location = new System.Drawing.Point(114, 87);
            this.txt_tencv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tencv.Name = "txt_tencv";
            this.txt_tencv.Size = new System.Drawing.Size(204, 30);
            this.txt_tencv.TabIndex = 1;
            this.txt_tencv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tencv_KeyDown);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(340, 17);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(117, 37);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên chức vụ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.qLNhanSuDataSet;
            // 
            // qLNhanSuDataSet
            // 
            this.qLNhanSuDataSet.DataSetName = "QLNhanSuDataSet";
            this.qLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCVDataGridViewTextBoxColumn,
            this.tenCVDataGridViewTextBoxColumn,
            this.pCCVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chucVuBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(8, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 302);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "Mã CV";
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            this.maCVDataGridViewTextBoxColumn.Width = 103;
            // 
            // tenCVDataGridViewTextBoxColumn
            // 
            this.tenCVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenCVDataGridViewTextBoxColumn.DataPropertyName = "TenCV";
            this.tenCVDataGridViewTextBoxColumn.HeaderText = "Tên CV";
            this.tenCVDataGridViewTextBoxColumn.Name = "tenCVDataGridViewTextBoxColumn";
            this.tenCVDataGridViewTextBoxColumn.Width = 107;
            // 
            // pCCVDataGridViewTextBoxColumn
            // 
            this.pCCVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pCCVDataGridViewTextBoxColumn.DataPropertyName = "PCCV";
            this.pCCVDataGridViewTextBoxColumn.HeaderText = "Phụ Cấp CV";
            this.pCCVDataGridViewTextBoxColumn.Name = "pCCVDataGridViewTextBoxColumn";
            this.pCCVDataGridViewTextBoxColumn.Width = 143;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(489, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(408, 336);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị danh sách chức vụ";
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // chucVuTableAdapter1
            // 
            this.chucVuTableAdapter1.ClearBeforeFill = true;
            // 
            // fmChucVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_chucvu);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("fmChucVu.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức vụ";
            this.Load += new System.EventHandler(this.fmChucVu_Load);
            this.gb_chucvu.ResumeLayout(false);
            this.gb_chucvu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_chucvu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tencv;
        private System.Windows.Forms.Label label2;
        private QLNhanSuDataSet qLNhanSuDataSet;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private QLNhanSuDataSetTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbx_macv;
        private System.Windows.Forms.ComboBox cbx_pccv;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private QLNhanSuDataSet6 qLNhanSuDataSet6;
        private System.Windows.Forms.BindingSource chucVuBindingSource1;
        private QLNhanSuDataSet6TableAdapters.ChucVuTableAdapter chucVuTableAdapter1;
    }
}