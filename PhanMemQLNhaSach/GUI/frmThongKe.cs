using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLNhaSach
{
    public partial class frmThongKe : Form
    {
        DBconnect Conn = new DBconnect();
        SqlCommand cmd;
        SqlConnection conn;
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        public void LoadDL()
        {
            conn = new SqlConnection("Data Source=WIN2K\\WIN2K;Initial Catalog=QLSACH_BANSACH;User ID=sa;Password=sa2012");
            int tongSL = 0;
            listView1.Items.Clear();
            try
            {
                conn.Open();

         
                string commandString = "SET DATEFORMAT DMY SELECT hd.MAHD, hd.MAKH, kh.TENKH, nv.HOTEN, hd.NGAYHD, hd.TONGTIEN FROM HOADON hd, NHANVIEN nv, KHACHHANG kh WHERE hd.MANV = nv.MANV and hd.MAKH = kh.MAKH and ngayhd >= '" + dtp2.Text + "' and ngayhd <= '" + dtp3.Text + "'";
                cmd = new SqlCommand(commandString, conn);

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    listView1.Items.Add(rd["mahd"].ToString()).SubItems.AddRange(new[] { rd["ngayhd"].ToString(), rd["tongtien"].ToString() });
                    tongSL += Convert.ToInt32(rd["tongtien"].ToString());
                }

                rd.Close();

                conn.Close();
                lblTongTien.Text = tongSL.ToString();
                lblTongHd.Text = listView1.Items.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Loi nhap san pham");
            }
            finally
            {
                conn.Close();
            }
        }
        private void load_lsV_HangTonKho()
        {
            conn = new SqlConnection("Data Source=WIN2K\\WIN2K;Initial Catalog=QLSACH_BANSACH;User ID=sa;Password=sa2012");
            string commandString;
            listV_TKSanPham.Items.Clear();
            if (rdb_SCon.Checked)
                commandString = "select * from sach where soluong > 0";
            else
                commandString = "select * from sach where soluong <= 0";
            try
            {
                conn.Open();
                cmd = new SqlCommand(commandString, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    listV_TKSanPham.Items.Add(rd["masach"].ToString()).SubItems.AddRange(new[] { rd["manxb"].ToString(), rd["tensach"].ToString(), rd["soluong"].ToString() });
                }

                rd.Close();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Loi load so luong ton");
            }
        }


        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            load_lsV_HangTonKho();
            int sum = 0;
            lblTongMon.Text = listV_TKSanPham.Items.Count.ToString();
            for (int i = 0; i < listV_TKSanPham.Items.Count; i++)
            {
                sum += int.Parse(listV_TKSanPham.Items[i].SubItems[3].Text);
            }
            lblTongSach.Text = sum.ToString().Trim();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in listView1.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }
        }

        private void btnInTKTheoSach_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in listV_TKSanPham.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }
        }
    }
}
