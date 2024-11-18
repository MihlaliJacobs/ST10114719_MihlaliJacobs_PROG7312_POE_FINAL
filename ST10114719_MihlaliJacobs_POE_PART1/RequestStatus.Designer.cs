namespace ST10114719_MihlaliJacobs_POE_PART1
{
    partial class RequestStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbServiceReq = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmitReq = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lbReqCategory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReqLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblNewService = new System.Windows.Forms.Label();
            this.btnDisplayRequests = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportIssuesTitle
            // 
            this.lblReportIssuesTitle.AutoSize = true;
            this.lblReportIssuesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportIssuesTitle.Location = new System.Drawing.Point(309, 23);
            this.lblReportIssuesTitle.Name = "lblReportIssuesTitle";
            this.lblReportIssuesTitle.Size = new System.Drawing.Size(284, 29);
            this.lblReportIssuesTitle.TabIndex = 1;
            this.lblReportIssuesTitle.Text = "Service Request Status";
            // 
            // pbReportIssues
            // 
            this.pbReportIssues.BackColor = System.Drawing.Color.LightBlue;
            this.pbReportIssues.Image = global::ST10114719_MihlaliJacobs_POE_PART1.Properties.Resources.RequestIcon;
            this.pbReportIssues.Location = new System.Drawing.Point(1, 2);
            this.pbReportIssues.Name = "pbReportIssues";
            this.pbReportIssues.Size = new System.Drawing.Size(89, 81);
            this.pbReportIssues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReportIssues.TabIndex = 15;
            this.pbReportIssues.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Here you can find an organized list of service requests ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(749, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back to main menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbServiceReq
            // 
            this.lbServiceReq.FormattingEnabled = true;
            this.lbServiceReq.Location = new System.Drawing.Point(25, 66);
            this.lbServiceReq.Margin = new System.Windows.Forms.Padding(2);
            this.lbServiceReq.Name = "lbServiceReq";
            this.lbServiceReq.Size = new System.Drawing.Size(347, 251);
            this.lbServiceReq.TabIndex = 18;
            this.lbServiceReq.SelectedIndexChanged += new System.EventHandler(this.lbServiceReq_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnSubmitReq);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lbReqCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtReqLocation);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblNewService);
            this.panel1.Location = new System.Drawing.Point(27, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 421);
            this.panel1.TabIndex = 19;
            // 
            // btnSubmitReq
            // 
            this.btnSubmitReq.Location = new System.Drawing.Point(163, 381);
            this.btnSubmitReq.Name = "btnSubmitReq";
            this.btnSubmitReq.Size = new System.Drawing.Size(102, 27);
            this.btnSubmitReq.TabIndex = 28;
            this.btnSubmitReq.Text = "Submit Request";
            this.btnSubmitReq.UseVisualStyleBackColor = true;
            this.btnSubmitReq.Click += new System.EventHandler(this.btnSubmitReq_Click_1);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(47, 247);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(119, 247);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 112);
            this.txtDescription.TabIndex = 26;
            this.txtDescription.Text = "";
            // 
            // lbReqCategory
            // 
            this.lbReqCategory.FormattingEnabled = true;
            this.lbReqCategory.Items.AddRange(new object[] {
            "Sanitation ",
            "Roads",
            "Utilities",
            "Education ",
            "Public Transportation ",
            "Government ",
            "Telecommunications ",
            "Public Security ",
            "Parks and recreation ",
            "Housing ",
            "Tourism",
            "Refuse Collection ",
            "Health Care "});
            this.lbReqCategory.Location = new System.Drawing.Point(119, 108);
            this.lbReqCategory.Name = "lbReqCategory";
            this.lbReqCategory.Size = new System.Drawing.Size(172, 121);
            this.lbReqCategory.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Category:";
            // 
            // txtReqLocation
            // 
            this.txtReqLocation.Location = new System.Drawing.Point(119, 63);
            this.txtReqLocation.Name = "txtReqLocation";
            this.txtReqLocation.Size = new System.Drawing.Size(172, 20);
            this.txtReqLocation.TabIndex = 22;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(47, 66);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "Location:";
            // 
            // lblNewService
            // 
            this.lblNewService.AutoSize = true;
            this.lblNewService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewService.Location = new System.Drawing.Point(115, 24);
            this.lblNewService.Name = "lblNewService";
            this.lblNewService.Size = new System.Drawing.Size(170, 20);
            this.lblNewService.TabIndex = 21;
            this.lblNewService.Text = "New service request";
            // 
            // btnDisplayRequests
            // 
            this.btnDisplayRequests.Location = new System.Drawing.Point(148, 361);
            this.btnDisplayRequests.Name = "btnDisplayRequests";
            this.btnDisplayRequests.Size = new System.Drawing.Size(102, 27);
            this.btnDisplayRequests.TabIndex = 20;
            this.btnDisplayRequests.Text = "Display requests";
            this.btnDisplayRequests.UseVisualStyleBackColor = true;
            this.btnDisplayRequests.Click += new System.EventHandler(this.btnDisplayRequests_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbServiceReq);
            this.panel2.Controls.Add(this.btnDisplayRequests);
            this.panel2.Location = new System.Drawing.Point(440, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 421);
            this.panel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "All service requests";
            // 
            // RequestStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(856, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbReportIssues);
            this.Controls.Add(this.lblReportIssuesTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RequestStatus";
            this.Text = "RequestStatus";
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportIssuesTitle;
        private System.Windows.Forms.PictureBox pbReportIssues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbServiceReq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisplayRequests;
        private System.Windows.Forms.Label lblNewService;
        private System.Windows.Forms.TextBox txtReqLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ListBox lbReqCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnSubmitReq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}