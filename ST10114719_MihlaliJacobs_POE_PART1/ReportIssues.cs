using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10114719_MihlaliJacobs_POE_PART1
{
    public partial class Form2 : Form
    {
        // Track how many fields are filled
        int fieldsFilled = 0;
        int totalFields = 3;

        // List to store service requests
        private List<ServiceRequest> serviceRequests = new List<ServiceRequest>();

        public Form2()
        {
            InitializeComponent();

            // Initialize ProgressBar 
            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalFields;
            progressBar1.Value = 0;

            // Attach event handlers for progress tracking
            txtLocation.TextChanged += new EventHandler(InputField_TextChanged);
            listCategory.SelectedIndexChanged += new EventHandler(InputField_TextChanged);
            txtDescription.TextChanged += new EventHandler(InputField_TextChanged);

            // Initialize dummy data
            InitializeDummyData();
        }

        private void InitializeDummyData()
        {
            // Add dummy service requests to the list
            serviceRequests.Add(new ServiceRequest("Location 1", "Category 1", "Description of service request 1", "processing"));
            serviceRequests.Add(new ServiceRequest("Location 2", "Category 2", "Description of service request 2", "processed"));
            serviceRequests.Add(new ServiceRequest("Location 3", "Category 3", "Description of service request 3", "unprocessed"));
            serviceRequests.Add(new ServiceRequest("Location 4", "Category 4", "Description of service request 4",  "umprocessed"));
            serviceRequests.Add(new ServiceRequest("Location 5", "Category 5", "Description of service request 5", "processing" ));
        }

        private void InputField_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            fieldsFilled = 0;

            if (!string.IsNullOrEmpty(txtLocation.Text)) fieldsFilled++;
            if (listCategory.SelectedIndex >= 0) fieldsFilled++;
            if (!string.IsNullOrEmpty(txtDescription.Text)) fieldsFilled++;

            // Update the progress bar value
            progressBar1.Value = fieldsFilled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Coding to let user upload images
            string fileLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files|*.*|Document Files|*.DOCX;*.DOC;*.PDF;*.TXT|All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = dialog.FileName;

                    linkLabel1.Text = fileLocation;
                    linkLabel1.Links.Clear();
                    linkLabel1.Links.Add(0, fileLocation.Length, fileLocation);
                    linkLabel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("No document selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            // Create a new service request from the form inputs
            ServiceRequest newRequest = new ServiceRequest(
                txtLocation.Text,
                listCategory.Text,
                txtDescription.Text,
                "Pending"
              
            );

            // Add it to the service requests list
            serviceRequests.Add(newRequest);

            // Display the report summary
            MessageBox.Show($"Report Summary:\n------------------------------" +
                            $"\n\nLocation: {newRequest.Location}" +
                            $"\n\nCategory: {newRequest.Category}" +
                            $"\n\nDescription: {newRequest.Description}");

            // Reset input fields and progress bar
            ResetForm();
        }

        private void ResetForm()
        {
            txtLocation.Text = "";
            txtDescription.Text = "";
            linkLabel1.Text = "(Media/Document)";
            listCategory.SelectedIndex = -1;
            progressBar1.Value = 0;
        }

        private void btnViewRequests_Click(object sender, EventArgs e)
        {
            
        }
    }   
}

