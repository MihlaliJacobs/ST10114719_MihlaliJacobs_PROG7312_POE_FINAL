namespace ST10114719_MihlaliJacobs_POE_PART1
{
    partial class ServiceRequestStatus
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
            this.lblReportIssuesTitle = new System.Windows.Forms.Label();
            this.pbReportIssues = new System.Windows.Forms.PictureBox();
            this.bntStatusBack = new System.Windows.Forms.Button();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbServiceRequest = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportIssuesTitle
            // 
            this.lblReportIssuesTitle.AutoSize = true;
            this.lblReportIssuesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportIssuesTitle.Location = new System.Drawing.Point(354, 34);
            this.lblReportIssuesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportIssuesTitle.Name = "lblReportIssuesTitle";
            this.lblReportIssuesTitle.Size = new System.Drawing.Size(347, 36);
            this.lblReportIssuesTitle.TabIndex = 16;
            this.lblReportIssuesTitle.Text = "Service Request Status";
            // 
            // pbReportIssues
            // 
            this.pbReportIssues.BackColor = System.Drawing.Color.LightBlue;
            this.pbReportIssues.Image = global::ST10114719_MihlaliJacobs_POE_PART1.Properties.Resources.RequestIcon;
            this.pbReportIssues.Location = new System.Drawing.Point(2, 4);
            this.pbReportIssues.Margin = new System.Windows.Forms.Padding(4);
            this.pbReportIssues.Name = "pbReportIssues";
            this.pbReportIssues.Size = new System.Drawing.Size(119, 100);
            this.pbReportIssues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReportIssues.TabIndex = 19;
            this.pbReportIssues.TabStop = false;
            // 
            // bntStatusBack
            // 
            this.bntStatusBack.Location = new System.Drawing.Point(927, 13);
            this.bntStatusBack.Margin = new System.Windows.Forms.Padding(4);
            this.bntStatusBack.Name = "bntStatusBack";
            this.bntStatusBack.Size = new System.Drawing.Size(127, 54);
            this.bntStatusBack.TabIndex = 20;
            this.bntStatusBack.Text = "Back to main menu";
            this.bntStatusBack.UseVisualStyleBackColor = true;
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(377, 88);
            this.lblStatusDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(270, 16);
            this.lblStatusDesc.TabIndex = 21;
            this.lblStatusDesc.Text = "Find different events going on around the city";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbServiceRequest);
            this.panel1.Location = new System.Drawing.Point(16, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 544);
            this.panel1.TabIndex = 22;
            // 
            // lbServiceRequest
            // 
            this.lbServiceRequest.FormattingEnabled = true;
            this.lbServiceRequest.ItemHeight = 16;
            this.lbServiceRequest.Location = new System.Drawing.Point(343, 28);
            this.lbServiceRequest.Name = "lbServiceRequest";
            this.lbServiceRequest.Size = new System.Drawing.Size(438, 292);
            this.lbServiceRequest.TabIndex = 0;
            // 
            // ServiceRequestStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatusDesc);
            this.Controls.Add(this.bntStatusBack);
            this.Controls.Add(this.pbReportIssues);
            this.Controls.Add(this.lblReportIssuesTitle);
            this.Name = "ServiceRequestStatus";
            this.Text = "ServiceRequestStatus";
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportIssuesTitle;
        private System.Windows.Forms.PictureBox pbReportIssues;
        private System.Windows.Forms.Button bntStatusBack;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbServiceRequest;
    }
}