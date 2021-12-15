namespace WindowsFormsApp1
{
    partial class nhaphang
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
            this.cboNhomHang = new System.Windows.Forms.ComboBox();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNhanVienNhap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtNgayNhapKho = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhieuNhapKho = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNhapKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboNhomHang
            // 
            this.cboNhomHang.FormattingEnabled = true;
            this.cboNhomHang.Location = new System.Drawing.Point(847, 81);
            this.cboNhomHang.Name = "cboNhomHang";
            this.cboNhomHang.Size = new System.Drawing.Size(162, 30);
            this.cboNhomHang.TabIndex = 17;
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapKho.Location = new System.Drawing.Point(47, 338);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.RowTemplate.Height = 24;
            this.dgvNhapKho.Size = new System.Drawing.Size(1032, 222);
            this.dgvNhapKho.TabIndex = 29;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrevious.Location = new System.Drawing.Point(397, 593);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 44);
            this.btnPrevious.TabIndex = 38;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(707, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nhóm hàng";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightCoral;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext.Location = new System.Drawing.Point(542, 593);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 44);
            this.btnNext.TabIndex = 39;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(847, 21);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(162, 30);
            this.txtGiaTien.TabIndex = 15;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.LightCoral;
            this.btnLast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLast.Location = new System.Drawing.Point(717, 593);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 44);
            this.btnLast.TabIndex = 37;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(707, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giá tiền";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Location = new System.Drawing.Point(1152, 582);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 55);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(1152, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 55);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày nhập kho";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.LightCoral;
            this.btnFirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFirst.Location = new System.Drawing.Point(222, 593);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 44);
            this.btnFirst.TabIndex = 40;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng";
            // 
            // cboNhanVienNhap
            // 
            this.cboNhanVienNhap.FormattingEnabled = true;
            this.cboNhanVienNhap.Location = new System.Drawing.Point(166, 129);
            this.cboNhanVienNhap.Name = "cboNhanVienNhap";
            this.cboNhanVienNhap.Size = new System.Drawing.Size(139, 30);
            this.cboNhanVienNhap.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên sản phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(270, 282);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(472, 34);
            this.txtSearch.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightCoral;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(796, 277);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 45);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã sản phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(503, 129);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(131, 30);
            this.txtSoLuong.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(1152, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 55);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Sửa ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(503, 73);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(131, 30);
            this.txtTenSanPham.TabIndex = 7;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(503, 22);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(131, 30);
            this.txtMaSanPham.TabIndex = 6;
            // 
            // txtNgayNhapKho
            // 
            this.txtNgayNhapKho.Location = new System.Drawing.Point(847, 128);
            this.txtNgayNhapKho.Name = "txtNgayNhapKho";
            this.txtNgayNhapKho.Size = new System.Drawing.Size(162, 30);
            this.txtNgayNhapKho.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightCoral;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(1152, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 55);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhân viên nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(436, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 43);
            this.label1.TabIndex = 30;
            this.label1.Text = "QUẢN LÝ NHẬP KHO";
            // 
            // txtPhieuNhapKho
            // 
            this.txtPhieuNhapKho.Location = new System.Drawing.Point(166, 73);
            this.txtPhieuNhapKho.Name = "txtPhieuNhapKho";
            this.txtPhieuNhapKho.Size = new System.Drawing.Size(139, 30);
            this.txtPhieuNhapKho.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNhomHang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboNhanVienNhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.txtNgayNhapKho);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhieuNhapKho);
            this.groupBox1.Controls.Add(this.txtMaNhapKho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(103, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 186);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtMaNhapKho
            // 
            this.txtMaNhapKho.Location = new System.Drawing.Point(166, 27);
            this.txtMaNhapKho.Name = "txtMaNhapKho";
            this.txtMaNhapKho.Size = new System.Drawing.Size(139, 30);
            this.txtMaNhapKho.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phiếu nhập kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhập kho";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightCoral;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInsert.Location = new System.Drawing.Point(1152, 282);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(102, 55);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnXML
            // 
            this.btnXML.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXML.Location = new System.Drawing.Point(922, 593);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(97, 44);
            this.btnXML.TabIndex = 43;
            this.btnXML.Text = "Xuất XML";
            this.btnXML.UseVisualStyleBackColor = false;
            // 
            // nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1301, 654);
            this.Controls.Add(this.dgvNhapKho);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnXML);
            this.Name = "nhaphang";
            this.Text = "nhaphang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNhomHang;
        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNhanVienNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtNgayNhapKho;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhieuNhapKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNhapKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnXML;

    }
}