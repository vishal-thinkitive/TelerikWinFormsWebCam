using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Telerik.Windows.MediaFoundation;

namespace TelerikWinFormsWebCam
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }
        public RadWebCam Camera { get { return this.radWebCam1; } }
        private string cameraValidatedRecordingPath = string.Empty;

        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Camera.RecordingFilePath = Path.Combine(ConfigurationManager.AppSettings["VideoPath"], "video.mp4");
            this.radWebCam1.RecordingStarted += this.RadWebCam1_RecordingStarted;
            this.radWebCam1.RecordingEnded += this.RadWebCam1_RecordingEnded;
            this.Camera.CameraError += this.OnCameraError;

        }


        private void radWebCam1_SnapshotTaken(object sender, SnapshotTakenEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Images|.png;.bmp;*.jpg";
            dialog.DefaultExt = ".png";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                e.Snapshot.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void RadWebCam1_RecordingStarted(object sender, CancelEventArgs e)
        {
            this.cameraValidatedRecordingPath = this.radWebCam1.RecordingFilePath;
            this.radWebCam1.RecordingFilePath = this.cameraValidatedRecordingPath.Substring(0, this.cameraValidatedRecordingPath.Length - ".mp4".Length) + DateTime.Now.ToString("HH-mm-ss") + ".mp4";
        }

        private void RadWebCam1_RecordingEnded(object sender, EventArgs e)
        {
            this.radWebCam1.RecordingFilePath = this.cameraValidatedRecordingPath;

        }
        private void OnCameraError(object sender, CameraErrorEventArgs e)
        {
            this.Enabled = false;
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {

        }
                private void startCameraButton_Click(object sender, EventArgs e)
        {
            this.stopCameraButton.Enabled = true;
            this.startCameraButton.Enabled = false;
            this.Camera.Start();
        }

        private void stopCameraButton_Click(object sender, EventArgs e)
        {
            this.startCameraButton.Enabled = true;
            this.stopCameraButton.Enabled = false;
            this.Camera.Stop();

        }
    }
}
