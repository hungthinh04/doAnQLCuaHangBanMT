﻿namespace WindowsFormsApp1
{
    partial class FrmTonKho
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
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.txtTenDienThoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDienThoai = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.dtpThoiGianNhap = new System.Windows.Forms.DateTimePicker();
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.grbNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrangChu.Location = new System.Drawing.Point(-102, 8);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(50, 50);
            this.btnTrangChu.TabIndex = 45;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(589, 206);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(124, 38);
            this.btnLamMoi.TabIndex = 21;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(459, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 38);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(329, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 38);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(199, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 38);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(405, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày nhập : ";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(542, 57);
            this.txtSoLuongTon.Multiline = true;
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(148, 31);
            this.txtSoLuongTon.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(405, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số lượng tồn :";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThongKe.Location = new System.Drawing.Point(-102, 344);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(50, 50);
            this.btnThongKe.TabIndex = 39;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDonHang.Location = new System.Drawing.Point(-102, 288);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(50, 50);
            this.btnDonHang.TabIndex = 40;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = false;
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKhoHang.Location = new System.Drawing.Point(-102, 232);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(50, 50);
            this.btnKhoHang.TabIndex = 41;
            this.btnKhoHang.Text = "Kho hàng";
            this.btnKhoHang.UseVisualStyleBackColor = false;
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCungCap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNhaCungCap.Location = new System.Drawing.Point(-102, 176);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(50, 50);
            this.btnNhaCungCap.TabIndex = 42;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQLNV.Location = new System.Drawing.Point(-102, 120);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(50, 50);
            this.btnQLNV.TabIndex = 43;
            this.btnQLNV.Text = "QL Nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = false;
            // 
            // txtTenDienThoai
            // 
            this.txtTenDienThoai.Location = new System.Drawing.Point(178, 97);
            this.txtTenDienThoai.Multiline = true;
            this.txtTenDienThoai.Name = "txtTenDienThoai";
            this.txtTenDienThoai.Size = new System.Drawing.Size(148, 31);
            this.txtTenDienThoai.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên điện thoại";
            // 
            // txtMaDienThoai
            // 
            this.txtMaDienThoai.Location = new System.Drawing.Point(178, 60);
            this.txtMaDienThoai.Multiline = true;
            this.txtMaDienThoai.Name = "txtMaDienThoai";
            this.txtMaDienThoai.Size = new System.Drawing.Size(148, 31);
            this.txtMaDienThoai.TabIndex = 19;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaNV.Location = new System.Drawing.Point(28, 71);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(119, 20);
            this.lblMaNV.TabIndex = 18;
            this.lblMaNV.Text = "Mã điện thoại :";
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.grbNhanVien.Controls.Add(this.dgvKhoHang);
            this.grbNhanVien.Controls.Add(this.dtpThoiGianNhap);
            this.grbNhanVien.Controls.Add(this.btnLamMoi);
            this.grbNhanVien.Controls.Add(this.btnSua);
            this.grbNhanVien.Controls.Add(this.btnXoa);
            this.grbNhanVien.Controls.Add(this.btnThem);
            this.grbNhanVien.Controls.Add(this.label4);
            this.grbNhanVien.Controls.Add(this.txtSoLuongTon);
            this.grbNhanVien.Controls.Add(this.label3);
            this.grbNhanVien.Controls.Add(this.txtTenDienThoai);
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Controls.Add(this.txtMaDienThoai);
            this.grbNhanVien.Controls.Add(this.lblMaNV);
            this.grbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(-4, 26);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(1001, 525);
            this.grbNhanVien.TabIndex = 47;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Hàng trong kho";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(-102, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 50);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSanPham.Location = new System.Drawing.Point(-102, 64);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(50, 50);
            this.btnSanPham.TabIndex = 44;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            // 
            // dtpThoiGianNhap
            // 
            this.dtpThoiGianNhap.Location = new System.Drawing.Point(542, 99);
            this.dtpThoiGianNhap.Name = "dtpThoiGianNhap";
            this.dtpThoiGianNhap.Size = new System.Drawing.Size(372, 30);
            this.dtpThoiGianNhap.TabIndex = 22;
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Location = new System.Drawing.Point(6, 250);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.RowHeadersWidth = 51;
            this.dgvKhoHang.RowTemplate.Height = 24;
            this.dgvKhoHang.Size = new System.Drawing.Size(995, 251);
            this.dgvKhoHang.TabIndex = 23;
            this.dgvKhoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 501);
            this.Controls.Add(this.btnTrangChu);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnKhoHang);
            this.Controls.Add(this.btnNhaCungCap);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSanPham);
            this.Name = "FrmTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTonKho";
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.TextBox txtTenDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDienThoai;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.DateTimePicker dtpThoiGianNhap;
    }
}