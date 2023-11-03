using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace TelerikWinFormsWebCam
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        

        private void radWebCam1_SnapshotTaken(object sender, SnapshotTakenEventArgs e)
        {
            string path = ConfigurationManager.AppSettings["SnapShotPath"];
            Image snapshot = e.Snapshot;
            snapshot.Save(path+ @"\Snap1.png");


        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["VideoPath"];
            try
            {
                RadWebCam radWebCam1 = new RadWebCam();
                radWebCam1.AutoStart = false;

                radWebCam1.Start();
                radWebCam1.RecordingFilePath = path + @"\Video1.mp4";
                radWebCam1.StartRecording();

                Task.Delay(10000).Wait();

                radWebCam1.StopRecording();


                radWebCam1.Stop();

                this.Controls.Add(radWebCam1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while starting the webcam: " + ex.Message);
            }

        }
           
    }
}
