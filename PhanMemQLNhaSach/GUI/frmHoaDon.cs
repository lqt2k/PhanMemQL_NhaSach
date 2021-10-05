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
    public partial class frmHoaDon : Form
    {
        DBconnect Conn = new DBconnect();
        HD hd = new HD();

        public frmHoaDon()
        {
            InitializeComponent();
        }
        public frmHoaDon(NV acc)
        {
            InitializeComponent();
            this.NV = acc;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
      
            string sql;
            sql = "select  * from Khachhang";
            Conn.loadCBO(sql);
            DataTable table1 = new DataTable();
            Conn.Danhsach.Fill(table1);
            cboTenKH.DataSource = table1;
            cboTenKH.DisplayMember = "tenkh";
            cboTenKH.ValueMember = "makh";
            cboTenKH.SelectedItem = -1;
            


            //string sqlNV;
            //sql = "select  * from NHanVien";
            //Conn.loadCBO(sql);
            //DataTable table2 = new DataTable();
            //Conn.Danhsach.Fill(table2);
            //txtMaNV.DataSource = table2;
            //txtMaNV.DisplayMember = "TenNV";
            //txtMaNV.ValueMember = "MaNV";
            //txtMaNV.SelectedItem = 1;



            LoadDL();
    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtMaHD.Text.Trim().Length == 0)
                //{
                //    MessageBox.Show("Vui nhập chọn mã Hóa Đơn");
                //    return;
                //}
                string strSQL = "select count(*) from HoaDOn where MaHD='" + txtMaHD.Text.Trim() + "'";
                if (Conn.KiemTraTrung(strSQL))
                {
                    MessageBox.Show("Mã đã tồn tại  " + txtMaHD.Text.Trim() + ". Vui lòng nhập mã khác");
                    txtMaHD.Clear();
                    txtMaHD.Focus();
                    return;
                }
                string selectDateAsString = dtpNgayLap.Value.ToString("yyyyMMdd");
                //strSQL = "insert into HoaDOn values('" + txtMaHD.Text.Trim() + "','" + cboMaKH.SelectedValue.ToString().Trim() + "','" + cboNhanVien.SelectedValue.ToString().Trim() + "','" + dtpNgayLap.Value.ToShortDateString().Trim() + "',null)";
                strSQL = "insert into HoaDOn values('" + txtMaKH.Text.ToString().Trim() + "','" + txtMaNV.Text.Trim() + "','" + selectDateAsString.Trim() + "',null)";
                
                Conn.updateDatabase(strSQL);

                MessageBox.Show("Thêm thành công");
                LoadDL();
                frmBanHang bh = new frmBanHang();
                bh.ShowDialog();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm Thất bại"+ex.Message);
            }
            
        }

        /*public void LoadDL()
        {
            string sql = "select * from hoadon";
            int lasths = int.Parse(hd.loadOrderLastID()) + 1;
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            txtMaHD.Text = lasths.ToString();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }*/
        public void LoadDL()
        {
            string sql = "SELECT hd.MAHD, hd.MAKH, kh.TENKH, nv.HOTEN, hd.NGAYHD, hd.TONGTIEN FROM HOADON hd, NHANVIEN nv, KHACHHANG kh WHERE hd.MANV = nv.MANV and hd.MAKH = kh.MAKH";
            int lasths = int.Parse(hd.loadOrderLastID()) + 1;
            Conn.truyvanDL(sql);
            DataSet ds_sach = new DataSet();
            txtMaHD.Text = lasths.ToString();
            Conn.Danhsach.Fill(ds_sach);
            dataGridView1.DataSource = ds_sach.Tables[0];
            dataGridView1.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow li = dataGridView1.Rows[e.RowIndex];
            txtMaHD.Text = li.Cells[0].Value.ToString().Trim();
            cboTenKH.Text = li.Cells[2].Value.ToString().Trim();
            txtTenNV.Text = li.Cells[3].Value.ToString().Trim();
            dtpNgayLap.Text = li.Cells[4].Value.ToString().Trim();
  
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private NV nv;

        public NV NV
        {
            get { return nv; }
            set { nv = value; staff(NV); }
        }

        private void staff(NV nv)
        {
            txtTenNV.Text = nv.TenNV.ToString();
            txtMaNV.Text = nv.MaNV.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachHang nv = new frmKhachHang();

            nv.ShowDialog();
        }

        private void cboTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int makh = int.Parse(cboTenKH.SelectedIndex.ToString().Trim()) + 1;
            txtMaKH.Text = "KH"+makh.ToString();
        }
    }
}
