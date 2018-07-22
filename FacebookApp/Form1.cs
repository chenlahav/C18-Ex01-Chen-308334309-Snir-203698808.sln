using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class Form_FacebookApp : Form
    {
        private User m_LoggedInUser;
        public Form_FacebookApp()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(500, 600);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string appID = comboBox_AppID.Text;
            LoginResult result = FacebookService.Login(appID, "email","user_friends", "user_events", "user_location");
            m_LoggedInUser = result.LoggedInUser;
            pictureBox_ProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            textBox_FirstName.Text = m_LoggedInUser.FirstName;
            textBox_LastName.Text = m_LoggedInUser.LastName;
            textBox_email.Text = m_LoggedInUser.Email;
            visibleElements();
            initFriendList();
            initEventsList();

        }

        private void visibleElements()
        {
            label_AppID.Visible = false;
            comboBox_AppID.Visible = false;
            buttonLogin.Visible = false;
            groupBox_Details.Visible = true;
            panel_friends.Visible = true;
            panel_events.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_AppID.Items.Add("272862089537667");
            comboBox_AppID.Items.Add("1430451463721328");
            comboBox_AppID.SelectedIndex = 1;
        }

        private void initFriendList()
        {
            if (m_LoggedInUser.Friends != null)
            {
                listBox_Friends.Items.Clear();
                listBox_Friends.DisplayMember = "FirstName";
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBox_Friends.Items.Add(friend);
                }

            }
        }

        private void initEventsList()
        {
            try
            {

                if (m_LoggedInUser.Events != null)
                {
                    listBox_Events.Items.Clear();
                    listBox_Events.DisplayMember = "Name";
                    foreach (Event FBevent in m_LoggedInUser.Events)
                    {
                        listBox_Events.Items.Add(FBevent);
                    }

                }
            }
            catch (FacebookOAuthException e)
            {
                // DO nothing. The event will not display.
            }
        }

        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            initEventsList();
        }

        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            initEventsList();
        }

        private void listBox_Friends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_Friends.SelectedItem != null)
            {
                User selectedFriend = listBox_Friends.SelectedItem as User;
                textBox_friendFIrstName.Text = selectedFriend.FirstName;
                textBox_friendLastName.Text = selectedFriend.LastName;
                pictureBox_friend.LoadAsync(selectedFriend.PictureSmallURL);
                panel_friendDetails.Visible = true;
            }
        }

        private void listBox_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Events.SelectedItem != null)
            {
                Event selectedEvent = listBox_Events.SelectedItem as Event;
                textBox_eventName.Text = selectedEvent.Name;
                textBox_eventLocation.Text = selectedEvent.Place.Location.City;
                textBox_eventDescription.Text = selectedEvent.Description;
                dateTimePicker_eventDate.Value = (DateTime)selectedEvent.StartTime;
                pictureBox_event.LoadAsync(selectedEvent.PictureSmallURL);
                panel_eventDetails.Visible = true;
            }
        }
    }
}
