namespace PhanMemQLNhaSach
{
    partial class frmBanHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGia = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblTenDoUong = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 337);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(584, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.btnInHD);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboGia);
            this.groupBox2.Controls.Add(this.numSoLuong);
            this.groupBox2.Controls.Add(this.lblTenDoUong);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboTen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblGia);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(10, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 156);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(131, 23);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(149, 26);
            this.txtMaHD.TabIndex = 32;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(482, 58);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(110, 28);
            this.btnInHD.TabIndex = 31;
            this.btnInHD.Text = "In Hoá Đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(131, 103);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(149, 26);
            this.txtTongTien.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tổng Tiền";
            // 
            // cboGia
            // 
            this.cboGia.Enabled = false;
            this.cboGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboGia.FormattingEnabled = true;
            this.cboGia.Location = new System.Drawing.Point(342, 58);
            this.cboGia.Name = "cboGia";
            this.cboGia.Size = new System.Drawing.Size(121, 28);
            this.cboGia.TabIndex = 28;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numSoLuong.Location = new System.Drawing.Point(393, 24);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(70, 26);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // lblTenDoUong
            // 
            this.lblTenDoUong.AutoSize = true;
            this.lblTenDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDoUong.Location = new System.Drawing.Point(24, 66);
            this.lblTenDoUong.Name = "lblTenDoUong";
            this.lblTenDoUong.Size = new System.Drawing.Size(77, 20);
            this.lblTenDoUong.TabIndex = 25;
            this.lblTenDoUong.Text = "Tên Sách";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.Location = new System.Drawing.Point(306, 97);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(157, 32);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thêm vào hoá đơn";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã hóa đơn";
            // 
            // cboTen
            // 
            this.cboTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTen.FormattingEnabled = true;
            this.cboTen.Location = new System.Drawing.Point(131, 63);
            this.cboTen.Name = "cboTen";
            this.cboTen.Size = new System.Drawing.Size(149, 28);
            this.cboTen.TabIndex = 3;
            this.cboTen.SelectedIndexChanged += new System.EventHandler(this.cboTen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(302, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giá";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGia.Location = new System.Drawing.Point(302, 29);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(72, 20);
            this.lblGia.TabIndex = 10;
            this.lblGia.Text = "Số lượng";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MACTHD";
            this.Column1.HeaderText = "Mã CTHĐ";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MAHD";
            this.Column2.HeaderText = "Mã HĐ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MASACH";
            this.Column3.HeaderText = "Mã Sách";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TENSACH";
            this.Column4.HeaderText = "Tên Sách";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SOLUONG";
            this.Column5.HeaderText = "Số Lượng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GIABAN";
            this.Column6.HeaderText = "Giá Bán";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "THANHTIEN";
            this.Column7.HeaderText = "Thành Tiền";
            this.Column7.Name = "Column7";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblTenDoUong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ComboBox cboGia;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}