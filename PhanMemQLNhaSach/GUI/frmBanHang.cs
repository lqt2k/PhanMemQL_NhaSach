using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


namespace PhanMemQLNhaSach
{
    public partial class frmBanHang : Form
    {
        DBconnect Conn = new DBconnect();
        HD hd = new HD();
        public frmBanHang()
        {
            InitializeComponent();
        }


        private void btnHD_Click(object sender, EventArgs e)
        {
            frmHoaDon a = new frmHoaDon();
            a.ShowDialog();
            
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            int lasths = int.Parse(hd.loadOrderLastID());
            txtMaHD.Text = lasths.ToString();

            LoadDL();
            
            /*string sql = "select  * from hoadon";
            Conn.loadCBO(sql);
            DataTable table1 = new DataTable();
            Conn.Danhsach.Fill(table1);
            cboMaHD.DataSource = table1;
            cboMaHD.DisplayMember = "mahd";
            cboMaHD.ValueMember = "mahd";
            cboMaHD.SelectedItem = 1;*/

            string sqlkh = "select * from sach";
            Conn.loadCBO(sqlkh);
            DataTable table2 = new DataTable();
            Conn.Danhsach.Fill(table2);
            cboTen.DataSource = table2;
            cboTen.DisplayMember = "tensach";
            cboTen.ValueMember = "masach";
            cboTen.SelectedItem = 1;
 
        }
        public void loadcbo()
        {
            
        }
        public void LoadDL()
        {
            string sql = "SELECT CTHD.MACTHD, HD.MAHD, CTHD.MASACH, S.TENSACH, CTHD.SOLUONG, CTHD.GIABAN, CTHD.THANHTIEN FROM ChiTietHD CTHD, HOADON HD, SACH S WHERE HD.MAHD = CTHD.MAHD AND S.MASACH = CTHD.MASACH AND HD.MAHD = " + txtMaHD.Text.Trim();
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            int gia = int.Parse(cboGia.SelectedValue.ToString());
            int sl = int.Parse(numSoLuong.Value.ToString());
            txtTongTien.Text = (gia * sl).ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            try
            {
                string strSQL = "insert into ChiTIetHD values(" + txtMaHD.Text.ToString() + ",N'" + cboTen.SelectedValue.ToString() + "'," + numSoLuong.Value.ToString() + "," + cboGia.SelectedValue.ToString() + "," + txtTongTien.Text.Trim() + ")";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }

        private void cboTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlhd = "select * from Sach where MASACH = '" + cboTen.SelectedValue.ToString().Trim() + "'";
            Conn.loadCBO(sqlhd);
            DataTable table3 = new DataTable();
            Conn.Danhsach.Fill(table3);
            cboGia.DataSource = table3;
            cboGia.DisplayMember = "GIABAN";
            cboGia.ValueMember = "GIABAN";
            cboGia.SelectedItem = 1;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            //WordExport word = new WordExport();
            //word.InHoaDon(...);


            /*Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(@"E:\InHD.docx");
            object missing = System.Reflection.Missing.Value;
            doc.Content.Text += "Mã hoá đơn: "+ txtMaHD.Text.Trim() + "; Tên sách: " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "Số lượng: "+numSoLuong.Value.ToString().Trim() + "Tổng tiền: "+txtTongTien.Text.Trim(); 
            app.Visible = true;    //Optional
            doc.Save();
            this.Close();*/

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "InHD.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }

        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Hoá Đơn Bán Hàng - Quang Trung Book";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

   
            }
        }
    }
}
