namespace PrintToSend
{
    partial class Main
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
            this.lstBxConnections = new System.Windows.Forms.ListBox();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.btnGetConnections = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxConnections
            // 
            this.lstBxConnections.FormattingEnabled = true;
            this.lstBxConnections.ItemHeight = 20;
            this.lstBxConnections.Location = new System.Drawing.Point(213, 42);
            this.lstBxConnections.Name = "lstBxConnections";
            this.lstBxConnections.Size = new System.Drawing.Size(545, 284);
            this.lstBxConnections.TabIndex = 0;
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(28, 166);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(159, 67);
            this.btnGetUsers.TabIndex = 2;
            this.btnGetUsers.Text = "Get Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.btnGetUsers_Click);
            // 
            // btnGetConnections
            // 
            this.btnGetConnections.Location = new System.Drawing.Point(28, 42);
            this.btnGetConnections.Name = "btnGetConnections";
            this.btnGetConnections.Size = new System.Drawing.Size(159, 67);
            this.btnGetConnections.TabIndex = 1;
            this.btnGetConnections.Text = "Get Connections";
            this.btnGetConnections.UseVisualStyleBackColor = true;
            this.btnGetConnections.Click += new System.EventHandler(this.btnGetConnections_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(28, 293);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(159, 67);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnGetUsers);
            this.Controls.Add(this.btnGetConnections);
            this.Controls.Add(this.lstBxConnections);
            this.Name = "Main";
            this.Text = "PrintToSend";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxConnections;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.Button btnGetConnections;
        private System.Windows.Forms.Button btnSend;
    }
}

