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
            LoginResult result = FacebookService.Login(appID, "email","user_friends");
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
            comboBox_AppID.SelectedIndex = 0;
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
            if (m_LoggedInUser.Events != null)
            {
                listBox_Events.Items.Clear();
                foreach (var FBevent in m_LoggedInUser.Events)
                {
                    if((FBevent.StartTime >= dateTimePicker_startDate.Value) 
                        && (FBevent.EndTime <= dateTimePicker_endDate.Value))
                    {
                        listBox_Events.Items.Add(string.Format(FBevent.Name));
                    }
                }

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
                textBox_friendEmail.Text = selectedFriend.Email;
                pictureBox_friend.LoadAsync(selectedFriend.PictureSmallURL);
                panel_friendDetails.Visible = true;
            }
        }
    }
}
