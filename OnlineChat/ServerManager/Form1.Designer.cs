
namespace ServerManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStartSite = new System.Windows.Forms.Button();
            this.btnStartSignalR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(54, 34);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStartSite
            // 
            this.btnStartSite.Location = new System.Drawing.Point(173, 34);
            this.btnStartSite.Name = "btnStartSite";
            this.btnStartSite.Size = new System.Drawing.Size(75, 23);
            this.btnStartSite.TabIndex = 1;
            this.btnStartSite.Text = "Start Chat";
            this.btnStartSite.UseVisualStyleBackColor = true;
            this.btnStartSite.Click += new System.EventHandler(this.btnStartSite_Click);
            // 
            // btnStartSignalR
            // 
            this.btnStartSignalR.Location = new System.Drawing.Point(306, 34);
            this.btnStartSignalR.Name = "btnStartSignalR";
            this.btnStartSignalR.Size = new System.Drawing.Size(110, 23);
            this.btnStartSignalR.TabIndex = 2;
            this.btnStartSignalR.Text = "Start SignalR";
            this.btnStartSignalR.UseVisualStyleBackColor = true;
            this.btnStartSignalR.Click += new System.EventHandler(this.btnStartSignalR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 401);
            this.Controls.Add(this.btnStartSignalR);
            this.Controls.Add(this.btnStartSite);
            this.Controls.Add(this.btnStartServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStartSite;
        private System.Windows.Forms.Button btnStartSignalR;
    }
}

