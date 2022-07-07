using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.IO;

namespace Contact_tracing_app__vs_2k19_FINAL_
{
    public partial class FrmQrScanner : Form
    {
        public FrmContactTracingForm originalform;
        public FrmQrScanner()
        {
            InitializeComponent();
        }
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;

        private void FrmQrScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
                cbxDevices.Items.Add(filter.Name);
            cbxDevices.SelectedIndex = 1;
            captureDevice = new VideoCaptureDevice();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            pbScanner.Image = bitmap;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmContactTracingForm frmInfo = new FrmContactTracingForm();
            frmInfo.ShowDialog();
        }

        private void FrmQrScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCapturing();
            
                
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbxDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            tmr1.Start();
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (pbScanner.Image != null)
            {
             var reader = new BarcodeReader();
             var result = reader.Decode((Bitmap)pbScanner.Image);                   
                if (result != null)
                {
                     lbl1.Text = result.ToString();
                     tmr1.Stop();
                    stopCapturing();
                    this.Close();                    
                }                   
            }                      
       }    
        
        private void stopCapturing()
        {
            if (captureDevice != null)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                captureDevice = null;
            }
        }
    }
}
