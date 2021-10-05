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
    public partial class frmQLSach : Form
    {
        DBconnect Conn = new DBconnect();   
        public frmQLSach()
        {
            InitializeComponent();
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            LoadDL();
            combobox();
            cbNXB.SelectedIndex = -1;
            cboMaLoai.SelectedIndex = -1;
            cboTacGia.SelectedIndex = -1;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui nhập chọn mã sách");
                    return;
                }
                else if(txtTenSach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui nhập tên sách");
                    return;
                }
                else if (txtGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui nhập giá sách");
                    return;
                }
                string strSQL = "select count(*) from sach where masach='" + txtID.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã đã tồn tại  " + txtID.Text.Trim() + ". Vui lòng nhập mã khác");
                    txtID.Clear();
                    txtID.Focus();
                    return;
                }
                strSQL = "insert into sach values('" + txtID.Text.Trim() + "',N'" + cbNXB.SelectedValue.ToString() + "',N'" + cboTacGia.SelectedValue.ToString() + "',N'" + cboMaLoai.SelectedValue.ToString() + "',N'" + txtTenSach.Text.Trim() + "','" + txtSoLuong.Text.Trim() + "','" + txtGia.Text.Trim() + "')";
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();
                
            }
            catch
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập mã sách");
                    return;
                }

                string strSQL = "select count(*) from sach where masach='" + txtID.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã sách " + txtID.Text.Trim() + ". Để Xóa");
                    txtID.Clear();
                    txtID.Focus();
                    return;
                }
                strSQL = "Delete sach where masach='" + txtID.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadDL();
                
            }
            catch
            {
                MessageBox.Show("Xóa Thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                string strSQL = "select count(*) from sach where masach='" + txtID.Text.Trim() + "'";
                if (!Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Không Có mã sách " + txtID.Text.Trim() + ". Để sửa");
                    txtID.Clear();
                    txtID.Focus();
                    return;
                }
                strSQL = "Update sach set MANXB = N'" + cbNXB.SelectedValue.ToString() + "', MATG = N'" + cboTacGia.SelectedValue.ToString() + "', MATL = N'" + cboMaLoai.SelectedValue.ToString() + "', TENSACH =N'" + txtTenSach.Text.Trim() + "' , GIABAN = '" + txtGia.Text.Trim() + "', SOLUONG ='" + txtSoLuong.Text.Trim() + "'  where MASACH='" + txtID.Text.Trim() + "'";
                Conn.updateDatabase(strSQL);
                MessageBox.Show("Cập nhật thành công");
                LoadDL();

            }
            catch
            {
                MessageBox.Show("Cập nhật Thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string cbTen = txtTim.Text.Trim();
                string strSQL = "";
                strSQL = "select * from sach where tensach like N'" + cbTen + "%'";
                Conn.truyvanDL(strSQL);
                DataSet ds_sach = new DataSet();
                Conn.Danhsach.Fill(ds_sach);
                dataGridView1.DataSource = ds_sach.Tables[0];
                dataGridView1.Refresh();

            }
            catch
            {
                MessageBox.Show("tìm kiếm  Thất bại");
            }
        }
        public void LoadDL()
        {
            string sql = "select * from sach";
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }
        public void combobox()
        {
            string sql;
            sql = "select  * from THeLoai";
            Conn.loadCBO(sql);
            DataTable table1 = new DataTable();
            Conn.Danhsach.Fill(table1);
            cboMaLoai.DataSource = table1;
            cboMaLoai.DisplayMember = "TenTL";
            cboMaLoai.ValueMember = "MaTL";
            cboMaLoai.SelectedItem = 1;
    

            sql = "select  * from TacGia";
            Conn.loadCBO(sql);
            DataTable table2 = new DataTable();
            Conn.Danhsach.Fill(table2);
            cboTacGia.DataSource = table2;
            cboTacGia.DisplayMember = "TenTG";
            cboTacGia.ValueMember = "MATG";
            cboTacGia.SelectedItem = 1;

            sql = "select  * from NhaXuatBan";
            Conn.loadCBO(sql);
            DataTable table3 = new DataTable();
            Conn.Danhsach.Fill(table3);
            cbNXB.DataSource = table3;
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MANXB";
            cbNXB.SelectedItem = 1;
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];

            txtID.Text = li.Cells[0].Value.ToString().Trim();
            txtTenSach.Text = li.Cells[4].Value.ToString().Trim();
            txtGia.Text = li.Cells[6].Value.ToString().Trim();
            cboMaLoai.SelectedValue = li.Cells[3].Value.ToString().Trim();
            cboTacGia.SelectedValue = li.Cells[2].Value.ToString().Trim();
            cbNXB.SelectedValue = li.Cells[1].Value.ToString().Trim();
            txtSoLuong.Text = li.Cells[5].Value.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            
                MessageBox.Show("Vui lòng nhập đúng định dạng số");
                
            
            
        }
      
    }
}
