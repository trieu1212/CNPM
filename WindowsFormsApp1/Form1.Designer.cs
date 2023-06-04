namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_ttdp = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label_maphong = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label_ngaythue = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label_sdt = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_khdp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_dsphong = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhachToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_thuephong = new System.Windows.Forms.Button();
            this.label_maphieuthue = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label_maphieuthue);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label_diachi);
            this.panel1.Controls.Add(this.label_ttdp);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.label_maphong);
            this.panel1.Controls.Add(this.txt4);
            this.panel1.Controls.Add(this.label_ngaythue);
            this.panel1.Controls.Add(this.txt3);
            this.panel1.Controls.Add(this.label_sdt);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Controls.Add(this.label_khdp);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 279);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(498, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 31);
            this.textBox1.TabIndex = 5;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(383, 148);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(82, 23);
            this.label_diachi.TabIndex = 11;
            this.label_diachi.Text = "Địa chỉ: ";
            // 
            // label_ttdp
            // 
            this.label_ttdp.AutoSize = true;
            this.label_ttdp.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ttdp.Location = new System.Drawing.Point(22, 56);
            this.label_ttdp.Name = "label_ttdp";
            this.label_ttdp.Size = new System.Drawing.Size(229, 26);
            this.label_ttdp.TabIndex = 10;
            this.label_ttdp.Text = "Thông Tin Đặt Phòng:";
            this.label_ttdp.Click += new System.EventHandler(this.label_ttdp_Click);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Location = new System.Drawing.Point(194, 101);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(162, 31);
            this.txt1.TabIndex = 1;
            // 
            // label_maphong
            // 
            this.label_maphong.AutoSize = true;
            this.label_maphong.Location = new System.Drawing.Point(383, 101);
            this.label_maphong.Name = "label_maphong";
            this.label_maphong.Size = new System.Drawing.Size(109, 23);
            this.label_maphong.TabIndex = 1;
            this.label_maphong.Text = "Mã phòng: ";
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4.Location = new System.Drawing.Point(194, 191);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(162, 31);
            this.txt4.TabIndex = 7;
            // 
            // label_ngaythue
            // 
            this.label_ngaythue.AutoSize = true;
            this.label_ngaythue.Location = new System.Drawing.Point(381, 193);
            this.label_ngaythue.Name = "label_ngaythue";
            this.label_ngaythue.Size = new System.Drawing.Size(111, 23);
            this.label_ngaythue.TabIndex = 6;
            this.label_ngaythue.Text = "Ngày thuê: ";
            this.label_ngaythue.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Location = new System.Drawing.Point(194, 146);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(162, 31);
            this.txt3.TabIndex = 4;
            // 
            // label_sdt
            // 
            this.label_sdt.AutoSize = true;
            this.label_sdt.Location = new System.Drawing.Point(23, 193);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(137, 23);
            this.label_sdt.TabIndex = 4;
            this.label_sdt.Text = "Số điện thoại: ";
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Location = new System.Drawing.Point(498, 99);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(162, 31);
            this.txt2.TabIndex = 2;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_Title.Location = new System.Drawing.Point(164, 0);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(398, 42);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Phiếu Thuê Khách Sạn";
            // 
            // label_khdp
            // 
            this.label_khdp.AutoSize = true;
            this.label_khdp.Location = new System.Drawing.Point(23, 148);
            this.label_khdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_khdp.Name = "label_khdp";
            this.label_khdp.Size = new System.Drawing.Size(164, 23);
            this.label_khdp.TabIndex = 2;
            this.label_khdp.Text = "Tên khách hàng: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_dsphong);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(1, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 335);
            this.panel2.TabIndex = 1;
            // 
            // label_dsphong
            // 
            this.label_dsphong.AutoSize = true;
            this.label_dsphong.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_dsphong.Location = new System.Drawing.Point(26, 31);
            this.label_dsphong.Name = "label_dsphong";
            this.label_dsphong.Size = new System.Drawing.Size(200, 26);
            this.label_dsphong.TabIndex = 13;
            this.label_dsphong.Text = "Danh Sách Phòng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.LoaiPhong,
            this.SoKhachToiDa,
            this.TinhTrang,
            this.DonGia});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(11, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 141);
            this.dataGridView1.TabIndex = 12;
            // 
            // Maphong
            // 
            this.Maphong.HeaderText = "Mã Phòng:";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 150;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại Phòng:";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 150;
            // 
            // SoKhachToiDa
            // 
            this.SoKhachToiDa.HeaderText = "Số Khách Tối Đa:";
            this.SoKhachToiDa.MinimumWidth = 6;
            this.SoKhachToiDa.Name = "SoKhachToiDa";
            this.SoKhachToiDa.Width = 200;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng phòng: ";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá:";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_quaylai);
            this.panel4.Controls.Add(this.btn_thuephong);
            this.panel4.Location = new System.Drawing.Point(3, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 73);
            this.panel4.TabIndex = 3;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(544, 15);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(130, 39);
            this.btn_quaylai.TabIndex = 1;
            this.btn_quaylai.Text = "Quay Lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_thuephong
            // 
            this.btn_thuephong.Location = new System.Drawing.Point(382, 15);
            this.btn_thuephong.Name = "btn_thuephong";
            this.btn_thuephong.Size = new System.Drawing.Size(130, 39);
            this.btn_thuephong.TabIndex = 0;
            this.btn_thuephong.Text = "Thuê Phòng";
            this.btn_thuephong.UseVisualStyleBackColor = true;
            // 
            // label_maphieuthue
            // 
            this.label_maphieuthue.AutoSize = true;
            this.label_maphieuthue.Location = new System.Drawing.Point(23, 109);
            this.label_maphieuthue.Name = "label_maphieuthue";
            this.label_maphieuthue.Size = new System.Drawing.Size(147, 23);
            this.label_maphieuthue.TabIndex = 12;
            this.label_maphieuthue.Text = "Mã phiếu thuê:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(498, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 31);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Thuê";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label_ngaythue;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_khdp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_maphong;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label_ttdp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_thuephong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_dsphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhachToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_maphieuthue;
    }
}

