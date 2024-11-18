namespace ST10114719_MihlaliJacobs_POE_PART1
{
	partial class Form2
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.listCategory = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.pbReportIssues = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportIssuesTitle
            // 
            this.lblReportIssuesTitle.AutoSize = true;
            this.lblReportIssuesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportIssuesTitle.Location = new System.Drawing.Point(320, 27);
            this.lblReportIssuesTitle.Name = "lblReportIssuesTitle";
            this.lblReportIssuesTitle.Size = new System.Drawing.Size(174, 29);
            this.lblReportIssuesTitle.TabIndex = 0;
            this.lblReportIssuesTitle.Text = "Report Issues";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(169, 52);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(172, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // listCategory
            // 
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Items.AddRange(new object[] {
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
            this.listCategory.Location = new System.Drawing.Point(169, 103);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(172, 121);
            this.listCategory.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(456, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 184);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Upload Media/Document";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please fill out the required information to submit a report:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(97, 55);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Media Attatchment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description:";
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.Location = new System.Drawing.Point(512, 289);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(123, 42);
            this.btnSubmitReport.TabIndex = 11;
            this.btnSubmitReport.Text = "Submit Report";
            this.btnSubmitReport.UseVisualStyleBackColor = true;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.btnSubmitReport);
            this.panel1.Controls.Add(this.listCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 345);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Reporting Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(322, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 30);
            this.progressBar1.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(166, 252);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 34);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(Media/Document)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back to main menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbReportIssues
            // 
            this.pbReportIssues.BackColor = System.Drawing.Color.LightBlue;
            this.pbReportIssues.Image = global::ST10114719_MihlaliJacobs_POE_PART1.Properties.Resources.ReportIssuesIcon;
            this.pbReportIssues.Location = new System.Drawing.Point(12, 6);
            this.pbReportIssues.Name = "pbReportIssues";
            this.pbReportIssues.Size = new System.Drawing.Size(89, 81);
            this.pbReportIssues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReportIssues.TabIndex = 14;
            this.pbReportIssues.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbReportIssues);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReportIssuesTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblReportIssuesTitle;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.ListBox listCategory;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbReportIssues;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
    }
}