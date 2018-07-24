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
        public Form_FacebookApp()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Manager.Login(comboBox_AppID.Text))
            {
                pictureBox_ProfilePicture.LoadAsync(Manager.GetURLPicture());
                textBox_FirstName.Text = Manager.GetFirstName();
                textBox_LastName.Text = Manager.GetLastName();
                textBox_email.Text = Manager.GetEmail();
                visibleElements();
                initFriendList();
                initEventsList();
                try
                {
                    if (BirthdayHandler.isUserBirthdayToday(Manager.GetUserBirthday()))
                    {
                        pictureBox_myBirthday.Visible = true;
                        button_PostHBD.Visible = true;
                    }
                }
                catch
                {
                    //do nothing
                }
            }
            else
            {
                MessageBox.Show("Could not login");
            }

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
            if (Manager.GetAllFriends() != null)
            {
                listBox_Friends.Items.Clear();
                listBox_Friends.DisplayMember = "FirstName";
               
                foreach (User friend in Manager.GetAllFriends())
                {
                    listBox_Friends.Items.Add(friend);
                }

            }
        }

        private void initEventsList()
        {
            try
            {

                if (Manager.GetAllEvents() != null)
                {
                    listBox_Events.Items.Clear();
                    listBox_Events.DisplayMember = "Name";
                    foreach (Event FBevent in Manager.GetAllEvents())
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

        private void listBox_Friends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_Friends.SelectedItem != null)
            {
                User selectedFriend = listBox_Friends.SelectedItem as User;
                textBox_friendFIrstName.Text = selectedFriend.FirstName;
                textBox_friendLastName.Text = selectedFriend.LastName;
                pictureBox_friend.LoadAsync(selectedFriend.PictureSmallURL);
                panel_friendDetails.Visible = true;
                try
                {
                    if (BirthdayHandler.isUserBirthdayToday(selectedFriend.Birthday))
                    {
                        pictureBox_birthday.Visible = true;
                    }
                }
                catch
                {
                    //do nothing
                }
            }
        }

        private void listBox_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Events.SelectedItem != null)
            {
                Event selectedEvent = listBox_Events.SelectedItem as Event;
                textBox_eventName.Text = selectedEvent.Name;
                textBox_eventLocation.Text = selectedEvent.Place != null ? selectedEvent.Place.Location.City : "" ;
                textBox_eventDescription.Text = selectedEvent.Description != null ? selectedEvent.Description : "";
                textBox_eventDate.Text = selectedEvent.TimeString;
                pictureBox_event.LoadAsync(selectedEvent.PictureSmallURL);

                string cityName = textBox_eventLocation.Text;
                CityWeather weather = Weather.GetWeather(cityName);
                
                textBox_Temp.Text = weather.m_Temperature;
                textBox_humidity.Text = weather.m_humidity;

                panel_eventDetails.Visible = true;
            }
        }

        private void Form_FacebookApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Action action = Manager.Logout;
            try
            {
                FacebookService.Logout(action);
            }
            catch
            {
                //do nothing
            }
            
        }

        private void button_PostHBD_Click(object sender, EventArgs e)
        {
            User SelectedFriend = listBox_Friends.SelectedItem as User;
            PostCreator.CreatePostHappyBirthday(SelectedFriend);
        }
    }
}
