namespace FaceRec
{
    partial class FaceRec
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
            this.CamInput = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CameraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraStartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraPauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayStartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetectionFaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CamInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CamInput
            // 
            this.CamInput.Location = new System.Drawing.Point(12, 71);
            this.CamInput.Name = "CamInput";
            this.CamInput.Size = new System.Drawing.Size(1155, 400);
            this.CamInput.TabIndex = 0;
            this.CamInput.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CameraMenuItem,
            this.displayToolStripMenuItem,
            this.DetectionFaceMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CameraMenuItem
            // 
            this.CameraMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CameraStartMenuItem,
            this.CameraStopMenuItem,
            this.CameraPauseMenuItem});
            this.CameraMenuItem.Name = "CameraMenuItem";
            this.CameraMenuItem.Size = new System.Drawing.Size(88, 29);
            this.CameraMenuItem.Text = "Camera";
            // 
            // CameraStartMenuItem
            // 
            this.CameraStartMenuItem.Name = "CameraStartMenuItem";
            this.CameraStartMenuItem.Size = new System.Drawing.Size(159, 34);
            this.CameraStartMenuItem.Text = "Start";
            this.CameraStartMenuItem.Click += new System.EventHandler(this.CameraStartMenuItem_Click);
            // 
            // CameraStopMenuItem
            // 
            this.CameraStopMenuItem.Name = "CameraStopMenuItem";
            this.CameraStopMenuItem.Size = new System.Drawing.Size(159, 34);
            this.CameraStopMenuItem.Text = "Stop";
            this.CameraStopMenuItem.Click += new System.EventHandler(this.CameraStopMenuItem_Click);
            // 
            // CameraPauseMenuItem
            // 
            this.CameraPauseMenuItem.Name = "CameraPauseMenuItem";
            this.CameraPauseMenuItem.Size = new System.Drawing.Size(159, 34);
            this.CameraPauseMenuItem.Text = "Pause";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayStartMenuItem,
            this.DisplayStopMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // DisplayStartMenuItem
            // 
            this.DisplayStartMenuItem.Name = "DisplayStartMenuItem";
            this.DisplayStartMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DisplayStartMenuItem.Text = "Start";
            this.DisplayStartMenuItem.Click += new System.EventHandler(this.DisplayStartMenuItem_Click);
            // 
            // DisplayStopMenuItem
            // 
            this.DisplayStopMenuItem.Name = "DisplayStopMenuItem";
            this.DisplayStopMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DisplayStopMenuItem.Text = "Stop";
            this.DisplayStopMenuItem.Click += new System.EventHandler(this.DisplayStopMenuItem_Click);
            // 
            // DetectionFaceMenuItem
            // 
            this.DetectionFaceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem2,
            this.stopToolStripMenuItem2,
            this.lowerBodyToolStripMenuItem,
            this.eyesToolStripMenuItem,
            this.smileToolStripMenuItem});
            this.DetectionFaceMenuItem.Name = "DetectionFaceMenuItem";
            this.DetectionFaceMenuItem.Size = new System.Drawing.Size(104, 29);
            this.DetectionFaceMenuItem.Text = "Detection";
            // 
            // startToolStripMenuItem2
            // 
            this.startToolStripMenuItem2.Name = "startToolStripMenuItem2";
            this.startToolStripMenuItem2.Size = new System.Drawing.Size(208, 34);
            this.startToolStripMenuItem2.Text = "Face";
            this.startToolStripMenuItem2.Click += new System.EventHandler(this.startToolStripMenuItem2_Click);
            // 
            // stopToolStripMenuItem2
            // 
            this.stopToolStripMenuItem2.Name = "stopToolStripMenuItem2";
            this.stopToolStripMenuItem2.Size = new System.Drawing.Size(208, 34);
            this.stopToolStripMenuItem2.Text = "Body";
            // 
            // lowerBodyToolStripMenuItem
            // 
            this.lowerBodyToolStripMenuItem.Name = "lowerBodyToolStripMenuItem";
            this.lowerBodyToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.lowerBodyToolStripMenuItem.Text = "Lower body";
            // 
            // eyesToolStripMenuItem
            // 
            this.eyesToolStripMenuItem.Name = "eyesToolStripMenuItem";
            this.eyesToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.eyesToolStripMenuItem.Text = "Eyes";
            // 
            // smileToolStripMenuItem
            // 
            this.smileToolStripMenuItem.Name = "smileToolStripMenuItem";
            this.smileToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.smileToolStripMenuItem.Text = "Smile";
            // 
            // FaceRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 723);
            this.Controls.Add(this.CamInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FaceRec";
            this.Text = "FaceRec";
            ((System.ComponentModel.ISupportInitialize)(this.CamInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CamInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CameraMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CameraStartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CameraStopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CameraPauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayStartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayStopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetectionFaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem lowerBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eyesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smileToolStripMenuItem;
    }
}

