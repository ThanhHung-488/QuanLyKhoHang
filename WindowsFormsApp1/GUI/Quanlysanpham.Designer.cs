
namespace WindowsFormsApp1
{
    partial class Quanlysanpham
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_manhomhang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Navy;
            this.btn_search.Location = new System.Drawing.Point(798, 260);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(101, 28);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Navy;
            this.btn_edit.Location = new System.Drawing.Point(833, 168);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(66, 28);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_show.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.Navy;
            this.btn_show.Location = new System.Drawing.Point(833, 33);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(66, 28);
            this.btn_show.TabIndex = 19;
            this.btn_show.Text = "Show ";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Navy;
            this.btn_save.Location = new System.Drawing.Point(833, 122);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(66, 28);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(43, 309);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersWidth = 51;
            this.dgv_sanpham.Size = new System.Drawing.Size(680, 294);
            this.dgv_sanpham.TabIndex = 17;
            this.dgv_sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellContentClick);
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensp.Location = new System.Drawing.Point(128, 93);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(214, 26);
            this.txt_tensp.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(268, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã sản phẩm";
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masp.Location = new System.Drawing.Point(128, 43);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(141, 26);
            this.txt_masp.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đơn vị tính";
            // 
            // txt_dvt
            // 
            this.txt_dvt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dvt.Location = new System.Drawing.Point(126, 147);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(113, 26);
            this.txt_dvt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giá";
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(509, 39);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(113, 26);
            this.txt_gia.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã nhóm hàng";
            // 
            // cbo_manhomhang
            // 
            this.cbo_manhomhang.FormattingEnabled = true;
            this.cbo_manhomhang.Items.AddRange(new object[] {
            "NH001",
            "NH002",
            "NH003",
            "NH004",
            "NH005"});
            this.cbo_manhomhang.Location = new System.Drawing.Point(514, 90);
            this.cbo_manhomhang.Name = "cbo_manhomhang";
            this.cbo_manhomhang.Size = new System.Drawing.Size(121, 25);
            this.cbo_manhomhang.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_manhomhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_tensp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dvt);
            this.groupBox1.Controls.Add(this.txt_masp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 185);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sản phẩm";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Navy;
            this.btn_delete.Location = new System.Drawing.Point(833, 215);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(66, 28);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_pre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pre.ForeColor = System.Drawing.Color.Navy;
            this.btn_pre.Location = new System.Drawing.Point(64, 264);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(66, 28);
            this.btn_pre.TabIndex = 18;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.Navy;
            this.btn_next.Location = new System.Drawing.Point(632, 260);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(66, 28);
            this.btn_next.TabIndex = 19;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Navy;
            this.btn_exit.Location = new System.Drawing.Point(745, 328);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(131, 32);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(833, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quanlysanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(926, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.label1);
            this.Name = "Quanlysanpham";
            this.Text = "Quanlysanpham";
            this.Load += new System.EventHandler(this.Quanlysanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_manhomhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
    }
}