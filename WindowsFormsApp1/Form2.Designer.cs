namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themhd = new System.Windows.Forms.Button();
            this.label_cthd = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label_tongtien = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label_sdt = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_tenkhachhang = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_makhachhang = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_ngaythanhtoan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_mahd = new System.Windows.Forms.Label();
            this.label_hd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_hd);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 733);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label_sdt);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label_tenkhachhang);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label_diachi);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label_makhachhang);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label_ngaythanhtoan);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label_mahd);
            this.panel2.Location = new System.Drawing.Point(4, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 655);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_quaylai);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label_tongtien);
            this.panel3.Location = new System.Drawing.Point(0, 211);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 440);
            this.panel3.TabIndex = 2;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(1132, 398);
            this.btn_quaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(223, 52);
            this.btn_quaylai.TabIndex = 6;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.btn_themhd);
            this.panel4.Controls.Add(this.label_cthd);
            this.panel4.Location = new System.Drawing.Point(0, 80);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1009, 364);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.NgayThanhToan,
            this.MaKhachHang,
            this.ThanhTien,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(156, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 216);
            this.dataGridView1.TabIndex = 4;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hóa đơn:";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 125;
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.HeaderText = "Ngày thanh toán:";
            this.NgayThanhToan.MinimumWidth = 6;
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.Width = 125;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã khách hàng:";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền:";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú:";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 125;
            // 
            // btn_themhd
            // 
            this.btn_themhd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themhd.Location = new System.Drawing.Point(669, 284);
            this.btn_themhd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themhd.Name = "btn_themhd";
            this.btn_themhd.Size = new System.Drawing.Size(173, 52);
            this.btn_themhd.TabIndex = 5;
            this.btn_themhd.Text = "Thêm hóa đơn";
            this.btn_themhd.UseVisualStyleBackColor = true;
            // 
            // label_cthd
            // 
            this.label_cthd.AutoSize = true;
            this.label_cthd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cthd.Location = new System.Drawing.Point(69, 17);
            this.label_cthd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cthd.Name = "label_cthd";
            this.label_cthd.Size = new System.Drawing.Size(206, 26);
            this.label_cthd.TabIndex = 3;
            this.label_cthd.Text = "Thông tin hóa đơn: ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(487, 22);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(240, 31);
            this.textBox7.TabIndex = 1;
            // 
            // label_tongtien
            // 
            this.label_tongtien.AutoSize = true;
            this.label_tongtien.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tongtien.Location = new System.Drawing.Point(334, 22);
            this.label_tongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tongtien.Name = "label_tongtien";
            this.label_tongtien.Size = new System.Drawing.Size(146, 32);
            this.label_tongtien.TabIndex = 0;
            this.label_tongtien.Text = "Tổng tiền: ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(735, 126);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(233, 31);
            this.textBox6.TabIndex = 11;
            // 
            // label_sdt
            // 
            this.label_sdt.AutoSize = true;
            this.label_sdt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdt.Location = new System.Drawing.Point(539, 127);
            this.label_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(156, 26);
            this.label_sdt.TabIndex = 10;
            this.label_sdt.Text = "Số điện thoại: ";
            this.label_sdt.Click += new System.EventHandler(this.label_sdt_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(207, 127);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(224, 31);
            this.textBox5.TabIndex = 9;
            // 
            // label_tenkhachhang
            // 
            this.label_tenkhachhang.AutoSize = true;
            this.label_tenkhachhang.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenkhachhang.Location = new System.Drawing.Point(10, 127);
            this.label_tenkhachhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tenkhachhang.Name = "label_tenkhachhang";
            this.label_tenkhachhang.Size = new System.Drawing.Size(184, 26);
            this.label_tenkhachhang.TabIndex = 8;
            this.label_tenkhachhang.Text = "Tên khách hàng: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(735, 71);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 31);
            this.textBox4.TabIndex = 7;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diachi.Location = new System.Drawing.Point(539, 72);
            this.label_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(94, 26);
            this.label_diachi.TabIndex = 6;
            this.label_diachi.Text = "Địa chỉ: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 72);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 31);
            this.textBox3.TabIndex = 5;
            // 
            // label_makhachhang
            // 
            this.label_makhachhang.AutoSize = true;
            this.label_makhachhang.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_makhachhang.Location = new System.Drawing.Point(7, 72);
            this.label_makhachhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_makhachhang.Name = "label_makhachhang";
            this.label_makhachhang.Size = new System.Drawing.Size(171, 26);
            this.label_makhachhang.TabIndex = 4;
            this.label_makhachhang.Text = "Mã khách hàng:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(735, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label_ngaythanhtoan
            // 
            this.label_ngaythanhtoan.AutoSize = true;
            this.label_ngaythanhtoan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngaythanhtoan.Location = new System.Drawing.Point(539, 15);
            this.label_ngaythanhtoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ngaythanhtoan.Name = "label_ngaythanhtoan";
            this.label_ngaythanhtoan.Size = new System.Drawing.Size(188, 26);
            this.label_ngaythanhtoan.TabIndex = 2;
            this.label_ngaythanhtoan.Text = "Ngày thanh toán: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label_mahd
            // 
            this.label_mahd.AutoSize = true;
            this.label_mahd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mahd.Location = new System.Drawing.Point(10, 19);
            this.label_mahd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mahd.Name = "label_mahd";
            this.label_mahd.Size = new System.Drawing.Size(140, 26);
            this.label_mahd.TabIndex = 0;
            this.label_mahd.Text = "Mã hóa đơn:";
            this.label_mahd.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_hd
            // 
            this.label_hd.AutoSize = true;
            this.label_hd.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_hd.Location = new System.Drawing.Point(431, 12);
            this.label_hd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hd.Name = "label_hd";
            this.label_hd.Size = new System.Drawing.Size(148, 38);
            this.label_hd.TabIndex = 0;
            this.label_hd.Text = "Hóa Đơn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 728);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_hd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_mahd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label_tongtien;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_tenkhachhang;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_makhachhang;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_ngaythanhtoan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_cthd;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_themhd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}