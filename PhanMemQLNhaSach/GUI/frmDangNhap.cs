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
using System.Data.SqlClient;
using PhanMemQLNhaSach.GUI;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace PhanMemQLNhaSach
{
    public partial class frmDangNhap : Form
    {
        DBconnect Conn = new DBconnect();
        public frmDangNhap()
        {
            InitializeComponent();
            this.Height = 190;
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void comboboxNV()
        {
            string sql = "select TaiKhoan,MatKhau from NhanVien";
            Conn.loadCBO(sql);
            DataTable table = new DataTable();
            Conn.Danhsach.Fill(table);
            cboTen.DataSource = table;
            cboTen.DisplayMember = "Taikhoan";
            cboTen.ValueMember = "TaiKhoan";
            cboTen.SelectedItem = 1;
            cboTen.SelectedIndex = -1;

        }


        NVDAO nv = new NVDAO();
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WIN2K\WIN2K;Initial Catalog=QLSACH_BANSACH;Persist Security Info=True;User ID=sa;Password=sa2012");
            try
            {
                conn.Open();
                string sql;
                sql = "select * from NhanVien  where TAIKHOAN='" + cboTen.Text + "' and MATKHAU='" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    NV acc = nv.getAcountByUsername(cboTen.Text);
                    MessageBox.Show("Bạn đã đăng nhập thành công", "Thông Báo");
                    frmMain main = new frmMain(acc);
                    this.Hide();
                    main.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void frmDangNhap_Load_1(object sender, EventArgs e)
        {
            comboboxNV();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            this.Height = 500;
            /*frmQR qr = new frmQR();
            qr.Show();*/
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

            //timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();

                if (decoded == "trung")
                {
                    timer1.Stop();
                    MessageBox.Show("Xin chào: " + decoded);
                    cboTen.Text = "trung";
                    txtPass.Text = "123";
                }
                else if (decoded == "win")
                {
                    timer1.Stop();
                    MessageBox.Show("Xin chào: " + decoded);
                    cboTen.Text = "win";
                    txtPass.Text = "123";
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Height = 190;
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }
    }
}
