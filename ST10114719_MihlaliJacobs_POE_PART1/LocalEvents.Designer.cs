namespace ST10114719_MihlaliJacobs_POE_PART1
{
    partial class LocalEventsAnnouncement
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReportIssuesTitle = new System.Windows.Forms.Label();
            this.pbReportIssues = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboEvents = new System.Windows.Forms.ComboBox();
            this.lblEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.scrollablePanel = new System.Windows.Forms.Panel();
            this.panelAnnouncements = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAnnouncement = new System.Windows.Forms.ComboBox();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.listBoxAnnouncements = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).BeginInit();
            this.panel1.SuspendLayout();
            this.scrollablePanel.SuspendLayout();
            this.panelAnnouncements.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back to main menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Find different events going on around the city";
            // 
            // lblReportIssuesTitle
            // 
            this.lblReportIssuesTitle.AutoSize = true;
            this.lblReportIssuesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportIssuesTitle.Location = new System.Drawing.Point(226, 26);
            this.lblReportIssuesTitle.Name = "lblReportIssuesTitle";
            this.lblReportIssuesTitle.Size = new System.Drawing.Size(403, 29);
            this.lblReportIssuesTitle.TabIndex = 15;
            this.lblReportIssuesTitle.Text = "Local Events and Announcements";
            // 
            // pbReportIssues
            // 
            this.pbReportIssues.BackColor = System.Drawing.Color.LightBlue;
            this.pbReportIssues.Image = global::ST10114719_MihlaliJacobs_POE_PART1.Properties.Resources.AnnouncementIcon;
            this.pbReportIssues.Location = new System.Drawing.Point(9, 5);
            this.pbReportIssues.Name = "pbReportIssues";
            this.pbReportIssues.Size = new System.Drawing.Size(89, 81);
            this.pbReportIssues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReportIssues.TabIndex = 18;
            this.pbReportIssues.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.comboEvents);
            this.panel1.Controls.Add(this.lblEvents);
            this.panel1.Controls.Add(this.listBoxEvents);
            this.panel1.Location = new System.Drawing.Point(22, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 441);
            this.panel1.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(88, 63);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Category:";
            // 
            // comboEvents
            // 
            this.comboEvents.FormattingEnabled = true;
            this.comboEvents.Location = new System.Drawing.Point(146, 60);
            this.comboEvents.Name = "comboEvents";
            this.comboEvents.Size = new System.Drawing.Size(115, 21);
            this.comboEvents.TabIndex = 23;
            this.comboEvents.SelectedIndexChanged += new System.EventHandler(this.comboEvents_SelectedIndexChanged);
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(141, 9);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(91, 29);
            this.lblEvents.TabIndex = 20;
            this.lblEvents.Text = "Events";
            this.lblEvents.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(22, 113);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(329, 290);
            this.listBoxEvents.TabIndex = 19;
            // 
            // scrollablePanel
            // 
            this.scrollablePanel.Controls.Add(this.panelAnnouncements);
            this.scrollablePanel.Controls.Add(this.panel1);
            this.scrollablePanel.Location = new System.Drawing.Point(0, 92);
            this.scrollablePanel.Name = "scrollablePanel";
            this.scrollablePanel.Size = new System.Drawing.Size(797, 499);
            this.scrollablePanel.TabIndex = 20;
            // 
            // panelAnnouncements
            // 
            this.panelAnnouncements.BackColor = System.Drawing.Color.LightBlue;
            this.panelAnnouncements.Controls.Add(this.label3);
            this.panelAnnouncements.Controls.Add(this.comboAnnouncement);
            this.panelAnnouncements.Controls.Add(this.lblAnnouncements);
            this.panelAnnouncements.Controls.Add(this.listBoxAnnouncements);
            this.panelAnnouncements.Location = new System.Drawing.Point(401, 18);
            this.panelAnnouncements.Name = "panelAnnouncements";
            this.panelAnnouncements.Size = new System.Drawing.Size(373, 441);
            this.panelAnnouncements.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Category:";
            // 
            // comboAnnouncement
            // 
            this.comboAnnouncement.FormattingEnabled = true;
            this.comboAnnouncement.Location = new System.Drawing.Point(148, 60);
            this.comboAnnouncement.Name = "comboAnnouncement";
            this.comboAnnouncement.Size = new System.Drawing.Size(115, 21);
            this.comboAnnouncement.TabIndex = 23;
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.Location = new System.Drawing.Point(92, 9);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(198, 29);
            this.lblAnnouncements.TabIndex = 20;
            this.lblAnnouncements.Text = "Announcements";
            // 
            // listBoxAnnouncements
            // 
            this.listBoxAnnouncements.FormattingEnabled = true;
            this.listBoxAnnouncements.Location = new System.Drawing.Point(22, 113);
            this.listBoxAnnouncements.Name = "listBoxAnnouncements";
            this.listBoxAnnouncements.Size = new System.Drawing.Size(329, 290);
            this.listBoxAnnouncements.TabIndex = 19;
            // 
            // LocalEventsAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.scrollablePanel);
            this.Controls.Add(this.pbReportIssues);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReportIssuesTitle);
            this.Name = "LocalEventsAnnouncement";
            this.Text = "LocalEventsAndAnnouncememnts";
            ((System.ComponentModel.ISupportInitialize)(this.pbReportIssues)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.scrollablePanel.ResumeLayout(false);
            this.panelAnnouncements.ResumeLayout(false);
            this.panelAnnouncements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReportIssues;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReportIssuesTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboEvents;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Panel scrollablePanel;
        private System.Windows.Forms.Panel panelAnnouncements;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboAnnouncement;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.ListBox listBoxAnnouncements;
    }
}