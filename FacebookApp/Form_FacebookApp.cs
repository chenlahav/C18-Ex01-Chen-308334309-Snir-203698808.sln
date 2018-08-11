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
                pictureBox_ProfilePicture.LoadAsync(m_Manager.GetUserURLNormalPicture());
                textBox_FirstName.Text = m_Manager.GetUserFirstName();
                textBox_LastName.Text = m_Manager.GetUserLastName();
                textBox_email.Text = m_Manager.GetUserEmail();
                visibleElements();
                initFriendList();
                initEventsList();
                try
                {
                    if (m_Manager.isUserBirthdayToday())
                    {
                        pictureBox_myBirthday.Visible = true;
                    }
                }
                catch(Exception ex)
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
            textBox_Status.Visible = true;
            panel_PostStatus.Visible = true;
            panel_friendDetails.Visible = true;
            showPanelHB(listBox_Friends.SelectedItem);
        }

        private void Form_FacebookApp_Load(object sender, EventArgs e)
        {
            comboBox_AppID.Items.Add("272862089537667");
            comboBox_AppID.Items.Add("1430451463721328");
            comboBox_AppID.SelectedIndex = 1;
        }

        private void initFriendList()
        {
            userBindingSource.DataSource = m_Manager.GetAllFriends();
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
            showPanelHB(sender);
        }

        private void showPanelHB(object user)
        {
            User selectedFriend = user as User;
            if (m_Manager.isUserBirthdayToday(selectedFriend))
            {
                panelHB.Visible = true;
            }
            else
            {
                panelHB.Visible = false;
            }
        }

        private void listBox_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Events.SelectedItem != null)
            {
                Event selectedEvent = listBox_Events.SelectedItem as Event;
                textBox_eventName.Text = m_Manager.GetEventName(selectedEvent);
                textBox_eventLocation.Text = m_Manager.GetEventCity(selectedEvent);
                textBox_eventDescription.Text = m_Manager.GetEventDescription(selectedEvent);
                textBox_eventDate.Text = m_Manager.GetEventTime(selectedEvent);
                pictureBox_event.LoadAsync(m_Manager.GetEventURLPicture(selectedEvent));

                string cityName = textBox_eventLocation.Text;
                CityWeather weather = m_Manager.GetWeather(cityName);
                
                textBox_Temp.Text = weather.m_Temperature;
                textBox_humidity.Text = weather.m_humidity;

                double temperature = double.Parse(textBox_Temp.Text);

                pictureBox_whether.ImageLocation = m_Manager.GetPathOfImageWeather(temperature);

                panel_eventDetails.Visible = true;
            }
        }

        private void Form_FacebookApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Action action = m_Manager.Dispose;
                FacebookService.Logout(action);
            }
            catch(Exception ex)
            {
                //do nothing
            }
            
        }

        private void button_PostHBD_Click(object sender, EventArgs e)
        {
            User SelectedFriend = listBox_Friends.SelectedItem as User;
            bool postedSucsses = m_Manager.PostHappyBirthday(SelectedFriend);
            if(postedSucsses)
            {
                MessageBox.Show("Sucssed to Post!");
            }
            else
            {
                MessageBox.Show("Failed to Post!");
            }
        }

        private void button_Post_Click(object sender, EventArgs e)
        {
            bool postedSucsses;
            postedSucsses = m_Manager.PostStatus(textBox_Status.Text);
            if (postedSucsses)
            {
                MessageBox.Show("Sucssed to Post!");
                textBox_Status.Text = "What\'s on your mind?";
            }
            else
            {
                MessageBox.Show("Failed to Post!");
            }
        }

        private void textBox_Status_Enter(object sender, EventArgs e)
        {
            if(textBox_Status.Text == "What\'s on your mind?")
            {
                textBox_Status.Text = null;
                button_Post.Enabled = false;
            }
        }

        private void textBox_Status_Leave(object sender, EventArgs e)
        {
            if (textBox_Status.Text == "")
            {
                textBox_Status.Text = "What\'s on your mind?";
                button_Post.Enabled = false;
            }
        }

        private void textBox_Status_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Status.Text != "" && textBox_Status.Text != "What\'s on your mind?")
            {
                button_Post.Enabled = true;
            }
            else
            {
                button_Post.Enabled = false;
            }
        }
    }
}
