using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace PhanMemQLNhaSach.GUI
{
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private void frmQR_Load(object sender, EventArgs e)
        {
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

        private void btnLogin_Click(object sender, EventArgs e)
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

                if (decoded != "")
                {
                    timer1.Stop();
                    MessageBox.Show(decoded);
                    /*Form2 form = new Form2();
                    form.Show();*/
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
