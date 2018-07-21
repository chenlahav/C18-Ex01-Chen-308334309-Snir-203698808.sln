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
    public partial class Form1 : Form
    {
        private FacebookWrapper.ObjectModel.User m_LoggedInUser;
        public Form1()
        {
            InitializeComponent();
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

        }

        private void visibleElements()
        {
            label_AppID.Visible = false;
            comboBox_AppID.Visible = false;
            buttonLogin.Visible = false;
            groupBox_Details.Visible = true;
            //label_FirstName.Visible = true;
            //label_LastName.Visible = true;
            //label_email.Visible = true;
            //textBox_FirstName.Visible = true;
            //textBox_LastName.Visible = true;
            //textBox_email.Visible = true;
            listBox_Collecitons.Visible = true;
            comboBox_Collections.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_AppID.Items.Add("272862089537667");
            comboBox_AppID.Items.Add("1430451463721328");
            comboBox_AppID.SelectedIndex = 0;

            comboBox_Collections.Items.Add("friends");
            comboBox_Collections.Items.Add("first_name");
            comboBox_Collections.Items.Add("last_name");
        }

        private void listBox_Collecitons_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_Collections_SelectedIndexChanged(object sender, EventArgs e)
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
