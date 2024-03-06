namespace WindowsFormsApp1
{
    partial class FrmHoaDon
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
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThoiGianThem = new System.Windows.Forms.DateTimePicker();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.grbNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMaNV.Location = new System.Drawing.Point(62, 106);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(115, 20);
            this.lblMaNV.TabIndex = 18;
            this.lblMaNV.Text = "Mã đơn hàng :";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(212, 95);
            this.txtMaDH.Multiline = true;
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(148, 30);
            this.txtMaDH.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(62, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã khách hàng :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(212, 132);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(148, 30);
            this.txtMaKH.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(62, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mã sản phẩm :";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(212, 207);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(148, 30);
            this.txtMaSP.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(601, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Trạng thái :";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(212, 271);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 38);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 271);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 38);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(472, 271);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 38);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(602, 271);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(124, 38);
            this.btnLamMoi.TabIndex = 22;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.grbNhanVien.Controls.Add(this.dgvHoaDon);
            this.grbNhanVien.Controls.Add(this.chkTrangThai);
            this.grbNhanVien.Controls.Add(this.dtpThoiGianThem);
            this.grbNhanVien.Controls.Add(this.btnLamMoi);
            this.grbNhanVien.Controls.Add(this.btnSua);
            this.grbNhanVien.Controls.Add(this.btnXoa);
            this.grbNhanVien.Controls.Add(this.btnThem);
            this.grbNhanVien.Controls.Add(this.label7);
            this.grbNhanVien.Controls.Add(this.txtSoLuong);
            this.grbNhanVien.Controls.Add(this.label3);
            this.grbNhanVien.Controls.Add(this.txtMaSP);
            this.grbNhanVien.Controls.Add(this.label6);
            this.grbNhanVien.Controls.Add(this.label2);
            this.grbNhanVien.Controls.Add(this.txtMaKH);
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Controls.Add(this.txtMaDH);
            this.grbNhanVien.Controls.Add(this.lblMaNV);
            this.grbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(-2, 1);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(999, 584);
            this.grbNhanVien.TabIndex = 38;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thông tin hoá đơn";
            this.grbNhanVien.Enter += new System.EventHandler(this.grbNhanVien_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(601, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số lượng :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(757, 158);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(177, 31);
            this.txtSoLuong.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(62, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thời gian :";
            // 
            // dtpThoiGianThem
            // 
            this.dtpThoiGianThem.Location = new System.Drawing.Point(212, 169);
            this.dtpThoiGianThem.Name = "dtpThoiGianThem";
            this.dtpThoiGianThem.Size = new System.Drawing.Size(350, 30);
            this.dtpThoiGianThem.TabIndex = 27;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.Location = new System.Drawing.Point(757, 97);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(91, 29);
            this.chkTrangThai.TabIndex = 28;
            this.chkTrangThai.Text = "Đã tạo";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(10, 327);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(959, 187);
            this.dgvHoaDon.TabIndex = 29;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(963, 494);
            this.Controls.Add(this.grbNhanVien);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDon";
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThoiGianThem;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.CheckBox chkTrangThai;
    }
}