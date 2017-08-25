using System;
using AForge.Video;
using System.Drawing;
using AForge.Video.DirectShow;
using System.Windows.Forms;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class WEBCAM : MetroFramework.Forms.MetroForm
    {
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice FinalFrame;
        private VideoCaptureDevice FinalFrame1;

        public WEBCAM()
        {
            InitializeComponent();
        }

        private void WEBCAM_Load(object sender, EventArgs e)
        {

            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo CaptureDevice in CaptureDevices)
            {
                cmbbxWebcam.Items.Add(CaptureDevice.Name);
            }
            FinalFrame = new VideoCaptureDevice();
            FinalFrame1 = new VideoCaptureDevice();
        }

        private void WEBCAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FinalFrame.IsRunning) FinalFrame.SignalToStop();
            if (FinalFrame1.IsRunning) FinalFrame1.SignalToStop();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
                wbCam1.Image = null;
                wbCam1.Invalidate();
            }
            else
            {
                if (cmbbxWebcam.SelectedItem == null)
                {
                    MessageBox.Show("Please Select a webcam device!");
                    return;
                }
                FinalFrame = new VideoCaptureDevice(CaptureDevices[0].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
            }

            if (FinalFrame1.IsRunning)
            {
                FinalFrame1.Stop();
                wbCam2.Image = null;
                wbCam2.Invalidate();
            }
            else
            {
                if (cmbbxWebcam.SelectedItem == null)
                {
                    MessageBox.Show("Please Select a webcam device!");
                    return;
                }
                FinalFrame1 = new VideoCaptureDevice(CaptureDevices[1].MonikerString);
                FinalFrame1.NewFrame += new NewFrameEventHandler(FinalFrame1_NewFrame);
                FinalFrame1.Start();
            }
        }

        private void FinalFrame1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            wbCam1.Image = video;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            wbCam1.Image = video;
        }
    }
}
