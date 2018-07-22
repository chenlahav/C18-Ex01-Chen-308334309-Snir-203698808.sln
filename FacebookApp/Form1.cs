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

namespace FacebookApp
{
    public partial class Form_FacebookApp : Form
    {
        private FacebookWrapper.ObjectModel.User m_LoggedInUser;
        public Form_FacebookApp()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string appID = comboBox_AppID.Text;
            LoginResult result = FacebookService.Login(appID, "email","user_friends");
            m_LoggedInUser = result.LoggedInUser;
            string a = m_LoggedInUser.ToString();
            pictureBox_ProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            textBox_FirstName.Text = m_LoggedInUser.FirstName;
            textBox_LastName.Text = m_LoggedInUser.LastName;
            textBox_email.Text = m_LoggedInUser.Email;
            visibleElements();
            initFriendList();

        }

        private void visibleElements()
        {
            label_AppID.Visible = false;
            comboBox_AppID.Visible = false;
            buttonLogin.Visible = false;
            groupBox_Details.Visible = true;
            panel_friends.Visible = true;
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
                listBox_Collecitons.Items.Clear();
                foreach (var friend in m_LoggedInUser.Friends)
                {
                    listBox_Collecitons.Items.Add(string.Format(friend.FirstName + " " + friend.LastName));
                }

            }
        }

    }
}
