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
            LoginResult result = FacebookService.Login("1430451463721328", "email");
            m_LoggedInUser = result.LoggedInUser;
        }
    }
}
