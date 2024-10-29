namespace quanlydiemdanhsinhvien
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênCấmThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaSoSinhVien = new System.Windows.Forms.TextBox();
            this.txbHoVaTen = new System.Windows.Forms.TextBox();
            this.txbLop = new System.Windows.Forms.TextBox();
            this.dtpkNgayDiemDanh = new System.Windows.Forms.DateTimePicker();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbtNam = new System.Windows.Forms.RadioButton();
            this.rdbtNu = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMaSoSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1040, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýMônHọcToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSinhViênCấmThiToolStripMenuItem});
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản Lý Sinh Viên";
            // 
            // danhSáchSinhViênCấmThiToolStripMenuItem
            // 
            this.danhSáchSinhViênCấmThiToolStripMenuItem.Name = "danhSáchSinhViênCấmThiToolStripMenuItem";
            this.danhSáchSinhViênCấmThiToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.danhSáchSinhViênCấmThiToolStripMenuItem.Text = "Danh Sách Sinh Viên Cấm Thi";
            this.danhSáchSinhViênCấmThiToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSinhViênCấmThiToolStripMenuItem_Click);
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            this.quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            this.quảnLýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.quảnLýMônHọcToolStripMenuItem.Text = "Quản Lý Môn Học";
            this.quảnLýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Môn Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Điểm Danh";
            // 
            // txbMaSoSinhVien
            // 
            this.txbMaSoSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaSoSinhVien.Location = new System.Drawing.Point(167, 55);
            this.txbMaSoSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaSoSinhVien.Name = "txbMaSoSinhVien";
            this.txbMaSoSinhVien.Size = new System.Drawing.Size(368, 30);
            this.txbMaSoSinhVien.TabIndex = 8;
            // 
            // txbHoVaTen
            // 
            this.txbHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoVaTen.Location = new System.Drawing.Point(167, 93);
            this.txbHoVaTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbHoVaTen.Name = "txbHoVaTen";
            this.txbHoVaTen.Size = new System.Drawing.Size(368, 30);
            this.txbHoVaTen.TabIndex = 9;
            // 
            // txbLop
            // 
            this.txbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLop.Location = new System.Drawing.Point(167, 140);
            this.txbLop.Margin = new System.Windows.Forms.Padding(4);
            this.txbLop.Name = "txbLop";
            this.txbLop.Size = new System.Drawing.Size(172, 30);
            this.txbLop.TabIndex = 10;
            // 
            // dtpkNgayDiemDanh
            // 
            this.dtpkNgayDiemDanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayDiemDanh.Location = new System.Drawing.Point(167, 195);
            this.dtpkNgayDiemDanh.Name = "dtpkNgayDiemDanh";
            this.dtpkNgayDiemDanh.Size = new System.Drawing.Size(131, 30);
            this.dtpkNgayDiemDanh.TabIndex = 11;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Items.AddRange(new object[] {
            "Mã Hoá Ứng Dụng",
            "Lập Trình Hướng Đối Tượng",
            "Kĩ Thuật Lập Trình"});
            this.cbbMonHoc.Location = new System.Drawing.Point(167, 242);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(368, 30);
            this.cbbMonHoc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giới Tính";
            // 
            // rdbtNam
            // 
            this.rdbtNam.AutoSize = true;
            this.rdbtNam.Checked = true;
            this.rdbtNam.Location = new System.Drawing.Point(649, 130);
            this.rdbtNam.Name = "rdbtNam";
            this.rdbtNam.Size = new System.Drawing.Size(68, 26);
            this.rdbtNam.TabIndex = 14;
            this.rdbtNam.TabStop = true;
            this.rdbtNam.Text = "Nam";
            this.rdbtNam.UseVisualStyleBackColor = true;
            // 
            // rdbtNu
            // 
            this.rdbtNu.AutoSize = true;
            this.rdbtNu.Location = new System.Drawing.Point(649, 162);
            this.rdbtNu.Name = "rdbtNu";
            this.rdbtNu.Size = new System.Drawing.Size(56, 26);
            this.rdbtNu.TabIndex = 15;
            this.rdbtNu.TabStop = true;
            this.rdbtNu.Text = "Nữ";
            this.rdbtNu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Điểm Danh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(848, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Chỉnh Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(848, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 38);
            this.button3.TabIndex = 18;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(848, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 38);
            this.button4.TabIndex = 19;
            this.button4.Text = "Tải Lại";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSoSinhVien,
            this.clHoVaTen,
            this.clGioiTinh,
            this.clLop,
            this.clNgayDiemDanh,
            this.clMonHoc});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 303);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 271);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgSinhVien);
            // 
            // clMaSoSinhVien
            // 
            this.clMaSoSinhVien.DataPropertyName = "MaSoSinhVien";
            this.clMaSoSinhVien.HeaderText = "Mã Số Sinh Viên";
            this.clMaSoSinhVien.MinimumWidth = 6;
            this.clMaSoSinhVien.Name = "clMaSoSinhVien";
            this.clMaSoSinhVien.ReadOnly = true;
            // 
            // clHoVaTen
            // 
            this.clHoVaTen.DataPropertyName = "HoVaTen";
            this.clHoVaTen.HeaderText = "Họ Và Tên";
            this.clHoVaTen.MinimumWidth = 6;
            this.clHoVaTen.Name = "clHoVaTen";
            this.clHoVaTen.ReadOnly = true;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.DataPropertyName = "GioiTinh";
            this.clGioiTinh.HeaderText = "Giới Tính";
            this.clGioiTinh.MinimumWidth = 6;
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.ReadOnly = true;
            // 
            // clLop
            // 
            this.clLop.DataPropertyName = "Lop";
            this.clLop.HeaderText = "Lớp";
            this.clLop.MinimumWidth = 6;
            this.clLop.Name = "clLop";
            this.clLop.ReadOnly = true;
            // 
            // clNgayDiemDanh
            // 
            this.clNgayDiemDanh.DataPropertyName = "NgayDiemDanh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.clNgayDiemDanh.DefaultCellStyle = dataGridViewCellStyle1;
            this.clNgayDiemDanh.HeaderText = "Ngày Điểm Danh";
            this.clNgayDiemDanh.MinimumWidth = 6;
            this.clNgayDiemDanh.Name = "clNgayDiemDanh";
            this.clNgayDiemDanh.ReadOnly = true;
            // 
            // clMonHoc
            // 
            this.clMonHoc.DataPropertyName = "MonHoc";
            this.clMonHoc.HeaderText = "Môn Học";
            this.clMonHoc.MinimumWidth = 6;
            this.clMonHoc.Name = "clMonHoc";
            this.clMonHoc.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 574);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbtNu);
            this.Controls.Add(this.rdbtNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.dtpkNgayDiemDanh);
            this.Controls.Add(this.txbLop);
            this.Controls.Add(this.txbHoVaTen);
            this.Controls.Add(this.txbMaSoSinhVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quản Lý Điểm Danh Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênCấmThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMaSoSinhVien;
        private System.Windows.Forms.TextBox txbHoVaTen;
        private System.Windows.Forms.TextBox txbLop;
        private System.Windows.Forms.DateTimePicker dtpkNgayDiemDanh;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbtNam;
        private System.Windows.Forms.RadioButton rdbtNu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSoSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonHoc;
    }
}

