
namespace WindowsFormsApp1
{
    partial class trangchu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVientoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhomHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhómHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhómHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySanPhamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhapHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyXuatHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lienHeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.quanLyNhanVientoolStripMenuItem,
            this.quanLyNhomHangToolStripMenuItem,
            this.quanLySanPhamToolStripMenuItem1,
            this.quanLyNhapHangToolStripMenuItem,
            this.quanLyXuatHangToolStripMenuItem,
            this.lienHeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(795, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.trangChuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            // 
            // quanLyNhanVientoolStripMenuItem
            // 
            this.quanLyNhanVientoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem,
            this.thêmNhânViênToolStripMenuItem});
            this.quanLyNhanVientoolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNhanVientoolStripMenuItem.Name = "quanLyNhanVientoolStripMenuItem";
            this.quanLyNhanVientoolStripMenuItem.Size = new System.Drawing.Size(141, 23);
            this.quanLyNhanVientoolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            this.thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            this.thêmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            // 
            // quanLyNhomHangToolStripMenuItem
            // 
            this.quanLyNhomHangToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.quanLyNhomHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhómHàngToolStripMenuItem,
            this.thêmNhómHàngToolStripMenuItem});
            this.quanLyNhomHangToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNhomHangToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quanLyNhomHangToolStripMenuItem.Name = "quanLyNhomHangToolStripMenuItem";
            this.quanLyNhomHangToolStripMenuItem.Size = new System.Drawing.Size(149, 23);
            this.quanLyNhomHangToolStripMenuItem.Text = "Quản lý nhóm hàng";
            // 
            // danhSáchNhómHàngToolStripMenuItem
            // 
            this.danhSáchNhómHàngToolStripMenuItem.Name = "danhSáchNhómHàngToolStripMenuItem";
            this.danhSáchNhómHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.danhSáchNhómHàngToolStripMenuItem.Text = "Danh sách nhóm hàng";
            this.danhSáchNhómHàngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhómHàngToolStripMenuItem_Click);
            // 
            // thêmNhómHàngToolStripMenuItem
            // 
            this.thêmNhómHàngToolStripMenuItem.Name = "thêmNhómHàngToolStripMenuItem";
            this.thêmNhómHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.thêmNhómHàngToolStripMenuItem.Text = "Thêm nhóm hàng";
            // 
            // quanLySanPhamToolStripMenuItem1
            // 
            this.quanLySanPhamToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.quanLySanPhamToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLySanPhamToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quanLySanPhamToolStripMenuItem1.Name = "quanLySanPhamToolStripMenuItem1";
            this.quanLySanPhamToolStripMenuItem1.Size = new System.Drawing.Size(140, 23);
            this.quanLySanPhamToolStripMenuItem1.Text = "Quản lý sản phẩm";
            this.quanLySanPhamToolStripMenuItem1.Click += new System.EventHandler(this.quanLySanPhamToolStripMenuItem1_Click);
            // 
            // quanLyNhapHangToolStripMenuItem
            // 
            this.quanLyNhapHangToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.quanLyNhapHangToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNhapHangToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quanLyNhapHangToolStripMenuItem.Name = "quanLyNhapHangToolStripMenuItem";
            this.quanLyNhapHangToolStripMenuItem.Size = new System.Drawing.Size(145, 23);
            this.quanLyNhapHangToolStripMenuItem.Text = "Quản lý nhập hàng";
            // 
            // quanLyXuatHangToolStripMenuItem
            // 
            this.quanLyXuatHangToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.quanLyXuatHangToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyXuatHangToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quanLyXuatHangToolStripMenuItem.Name = "quanLyXuatHangToolStripMenuItem";
            this.quanLyXuatHangToolStripMenuItem.Size = new System.Drawing.Size(142, 23);
            this.quanLyXuatHangToolStripMenuItem.Text = "Quản lý xuất hàng";
            // 
            // lienHeToolStripMenuItem
            // 
            this.lienHeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lienHeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lienHeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lienHeToolStripMenuItem.Name = "lienHeToolStripMenuItem";
            this.lienHeToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.lienHeToolStripMenuItem.Text = "Liên hệ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(688, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.kho;
            this.label1.Location = new System.Drawing.Point(197, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.kho;
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 561);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "trangchu";
            this.Text = "Trang chủ";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhomHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLySanPhamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhapHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyXuatHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lienHeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhómHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhómHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVientoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênToolStripMenuItem;
    }
}

