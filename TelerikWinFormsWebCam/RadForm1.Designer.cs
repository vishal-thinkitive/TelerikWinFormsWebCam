namespace TelerikWinFormsWebCam
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            radWebCam1 = new Telerik.WinControls.UI.RadWebCam();
            startCameraButton = new Telerik.WinControls.UI.RadButton();
            stopCameraButton = new Telerik.WinControls.UI.RadButton();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)radWebCam1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startCameraButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stopCameraButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radWebCam1
            // 
            radWebCam1.AutoStart = false;
            radWebCam1.Location = new System.Drawing.Point(127, 51);
            radWebCam1.Name = "radWebCam1";
            radWebCam1.Size = new System.Drawing.Size(746, 399);
            radWebCam1.TabIndex = 0;
            radWebCam1.Text = "radWebCam1";
            radWebCam1.SnapshotTaken += radWebCam1_SnapshotTaken;
            // 
            // startCameraButton
            // 
            startCameraButton.Location = new System.Drawing.Point(231, 467);
            startCameraButton.Name = "startCameraButton";
            startCameraButton.Size = new System.Drawing.Size(110, 24);
            startCameraButton.TabIndex = 1;
            startCameraButton.Text = "StartCamera";
            startCameraButton.Click += startCameraButton_Click;
            // 
            // stopCameraButton
            // 
            stopCameraButton.Location = new System.Drawing.Point(231, 506);
            stopCameraButton.Name = "stopCameraButton";
            stopCameraButton.Size = new System.Drawing.Size(110, 24);
            stopCameraButton.TabIndex = 2;
            stopCameraButton.Text = "StopCamera";
            stopCameraButton.Click += stopCameraButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RadForm1
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(979, 559);
            Controls.Add(stopCameraButton);
            Controls.Add(startCameraButton);
            Controls.Add(radWebCam1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RadForm1";
            Text = "RadForm1";
            Load += RadForm1_Load;
            ((System.ComponentModel.ISupportInitialize)radWebCam1).EndInit();
            ((System.ComponentModel.ISupportInitialize)startCameraButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)stopCameraButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadWebCam radWebCam1;
        private Telerik.WinControls.UI.RadButton startCameraButton;
        private Telerik.WinControls.UI.RadButton stopCameraButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}