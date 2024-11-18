using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10114719_MihlaliJacobs_POE_PART1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		//changing pages
		private void lblReportIssues_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();

            MessageBox.Show("Welcome to the report page \n------------------------------------- \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
            MessageBox.Show("Welcome to the report page \n------------------------------------- \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
        }

        private void lblEventsAndAnnouncements_Click(object sender, EventArgs e)
		{
            LocalEventsAnnouncement localEventsForm = new LocalEventsAnnouncement();
            localEventsForm.Show();
            this.Hide();
            MessageBox.Show("Welcome to the Events and Announcements page.  \n-------------------------------------------------------------------------------\nStay informed about local events and important updates in your community. Use the filters to explore categories and receive recommendations based on your interests.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbEventsAnnouncements_Click(object sender, EventArgs e)
		{
            LocalEventsAnnouncement localEventsForm = new LocalEventsAnnouncement();
            localEventsForm.Show();
            this.Hide();
            MessageBox.Show("Welcome to the Events and Announcements page.  \n-------------------------------------------------------------------------------\nStay informed about local events and important updates in your community. Use the filters to explore categories and receive recommendations based on your interests.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbServiceReqStatus_Click(object sender, EventArgs e)
        {
            // Create a new instance of RequestStatus with an empty list or an existing list of service requests
            RequestStatus requestStatusForm = new RequestStatus();
            requestStatusForm.Show();
            this.Hide();
            MessageBox.Show("Welcome to the service request status page.  \n-------------------------------------------------------------------------------\nStay updated with all of your service requests sent to our offices. On this page you will be provided with all the details included in your issue reports. You will also be provided with the status of all requests indicating how far along they have been processed ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
		{

        }

       


		private void lblReportDesc_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
            MessageBox.Show("Welcome to the report page \n------------------------------------------------ \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
    }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

            MessageBox.Show("Welcome to the report page \n------------------------------------- \nThis is where you can file reports on any municipal issues that you have discovered in your city. On this page you are given fields to enter the location, category, description and any supporting media. Once you have completed filling out the form select the submit button to finalise and send your report so that it can be reviewed and attended to. \n\nPress OK to continue");
    }


        private void lblServiceReqStatus_Click(object sender, EventArgs e)
        {
      
        }


        private void panel2_Click(object sender, EventArgs e)
        {
            LocalEventsAnnouncement localEventsForm = new LocalEventsAnnouncement();
            localEventsForm.Show();
            this.Hide();
            MessageBox.Show("Welcome to the events and announcements page \n----------------------------------------------------------------\n This is where you can view all ongoing and future events that happen in Cape Town. Here you are given details concerning dates, location and a description of what the events are about. \n\nPress OK to continue");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LocalEventsAnnouncement localEventsForm = new LocalEventsAnnouncement();
            localEventsForm.Show();
            this.Hide();
            MessageBox.Show("Welcome to the events and announcements page \n-----------------------------------------\n This is where you can view all ongoing and future events that happen in Cape Town. Here you are given details concerning dates, location and a description of what the events are about. \n\nPress OK to continue");
        
    }
    }
    }

