namespace PhanMemQLNhaSach
{
    partial class frmThongKe
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
            this.btnIn = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongMon = new System.Windows.Forms.Label();
            this.lblTongHd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtp3 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listV_TKSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_SCon = new System.Windows.Forms.RadioButton();
            this.rdb_SHet = new System.Windows.Forms.RadioButton();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblTongSach = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInTKTheoSach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIn.Location = new System.Drawing.Point(429, 428);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(245, 41);
            this.btnIn.TabIndex = 31;
            this.btnIn.Text = "In thống kê theo hoá đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(182, 430);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(28, 18);
            this.lblTongTien.TabIndex = 30;
            this.lblTongTien.Text = "TT";
            // 
            // lblTongMon
            // 
            this.lblTongMon.AutoSize = true;
            this.lblTongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongMon.ForeColor = System.Drawing.Color.Red;
            this.lblTongMon.Location = new System.Drawing.Point(585, 389);
            this.lblTongMon.Name = "lblTongMon";
            this.lblTongMon.Size = new System.Drawing.Size(89, 18);
            this.lblTongMon.TabIndex = 29;
            this.lblTongMon.Text = "Tổng Sách";
            // 
            // lblTongHd
            // 
            this.lblTongHd.AutoSize = true;
            this.lblTongHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongHd.ForeColor = System.Drawing.Color.Red;
            this.lblTongHd.Location = new System.Drawing.Point(272, 389);
            this.lblTongHd.Name = "lblTongHd";
            this.lblTongHd.Size = new System.Drawing.Size(75, 18);
            this.lblTongHd.TabIndex = 28;
            this.lblTongHd.Text = "Tổng HD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(426, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tổng số loại sách :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(20, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tổng Doanh Thu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(20, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tổng số hóa đơn thanh toán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(172, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Từ";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(318, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(83, 24);
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtp3
            // 
            this.dtp3.CustomFormat = "yyyy/MM/dd";
            this.dtp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp3.Location = new System.Drawing.Point(216, 13);
            this.dtp3.Name = "dtp3";
            this.dtp3.Size = new System.Drawing.Size(96, 24);
            this.dtp3.TabIndex = 21;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy/MM/dd";
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(71, 14);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(92, 24);
            this.dtp2.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listV_TKSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(404, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 316);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo sách";
            // 
            // listV_TKSanPham
            // 
            this.listV_TKSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listV_TKSanPham.HideSelection = false;
            this.listV_TKSanPham.Location = new System.Drawing.Point(6, 25);
            this.listV_TKSanPham.Name = "listV_TKSanPham";
            this.listV_TKSanPham.Size = new System.Drawing.Size(555, 285);
            this.listV_TKSanPham.TabIndex = 35;
            this.listV_TKSanPham.UseCompatibleStateImageBehavior = false;
            this.listV_TKSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SP";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã NSX";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên SP";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng Tồn";
            this.columnHeader4.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(17, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 316);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo hóa đơn";
            // 
            // rdb_SCon
            // 
            this.rdb_SCon.AutoSize = true;
            this.rdb_SCon.Location = new System.Drawing.Point(604, 18);
            this.rdb_SCon.Name = "rdb_SCon";
            this.rdb_SCon.Size = new System.Drawing.Size(71, 17);
            this.rdb_SCon.TabIndex = 32;
            this.rdb_SCon.TabStop = true;
            this.rdb_SCon.Text = "Sách còn";
            this.rdb_SCon.UseVisualStyleBackColor = true;
            // 
            // rdb_SHet
            // 
            this.rdb_SHet.AutoSize = true;
            this.rdb_SHet.Location = new System.Drawing.Point(681, 18);
            this.rdb_SHet.Name = "rdb_SHet";
            this.rdb_SHet.Size = new System.Drawing.Size(68, 17);
            this.rdb_SHet.TabIndex = 33;
            this.rdb_SHet.TabStop = true;
            this.rdb_SHet.Text = "Sách hết";
            this.rdb_SHet.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Location = new System.Drawing.Point(755, 10);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(83, 29);
            this.btnLoc.TabIndex = 34;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lblTongSach
            // 
            this.lblTongSach.AutoSize = true;
            this.lblTongSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSach.ForeColor = System.Drawing.Color.Red;
            this.lblTongSach.Location = new System.Drawing.Point(844, 389);
            this.lblTongSach.Name = "lblTongSach";
            this.lblTongSach.Size = new System.Drawing.Size(89, 18);
            this.lblTongSach.TabIndex = 36;
            this.lblTongSach.Text = "Tổng Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(717, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tổng số sách :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(369, 285);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã hoá đơn";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày nhập";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng tiền";
            this.columnHeader7.Width = 137;
            // 
            // btnInTKTheoSach
            // 
            this.btnInTKTheoSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInTKTheoSach.Location = new System.Drawing.Point(717, 428);
            this.btnInTKTheoSach.Name = "btnInTKTheoSach";
            this.btnInTKTheoSach.Size = new System.Drawing.Size(216, 41);
            this.btnInTKTheoSach.TabIndex = 37;
            this.btnInTKTheoSach.Text = "In thống kê theo sách";
            this.btnInTKTheoSach.UseVisualStyleBackColor = true;
            this.btnInTKTheoSach.Click += new System.EventHandler(this.btnInTKTheoSach_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 481);
            this.Controls.Add(this.btnInTKTheoSach);
            this.Controls.Add(this.lblTongSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.rdb_SHet);
            this.Controls.Add(this.rdb_SCon);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTongMon);
            this.Controls.Add(this.lblTongHd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtp3);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongMon;
        private System.Windows.Forms.Label lblTongHd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtp3;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_SCon;
        private System.Windows.Forms.RadioButton rdb_SHet;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ListView listV_TKSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblTongSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnInTKTheoSach;
    }
}