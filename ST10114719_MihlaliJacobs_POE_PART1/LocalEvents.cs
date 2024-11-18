using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ST10114719_MihlaliJacobs_POE_PART1
{
    public partial class LocalEventsAnnouncement : Form
    {
        private Dictionary<int, Event> eventsDictionary;
        private Stack<Announcement> announcementStack;

        public class Event
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
        }

        public class Announcement
        {
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
        }

        public LocalEventsAnnouncement()
        {
            InitializeComponent();



            // Creating and adding to the announcements stack 
            announcementStack = new Stack<Announcement>();

            announcementStack.Push(new Announcement { Title = "Water Service Maintenance", Date = DateTime.Now.AddDays(3), Description = "Scheduled maintenance for water services in central areas.", Category = "Utilities" });
            announcementStack.Push(new Announcement { Title = "Electricity Outage", Date = DateTime.Now.AddDays(1), Description = "Power outage scheduled for maintenance in East Town on Friday.", Category = "Utilities" });
            announcementStack.Push(new Announcement { Title = "Gas Line Inspections", Date = DateTime.Now.AddDays(6), Description = "Gas line inspections will be conducted in the West Side district.", Category = "Utilities" });
            // Environment category
            announcementStack.Push(new Announcement { Title = "New Recycling Program", Date = DateTime.Now.AddDays(7), Description = "A new recycling program is launching in all neighborhoods.", Category = "Environment" });
            announcementStack.Push(new Announcement { Title = "Tree Planting Initiative", Date = DateTime.Now.AddDays(12), Description = "Join the city-wide tree planting initiative to improve air quality.", Category = "Environment" });
            announcementStack.Push(new Announcement { Title = "River Cleanup", Date = DateTime.Now.AddDays(4), Description = "Volunteers needed for a river cleanup event at Riverside Park.", Category = "Environment" });
            // Public Services category
            announcementStack.Push(new Announcement { Title = "Library Renovation", Date = DateTime.Now.AddDays(10), Description = "The main library will be closed for renovations starting next month.", Category = "Public Services" });
            announcementStack.Push(new Announcement { Title = "New Bus Routes", Date = DateTime.Now.AddDays(5), Description = "Several new bus routes will be added to improve public transportation access.", Category = "Public Services" });
            announcementStack.Push(new Announcement { Title = "City Hall Office Hours Change", Date = DateTime.Now.AddDays(2), Description = "City Hall will have new office hours starting next week.", Category = "Public Services" });
            // Community category
            announcementStack.Push(new Announcement { Title = "Community Garden Event", Date = DateTime.Now.AddDays(5), Description = "Join us for a community planting event at the local garden.", Category = "Community" });
            announcementStack.Push(new Announcement { Title = "Neighborhood Watch Meeting", Date = DateTime.Now.AddDays(3), Description = "Attend the neighborhood watch meeting to discuss community safety.", Category = "Community" });
            announcementStack.Push(new Announcement { Title = "Volunteer Drive", Date = DateTime.Now.AddDays(7), Description = "Sign up for volunteer opportunities in your community.", Category = "Community" });
            // Infrastructure category
            announcementStack.Push(new Announcement { Title = "Street Repairs", Date = DateTime.Now.AddDays(6), Description = "Road construction will cause delays on Main Street for the next two weeks.", Category = "Infrastructure" });
            announcementStack.Push(new Announcement { Title = "New Bike Lanes", Date = DateTime.Now.AddDays(8), Description = "New bike lanes are being installed throughout the downtown area.", Category = "Infrastructure" });
            announcementStack.Push(new Announcement { Title = "Bridge Inspection", Date = DateTime.Now.AddDays(14), Description = "The city will conduct bridge inspections starting next Monday.", Category = "Infrastructure" });
            // Recreation category
            announcementStack.Push(new Announcement { Title = "City Park Expansion", Date = DateTime.Now.AddDays(15), Description = "The City Park will be expanding to include new playgrounds and sports fields.", Category = "Recreation" });
            announcementStack.Push(new Announcement { Title = "Summer Sports League Registration", Date = DateTime.Now.AddDays(9), Description = "Sign up for the summer sports league at the Community Recreation Center.", Category = "Recreation" });
            announcementStack.Push(new Announcement { Title = "Outdoor Fitness Class", Date = DateTime.Now.AddDays(4), Description = "Free outdoor fitness classes will be held at Central Park every Saturday.", Category = "Recreation" });
            // Public Safety category
            announcementStack.Push(new Announcement { Title = "Public Safety Seminar", Date = DateTime.Now.AddDays(2), Description = "Learn about safety tips at the local community center next Monday.", Category = "Public Safety" });
            announcementStack.Push(new Announcement { Title = "Fire Safety Awareness Week", Date = DateTime.Now.AddDays(10), Description = "Participate in Fire Safety Awareness Week to learn about fire prevention.", Category = "Public Safety" });
            announcementStack.Push(new Announcement { Title = "Emergency Preparedness Workshop", Date = DateTime.Now.AddDays(12), Description = "Join our workshop on how to prepare for emergencies and natural disasters.", Category = "Public Safety" });
            // Health category
            announcementStack.Push(new Announcement { Title = "Free Health Screenings", Date = DateTime.Now.AddDays(9), Description = "Free health screenings will be available at the community clinic on Wednesday.", Category = "Health" });
            announcementStack.Push(new Announcement { Title = "Blood Donation Drive", Date = DateTime.Now.AddDays(5), Description = "Help save lives by donating blood at the community center.", Category = "Health" });
            announcementStack.Push(new Announcement { Title = "Mental Health Awareness Week", Date = DateTime.Now.AddDays(8), Description = "Join us in raising awareness about mental health with various workshops and activities.", Category = "Health" });

            // Creating and adding events to the events dictionary
            eventsDictionary = new Dictionary<int, Event>();

            // Community category
            eventsDictionary.Add(1, new Event
            {
                Id = 1,
                Name = "Community Cleanup Day",
                Date = DateTime.Now.AddDays(7),
                Location = "Central Park",
                Category = "Community",
                Description = "Join your neighbors for a cleanup event in Central Park to beautify the area by picking up litter and planting flowers."
            });
            eventsDictionary.Add(2, new Event
            {
                Id = 2,
                Name = "Farmers' Market",
                Date = DateTime.Now.AddDays(2),
                Location = "Town Square",
                Category = "Community",
                Description = "Support local farmers and artisans by visiting the town’s bustling Farmers' Market with fresh produce and handmade goods."
            });
            eventsDictionary.Add(3, new Event
            {
                Id = 3,
                Name = "Charity Fun Run",
                Date = DateTime.Now.AddDays(14),
                Location = "Main Street",
                Category = "Community",
                Description = "Participate in the annual Charity Fun Run and help raise funds for local causes while enjoying a day of fitness and fun."
            });
            // Government category
            eventsDictionary.Add(4, new Event
            {
                Id = 4,
                Name = "Municipal Town Hall Meeting",
                Date = DateTime.Now.AddDays(15),
                Location = "City Hall",
                Category = "Government",
                Description = "The town council invites residents to discuss key community issues including public safety and new development projects."
            });
            eventsDictionary.Add(5, new Event
            {
                Id = 5,
                Name = "Budget Planning Workshop",
                Date = DateTime.Now.AddDays(22),
                Location = "Library",
                Category = "Government",
                Description = "Learn about the city's budgeting process and participate in discussions about resource allocation for upcoming projects."
            });
            eventsDictionary.Add(6, new Event
            {
                Id = 6,
                Name = "Public Policy Forum",
                Date = DateTime.Now.AddDays(30),
                Location = "Conference Center",
                Category = "Government",
                Description = "Join experts and residents in discussing the latest policy proposals and their potential impact on the local community."
            });
            // Recreation category
            eventsDictionary.Add(7, new Event
            {
                Id = 7,
                Name = "Outdoor Movie Night",
                Date = DateTime.Now.AddDays(10),
                Location = "Riverside Park",
                Category = "Recreation",
                Description = "Enjoy a movie under the stars at Riverside Park, with food trucks offering snacks and beverages."
            });
            eventsDictionary.Add(8, new Event
            {
                Id = 8,
                Name = "Picnic in the Park",
                Date = DateTime.Now.AddDays(5),
                Location = "Lakeside Park",
                Category = "Recreation",
                Description = "Bring your family and enjoy a relaxing day of picnicking with games, music, and food stalls at Lakeside Park."
            });
            eventsDictionary.Add(9, new Event
            {
                Id = 9,
                Name = "Fishing Derby",
                Date = DateTime.Now.AddDays(12),
                Location = "Lakefront",
                Category = "Recreation",
                Description = "Compete in the annual Fishing Derby at Lakefront, with prizes awarded for the largest catch in various categories."
            });
            // Arts category
            eventsDictionary.Add(10, new Event
            {
                Id = 10,
                Name = "Art in the Park",
                Date = DateTime.Now.AddDays(20),
                Location = "Heritage Park",
                Category = "Arts",
                Description = "Local artists showcase their work in an open-air gallery at Heritage Park, with workshops and live performances."
            });
            eventsDictionary.Add(11, new Event
            {
                Id = 11,
                Name = "Photography Exhibit",
                Date = DateTime.Now.AddDays(17),
                Location = "Cultural Center",
                Category = "Arts",
                Description = "Explore breathtaking photography capturing the essence of urban and natural landscapes at this special exhibit."
            });
            eventsDictionary.Add(12, new Event
            {
                Id = 12,
                Name = "Poetry Slam Night",
                Date = DateTime.Now.AddDays(25),
                Location = "Poets’ Corner",
                Category = "Arts",
                Description = "Watch talented local poets compete in a lively Poetry Slam with audience participation and prizes for the best performances."
            });
            // Health category
            eventsDictionary.Add(13, new Event
            {
                Id = 13,
                Name = "Health and Wellness Fair",
                Date = DateTime.Now.AddDays(12),
                Location = "Recreation Center",
                Category = "Health",
                Description = "Free health screenings, fitness demos, and talks on mental and physical wellness. Get advice from local health professionals."
            });
            eventsDictionary.Add(14, new Event
            {
                Id = 14,
                Name = "Blood Donation Drive",
                Date = DateTime.Now.AddDays(9),
                Location = "Health Clinic",
                Category = "Health",
                Description = "Help save lives by donating blood at the community's blood drive. Refreshments and giveaways for all donors."
            });
            eventsDictionary.Add(15, new Event
            {
                Id = 15,
                Name = "Mental Health Awareness Walk",
                Date = DateTime.Now.AddDays(8),
                Location = "City Park",
                Category = "Health",
                Description = "Join us in a walk to raise awareness and reduce stigma around mental health issues. Open to all ages and fitness levels."
            });
            // Sports category
            eventsDictionary.Add(16, new Event
            {
                Id = 16,
                Name = "Youth Sports Tournament",
                Date = DateTime.Now.AddDays(30),
                Location = "Southside Sports ",
                Category = "Sports",
                Description = "Cheer on young athletes competing in various sports. Fun activities and food stalls available for the whole family."
            });
            eventsDictionary.Add(17, new Event
            {
                Id = 17,
                Name = "Marathon Training Camp",
                Date = DateTime.Now.AddDays(14),
                Location = "Athletic Center",
                Category = "Sports",
                Description = "Get ready for the upcoming marathon by attending our training camp, led by professional coaches and trainers."
            });
            eventsDictionary.Add(18, new Event
            {
                Id = 18,
                Name = "Indoor Volleyball Tournament",
                Date = DateTime.Now.AddDays(22),
                Location = "Indoor Arena",
                Category = "Sports",
                Description = "Watch competitive volleyball teams battle it out in a fast-paced indoor tournament with exciting matchups."
            });



            // Populate categories into combo box
            PopulateEventCategories();
            PopulateAnnouncementCategories();

            // Filtering events and announcements by category 
            comboEvents.SelectedIndexChanged += comboEvents_SelectedIndexChanged;
            comboAnnouncement.SelectedIndexChanged += comboAnnouncement_SelectedIndexChanged;

            //Displaying details of events and announcements 
            listBoxEvents.SelectedIndexChanged += listBoxEvents_SelectedIndexChanged;
            listBoxAnnouncements.SelectedIndexChanged += listBoxAnnouncements_SelectedIndexChanged;


            // Display all events and announcements in list box
            DisplayEventsInListBox();
            DisplayAnnouncementsInListBox();
        }

        //Populating events combobox with categories
        private void PopulateEventCategories()
        {
            HashSet<string> eventCategories = new HashSet<string>();

            foreach (var ev in eventsDictionary.Values)
            {
                eventCategories.Add(ev.Category);
            }

            comboEvents.Items.Clear();
            comboEvents.Items.Add("All");

            foreach (var category in eventCategories)
            {
                comboEvents.Items.Add(category);
            }

            comboEvents.SelectedIndex = 0;
        }

        //Populating announcements combobox with categories
        private void PopulateAnnouncementCategories()
        {
            HashSet<string> announcementCategories = new HashSet<string>();

            foreach (var announcement in announcementStack)
            {
                announcementCategories.Add(announcement.Category);
            }

            comboAnnouncement.Items.Clear();
            comboAnnouncement.Items.Add("All");

            foreach (var category in announcementCategories)
            {
                comboAnnouncement.Items.Add(category);
            }

            comboAnnouncement.SelectedIndex = 0;
        }

        //Displaying all events in the events listbox
        private void DisplayEventsInListBox(string selectedCategory = "All")
        {
            listBoxEvents.Items.Clear();

            var orderedEvents = eventsDictionary.Values
                .Where(ev => selectedCategory == "All" || ev.Category == selectedCategory)
                .OrderBy(ev => ev.Date);

            foreach (var eventEntry in orderedEvents)
            {
                listBoxEvents.Items.Add($"{eventEntry.Name} - {eventEntry.Date.ToShortDateString()} at {eventEntry.Location}");
            }
        }


        //Displaying all announcements in the announcements listbox
        private void DisplayAnnouncementsInListBox(string selectedCategory = "All")
        {
            listBoxAnnouncements.Items.Clear();

            var orderedAnnouncements = announcementStack
                .OrderBy(a => a.Date)
                .Where(a => selectedCategory == "All" || a.Category == selectedCategory);

            foreach (var announcement in orderedAnnouncements)
            {
                listBoxAnnouncements.Items.Add($"{announcement.Title} - {announcement.Date.ToShortDateString()}");
            }
        }

        //Filtering and displaying events by selected category
        private void comboEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEvents.SelectedItem != null)
            {
                string selectedCategory = comboEvents.SelectedItem.ToString();
                DisplayEventsInListBox(selectedCategory);
            }
        }

        //Filtering and displaying announcements by selected category
        private void comboAnnouncement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAnnouncement.SelectedItem != null)
            {
                string selectedCategory = comboAnnouncement.SelectedItem.ToString();
                DisplayAnnouncementsInListBox(selectedCategory);
            }
        }

        //Displaying details of events in a messagebox 
        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem != null)
            {
                string selectedEvent = listBoxEvents.SelectedItem.ToString();

                Event selectedEventDetails = eventsDictionary.Values.FirstOrDefault(ev =>
                    $"{ev.Name} - {ev.Date.ToShortDateString()} at {ev.Location}" == selectedEvent);

                if (selectedEventDetails != null)
                {
                    string message = $"Event Details:\n" +
                                     $"------------------------------------\n" +
                                     $"Name: {selectedEventDetails.Name}\n" +
                                     $"Date: {selectedEventDetails.Date.ToShortDateString()}\n" +
                                     $"Location: {selectedEventDetails.Location}\n" +
                                     $"Category: {selectedEventDetails.Category}\n" +
                                     $"Description: {selectedEventDetails.Description}";

                    MessageBox.Show(message, "Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Determining the recommended events according to category selected
                    Event recommendedEvent = eventsDictionary.Values
                        .FirstOrDefault(ev => ev.Category == selectedEventDetails.Category && ev.Id != selectedEventDetails.Id);

                    Event closestDateEvent = eventsDictionary.Values
                        .Where(ev => ev.Id != selectedEventDetails.Id)
                        .OrderBy(ev => Math.Abs((ev.Date - selectedEventDetails.Date).TotalDays))
                        .FirstOrDefault();

                    if (recommendedEvent != null)
                    {
                        string recommendationMessage = $"Since since you looked at that event we figure that these events below might interest you too.\n\n" +
                                                       $"Similar in category\n" +
                                                       $"------------------------------------------\n" +
                                                       $"Name: {recommendedEvent.Name}\n" +
                                                       $"Date: {recommendedEvent.Date.ToShortDateString()}\n" +
                                                       $"Location: {recommendedEvent.Location}\n" +
                                                       $"Category: {recommendedEvent.Category}\n" +
                                                       $"Description: {recommendedEvent.Description}";

                        // Determining the recommended events according to closest date 
                        if (closestDateEvent != null)
                        {
                            recommendationMessage += $"\n\nClose in date/time:\n" +
                                                    $"----------------------------------------------\n" +
                                                    $"Name: {closestDateEvent.Name}\n" +
                                                    $"Date: {closestDateEvent.Date.ToShortDateString()}\n" +
                                                    $"Location: {closestDateEvent.Location}\n" +
                                                    $"Category: {closestDateEvent.Category}\n" +
                                                    $"Description: {closestDateEvent.Description}";
                        }

                        MessageBox.Show(recommendationMessage, "Event Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No recommendations available for this category.", "Event Recommendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        //Displaying details of announcements in a messagebox
        private void listBoxAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAnnouncements.SelectedItem != null)
            {
                string selectedAnnouncement = listBoxAnnouncements.SelectedItem.ToString();

                Announcement selectedAnnouncementDetails = null;

                foreach (var ann in announcementStack)
                {
                    string announcementString = $"{ann.Title} - {ann.Date.ToShortDateString()}";
                    if (announcementString == selectedAnnouncement)
                    {
                        selectedAnnouncementDetails = ann;
                        break;
                    }
                }

                if (selectedAnnouncementDetails != null)
                {
                    string message = $"Announcement Details:\n" +
                                     $"-------------------------------\n" +
                                     $"Title: {selectedAnnouncementDetails.Title}\n" +
                                     $"Date: {selectedAnnouncementDetails.Date.ToShortDateString()}\n" +
                                     $"Description: {selectedAnnouncementDetails.Description}\n" +
                                     $"Category: {selectedAnnouncementDetails.Category}";

                    MessageBox.Show(message, "Announcement Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        //Back button
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboEventsDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}







