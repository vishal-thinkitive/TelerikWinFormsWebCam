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
            radWebCam1 = new Telerik.WinControls.UI.RadWebCam();
            ((System.ComponentModel.ISupportInitialize)radWebCam1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radWebCam1
            // 
            radWebCam1.Location = new System.Drawing.Point(127, 51);
            radWebCam1.Name = "radWebCam1";
            radWebCam1.Size = new System.Drawing.Size(746, 399);
            radWebCam1.TabIndex = 0;
            radWebCam1.Text = "radWebCam1";
            radWebCam1.SnapshotTaken += radWebCam1_SnapshotTaken;
            // 
            // RadForm1
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(979, 526);
            Controls.Add(radWebCam1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RadForm1";
            Text = "RadForm1";
            Load += RadForm1_Load;
            ((System.ComponentModel.ISupportInitialize)radWebCam1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadWebCam radWebCam1;
    }
}