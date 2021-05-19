namespace ParkingTicketProblem
{
    partial class FrmParkingTicket
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
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.BtnDifferences = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(30, 23);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(101, 38);
            this.BtnDisplay.TabIndex = 0;
            this.BtnDisplay.Text = "Display 3D Array";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(156, 23);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(114, 38);
            this.BtnDouble.TabIndex = 1;
            this.BtnDouble.Text = "Double 1983 Violations";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // BtnDifferences
            // 
            this.BtnDifferences.Location = new System.Drawing.Point(307, 23);
            this.BtnDifferences.Name = "BtnDifferences";
            this.BtnDifferences.Size = new System.Drawing.Size(114, 38);
            this.BtnDifferences.TabIndex = 2;
            this.BtnDifferences.Text = "Violation Differences 83-82";
            this.BtnDifferences.UseVisualStyleBackColor = true;
            this.BtnDifferences.Click += new System.EventHandler(this.BtnDifferences_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(32, 90);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(388, 354);
            this.TxtDisplay.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(183, 474);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(77, 24);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmParkingTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 517);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnDifferences);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtnDisplay);
            this.Name = "FrmParkingTicket";
            this.Text = "Parking Ticket Problem";
            this.Load += new System.EventHandler(this.FrmParkingTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.Button BtnDifferences;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnExit;
    }
}

