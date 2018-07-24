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
        private Manager m_Manager;

        public Form_FacebookApp()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.CenterToScreen();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_Manager = new Manager(comboBox_AppID.Text);
            if (m_Manager.Login())
            {
                pictureBox_ProfilePicture.LoadAsync(m_Manager.GetURLNormalPicture());
                textBox_FirstName.Text = m_Manager.GetFirstName();
                textBox_LastName.Text = m_Manager.GetLastName();
                textBox_email.Text = m_Manager.GetEmail();
                visibleElements();
                initFriendList();
                initEventsList();
                try
                {
                    if (BirthdayHandler.isUserBirthdayToday(m_Manager.GetUserBirthday()))
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
            comboBox_AppID.Items.Add("1450160541956417");
            comboBox_AppID.SelectedIndex = 1;
        }

        private void initFriendList()
        {
            if (m_Manager.GetAllFriends() != null)
            {
                listBox_Friends.Items.Clear();
                listBox_Friends.DisplayMember = "FirstName";
               
                foreach (User friend in m_Manager.GetAllFriends())
                {
                    listBox_Friends.Items.Add(friend);
                }

            }
        }

        private void initEventsList()
        {
            try
            {

                if (m_Manager.GetAllEvents() != null)
                {
                    listBox_Events.Items.Clear();
                    listBox_Events.DisplayMember = "Name";
                    foreach (Event FBevent in m_Manager.GetAllEvents())
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
                textBox_friendFIrstName.Text = m_Manager.GetFirstName(selectedFriend);
                textBox_friendLastName.Text = m_Manager.GetLastName(selectedFriend);
                pictureBox_friend.LoadAsync(m_Manager.GetURLSmallPicture(selectedFriend));
                panel_friendDetails.Visible = true;
                try
                {
                    if (BirthdayHandler.isUserBirthdayToday(m_Manager.GetUserBirthday(selectedFriend)))
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

                double temperature = double.Parse(textBox_Temp.Text);

                if (temperature <= 0)
                {
                    pictureBox_whether.ImageLocation = "..\\..\\Resources\\rainy.png";
                }
                else if(temperature > 0 && temperature <= 20)
                {
                    pictureBox_whether.ImageLocation = "..\\..\\Resources\\cloudy.png";
                }
                else
                {
                    pictureBox_whether.ImageLocation = "..\\..\\Resources\\sun.png";
                }

                panel_eventDetails.Visible = true;
            }
        }

        private void Form_FacebookApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Action action = m_Manager.Dispose;
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
            PostCreator.CreateHappyBirthdayPost(SelectedFriend);
        }
    }
}
