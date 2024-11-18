using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ST10114719_MihlaliJacobs_POE_PART1
{
    public partial class RequestStatus : Form
    {
        private BinaryTree<ServiceRequest> serviceRequestTree;
        private List<ServiceRequest> serviceRequests;
        private PriorityQueue<ServiceRequest> serviceRequestQueue;

        public RequestStatus()
        {
            InitializeComponent();

            // Initialize components
            serviceRequestQueue = new PriorityQueue<ServiceRequest>();
            serviceRequestTree = new BinaryTree<ServiceRequest>();
            serviceRequests = new List<ServiceRequest>();

            // Populate the priority queue with initial requests
            serviceRequestQueue.Insert(new ServiceRequest("Downtown", "Road Repair", "Fix pothole on Main Street.", "Pending", 3));
            serviceRequestQueue.Insert(new ServiceRequest("Seaside", "Waste Management", "Clear overflowing bins.", "Pending", 2));
            serviceRequestQueue.Insert(new ServiceRequest("Hilltop", "Street Lighting", "Fix broken lights.", "Processing", 1));
        }

        /// Populates the binary tree with service requests.
        private void PopulateTree()
        {
            foreach (var request in serviceRequests)
            {
                serviceRequestTree.Insert(request);
            }
        }

        /// Displays service requests in priority order.
        private void btnDisplayRequests_Click(object sender, EventArgs e)
        {
            lbServiceReq.Items.Clear();

            var tempQueue = new PriorityQueue<ServiceRequest>();
            while (serviceRequestQueue.Count > 0)
            {
                var request = serviceRequestQueue.ExtractMax();
                lbServiceReq.Items.Add($"Location: {request.Location}, Category: {request.Category}, Priority Level: {request.PriorityLevel}");
                tempQueue.Insert(request);
            }

            serviceRequestQueue = tempQueue;
        }

        /// Navigate back to the main form.
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        /// Submits a new service request.
        private void btnSubmitReq_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReqLocation.Text))
            {
                MessageBox.Show("Please enter a location.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lbReqCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new service request
            string location = txtReqLocation.Text;
            string category = lbReqCategory.SelectedItem.ToString();
            string description = txtDescription.Text;

            var newRequest = new ServiceRequest(location, category, description, "Pending", 1);

            serviceRequests.Add(newRequest);
            serviceRequestTree.Insert(newRequest);
            serviceRequestQueue.Insert(newRequest);

            txtReqLocation.Clear();
            txtDescription.Clear();
            lbReqCategory.ClearSelected();

            MessageBox.Show("Service request added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// Displays details of a selected service request.
        private void lbServiceReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbServiceReq.SelectedItems.Count > 0) // Ensure at least one item is selected
            {
                foreach (var selectedItem in lbServiceReq.SelectedItems)
                {
                    // Find the corresponding ServiceRequest from the list
                    var selectedRequest = serviceRequests.FirstOrDefault(req =>
                        selectedItem.ToString().Contains($"Location: {req.Location}") &&
                        selectedItem.ToString().Contains($"Category: {req.Category}") &&
                        selectedItem.ToString().Contains($"Priority Level: {req.PriorityLevel}"));

                    if (selectedRequest != null)
                    {
                        // Display the details of the selected service request
                        MessageBox.Show(
                            $"Details:\n\n" +
                            $"Location: {selectedRequest.Location}\n" +
                            $"Category: {selectedRequest.Category}\n" +
                            $"Description: {selectedRequest.Description}\n" +
                            $"Status: {selectedRequest.Status}\n" +
                            $"Priority Level: {selectedRequest.PriorityLevel}",
                            "Service Request Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
        }
    }

    /// Represents a node in a binary tree.
    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    /// Binary tree implementation.
    public class BinaryTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> root;

        public void Insert(T data)
        {
            root = Insert(root, data);
        }

        private BinaryTreeNode<T> Insert(BinaryTreeNode<T> node, T data)
        {
            if (node == null)
            {
                return new BinaryTreeNode<T>(data);
            }
            if (data.CompareTo(node.Data) < 0)
            {
                node.Left = Insert(node.Left, data);
            }
            else if (data.CompareTo(node.Data) > 0)
            {
                node.Right = Insert(node.Right, data);
            }
            return node;
        }
    }

    /// Represents a service request.
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int PriorityLevel { get; set; }

        public ServiceRequest(string location, string category, string description, string status = "Pending", int priorityLevel = 1)
        {
            Location = location;
            Category = category;
            Description = description;
            Status = status;
            PriorityLevel = priorityLevel;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Status: {Status}";
        }

        public int CompareTo(ServiceRequest other)
        {
            return other.PriorityLevel.CompareTo(PriorityLevel);
        }
    }

    /// Priority queue implementation.
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> heap;

        public PriorityQueue()
        {
            heap = new List<T>();
        }

        public void Insert(T item)
        {
            heap.Add(item);
            HeapifyUp(heap.Count - 1);
        }

        public T ExtractMax()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty.");

            T max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return max;
        }

        public int Count => heap.Count;

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index].CompareTo(heap[parentIndex]) <= 0) break;

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = heap.Count - 1;

            while (true)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;
                int largest = index;

                if (leftChildIndex <= lastIndex && heap[leftChildIndex].CompareTo(heap[largest]) > 0)
                    largest = leftChildIndex;

                if (rightChildIndex <= lastIndex && heap[rightChildIndex].CompareTo(heap[largest]) > 0)
                    largest = rightChildIndex;

                if (largest == index) break;

                Swap(index, largest);
                index = largest;
            }
        }

        private void Swap(int i, int j)
        {
            T temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}



