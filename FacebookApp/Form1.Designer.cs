namespace FacebookApp
{
    partial class Form_FacebookApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Friends = new System.Windows.Forms.ListBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.pictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.comboBox_AppID = new System.Windows.Forms.ComboBox();
            this.label_AppID = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.label_Friends = new System.Windows.Forms.Label();
            this.panel_friends = new System.Windows.Forms.Panel();
            this.panel_friendDetails = new System.Windows.Forms.Panel();
            this.pictureBox_friend = new System.Windows.Forms.PictureBox();
            this.label_friendLastName = new System.Windows.Forms.Label();
            this.label_friendFirstName = new System.Windows.Forms.Label();
            this.textBox_friendFIrstName = new System.Windows.Forms.TextBox();
            this.textBox_friendLastName = new System.Windows.Forms.TextBox();
            this.panel_events = new System.Windows.Forms.Panel();
            this.listBox_Events = new System.Windows.Forms.ListBox();
            this.label_Events = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
            this.groupBox_Details.SuspendLayout();
            this.panel_friends.SuspendLayout();
            this.panel_friendDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_friend)).BeginInit();
            this.panel_events.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Friends
            // 
            this.listBox_Friends.FormattingEnabled = true;
            this.listBox_Friends.ItemHeight = 31;
            this.listBox_Friends.Location = new System.Drawing.Point(13, 84);
            this.listBox_Friends.Name = "listBox_Friends";
            this.listBox_Friends.Size = new System.Drawing.Size(427, 345);
            this.listBox_Friends.TabIndex = 9;
            this.listBox_Friends.SelectedIndexChanged += new System.EventHandler(this.listBox_Friends_SelectedIndexChanged);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Enabled = false;
            this.textBox_LastName.Location = new System.Drawing.Point(484, 151);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(341, 38);
            this.textBox_LastName.TabIndex = 2;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Enabled = false;
            this.textBox_FirstName.Location = new System.Drawing.Point(484, 82);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(341, 38);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(303, 82);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(160, 32);
            this.label_FirstName.TabIndex = 4;
            this.label_FirstName.Text = "First Name:";
            // 
            // pictureBox_ProfilePicture
            // 
            this.pictureBox_ProfilePicture.Location = new System.Drawing.Point(951, 43);
            this.pictureBox_ProfilePicture.Name = "pictureBox_ProfilePicture";
            this.pictureBox_ProfilePicture.Size = new System.Drawing.Size(283, 272);
            this.pictureBox_ProfilePicture.TabIndex = 1;
            this.pictureBox_ProfilePicture.TabStop = false;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(303, 151);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(159, 32);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Last Name:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(384, 118);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(199, 62);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBox_AppID
            // 
            this.comboBox_AppID.FormattingEnabled = true;
            this.comboBox_AppID.Location = new System.Drawing.Point(290, 52);
            this.comboBox_AppID.Name = "comboBox_AppID";
            this.comboBox_AppID.Size = new System.Drawing.Size(436, 39);
            this.comboBox_AppID.TabIndex = 6;
            // 
            // label_AppID
            // 
            this.label_AppID.AutoSize = true;
            this.label_AppID.Location = new System.Drawing.Point(176, 55);
            this.label_AppID.Name = "label_AppID";
            this.label_AppID.Size = new System.Drawing.Size(108, 32);
            this.label_AppID.TabIndex = 7;
            this.label_AppID.Text = "App ID:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(303, 215);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(95, 32);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Enabled = false;
            this.textBox_email.Location = new System.Drawing.Point(484, 215);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(341, 38);
            this.textBox_email.TabIndex = 10;
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Controls.Add(this.textBox_email);
            this.groupBox_Details.Controls.Add(this.label_email);
            this.groupBox_Details.Controls.Add(this.textBox_FirstName);
            this.groupBox_Details.Controls.Add(this.label_FirstName);
            this.groupBox_Details.Controls.Add(this.textBox_LastName);
            this.groupBox_Details.Controls.Add(this.label_LastName);
            this.groupBox_Details.Controls.Add(this.pictureBox_ProfilePicture);
            this.groupBox_Details.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(1734, 334);
            this.groupBox_Details.TabIndex = 12;
            this.groupBox_Details.TabStop = false;
            this.groupBox_Details.Text = "Details";
            this.groupBox_Details.Visible = false;
            // 
            // label_Friends
            // 
            this.label_Friends.AutoSize = true;
            this.label_Friends.Location = new System.Drawing.Point(7, 26);
            this.label_Friends.Name = "label_Friends";
            this.label_Friends.Size = new System.Drawing.Size(118, 32);
            this.label_Friends.TabIndex = 13;
            this.label_Friends.Text = "Friends:";
            // 
            // panel_friends
            // 
            this.panel_friends.Controls.Add(this.listBox_Friends);
            this.panel_friends.Controls.Add(this.label_Friends);
            this.panel_friends.Location = new System.Drawing.Point(57, 373);
            this.panel_friends.Name = "panel_friends";
            this.panel_friends.Size = new System.Drawing.Size(456, 444);
            this.panel_friends.TabIndex = 14;
            this.panel_friends.Visible = false;
            // 
            // panel_friendDetails
            // 
            this.panel_friendDetails.Controls.Add(this.pictureBox_friend);
            this.panel_friendDetails.Controls.Add(this.label_friendLastName);
            this.panel_friendDetails.Controls.Add(this.label_friendFirstName);
            this.panel_friendDetails.Controls.Add(this.textBox_friendFIrstName);
            this.panel_friendDetails.Controls.Add(this.textBox_friendLastName);
            this.panel_friendDetails.Location = new System.Drawing.Point(554, 457);
            this.panel_friendDetails.Name = "panel_friendDetails";
            this.panel_friendDetails.Size = new System.Drawing.Size(585, 345);
            this.panel_friendDetails.TabIndex = 18;
            this.panel_friendDetails.Visible = false;
            // 
            // pictureBox_friend
            // 
            this.pictureBox_friend.Location = new System.Drawing.Point(213, 21);
            this.pictureBox_friend.Name = "pictureBox_friend";
            this.pictureBox_friend.Size = new System.Drawing.Size(153, 141);
            this.pictureBox_friend.TabIndex = 18;
            this.pictureBox_friend.TabStop = false;
            // 
            // label_friendLastName
            // 
            this.label_friendLastName.AutoSize = true;
            this.label_friendLastName.Location = new System.Drawing.Point(22, 259);
            this.label_friendLastName.Name = "label_friendLastName";
            this.label_friendLastName.Size = new System.Drawing.Size(159, 32);
            this.label_friendLastName.TabIndex = 15;
            this.label_friendLastName.Text = "Last Name:";
            // 
            // label_friendFirstName
            // 
            this.label_friendFirstName.AutoSize = true;
            this.label_friendFirstName.Location = new System.Drawing.Point(22, 190);
            this.label_friendFirstName.Name = "label_friendFirstName";
            this.label_friendFirstName.Size = new System.Drawing.Size(160, 32);
            this.label_friendFirstName.TabIndex = 14;
            this.label_friendFirstName.Text = "First Name:";
            // 
            // textBox_friendFIrstName
            // 
            this.textBox_friendFIrstName.Enabled = false;
            this.textBox_friendFIrstName.Location = new System.Drawing.Point(203, 190);
            this.textBox_friendFIrstName.Name = "textBox_friendFIrstName";
            this.textBox_friendFIrstName.Size = new System.Drawing.Size(341, 38);
            this.textBox_friendFIrstName.TabIndex = 13;
            // 
            // textBox_friendLastName
            // 
            this.textBox_friendLastName.Enabled = false;
            this.textBox_friendLastName.Location = new System.Drawing.Point(203, 259);
            this.textBox_friendLastName.Name = "textBox_friendLastName";
            this.textBox_friendLastName.Size = new System.Drawing.Size(341, 38);
            this.textBox_friendLastName.TabIndex = 12;
            // 
            // panel_events
            // 
            this.panel_events.Controls.Add(this.listBox_Events);
            this.panel_events.Controls.Add(this.label_Events);
            this.panel_events.Location = new System.Drawing.Point(57, 897);
            this.panel_events.Name = "panel_events";
            this.panel_events.Size = new System.Drawing.Size(1069, 444);
            this.panel_events.TabIndex = 15;
            this.panel_events.Visible = false;
            // 
            // listBox_Events
            // 
            this.listBox_Events.FormattingEnabled = true;
            this.listBox_Events.ItemHeight = 31;
            this.listBox_Events.Location = new System.Drawing.Point(13, 84);
            this.listBox_Events.Name = "listBox_Events";
            this.listBox_Events.Size = new System.Drawing.Size(427, 345);
            this.listBox_Events.TabIndex = 9;
            // 
            // label_Events
            // 
            this.label_Events.AutoSize = true;
            this.label_Events.Location = new System.Drawing.Point(7, 26);
            this.label_Events.Name = "label_Events";
            this.label_Events.Size = new System.Drawing.Size(110, 32);
            this.label_Events.TabIndex = 13;
            this.label_Events.Text = "Events:";
            // 
            // Form_FacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 1437);
            this.Controls.Add(this.panel_friendDetails);
            this.Controls.Add(this.panel_events);
            this.Controls.Add(this.panel_friends);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.label_AppID);
            this.Controls.Add(this.comboBox_AppID);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form_FacebookApp";
            this.Text = "FacebookApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
            this.groupBox_Details.ResumeLayout(false);
            this.groupBox_Details.PerformLayout();
            this.panel_friends.ResumeLayout(false);
            this.panel_friends.PerformLayout();
            this.panel_friendDetails.ResumeLayout(false);
            this.panel_friendDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_friend)).EndInit();
            this.panel_events.ResumeLayout(false);
            this.panel_events.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Friends;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.PictureBox pictureBox_ProfilePicture;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ComboBox comboBox_AppID;
        private System.Windows.Forms.Label label_AppID;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.GroupBox groupBox_Details;
        private System.Windows.Forms.Label label_Friends;
        private System.Windows.Forms.Panel panel_friends;
        private System.Windows.Forms.Panel panel_events;
        private System.Windows.Forms.ListBox listBox_Events;
        private System.Windows.Forms.Label label_Events;
        private System.Windows.Forms.Panel panel_friendDetails;
        private System.Windows.Forms.Label label_friendLastName;
        private System.Windows.Forms.Label label_friendFirstName;
        private System.Windows.Forms.TextBox textBox_friendFIrstName;
        private System.Windows.Forms.TextBox textBox_friendLastName;
        private System.Windows.Forms.PictureBox pictureBox_friend;
    }
}

