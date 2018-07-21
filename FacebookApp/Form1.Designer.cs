namespace FacebookApp
{
    partial class Form1
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.comboBox_AppID = new System.Windows.Forms.ComboBox();
            this.label_AppID = new System.Windows.Forms.Label();
            this.comboBox_Collections = new System.Windows.Forms.ComboBox();
            this.listBox_Collecitons = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 26);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(199, 62);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox_ProfilePicture
            // 
            this.pictureBox_ProfilePicture.Location = new System.Drawing.Point(12, 121);
            this.pictureBox_ProfilePicture.Name = "pictureBox_ProfilePicture";
            this.pictureBox_ProfilePicture.Size = new System.Drawing.Size(357, 376);
            this.pictureBox_ProfilePicture.TabIndex = 1;
            this.pictureBox_ProfilePicture.TabStop = false;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Enabled = false;
            this.textBox_LastName.Location = new System.Drawing.Point(555, 190);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(212, 38);
            this.textBox_LastName.TabIndex = 2;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Enabled = false;
            this.textBox_FirstName.Location = new System.Drawing.Point(555, 121);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(212, 38);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(397, 121);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(160, 32);
            this.label_FirstName.TabIndex = 4;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(397, 190);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(159, 32);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Last Name:";
            // 
            // comboBox_AppID
            // 
            this.comboBox_AppID.FormattingEnabled = true;
            this.comboBox_AppID.Location = new System.Drawing.Point(331, 39);
            this.comboBox_AppID.Name = "comboBox_AppID";
            this.comboBox_AppID.Size = new System.Drawing.Size(436, 39);
            this.comboBox_AppID.TabIndex = 6;
            // 
            // label_AppID
            // 
            this.label_AppID.AutoSize = true;
            this.label_AppID.Location = new System.Drawing.Point(217, 42);
            this.label_AppID.Name = "label_AppID";
            this.label_AppID.Size = new System.Drawing.Size(108, 32);
            this.label_AppID.TabIndex = 7;
            this.label_AppID.Text = "App ID:";
            // 
            // comboBox_Collections
            // 
            this.comboBox_Collections.FormattingEnabled = true;
            this.comboBox_Collections.Location = new System.Drawing.Point(403, 443);
            this.comboBox_Collections.Name = "comboBox_Collections";
            this.comboBox_Collections.Size = new System.Drawing.Size(427, 39);
            this.comboBox_Collections.TabIndex = 8;
            this.comboBox_Collections.SelectedIndexChanged += new System.EventHandler(this.comboBox_Collections_SelectedIndexChanged);
            // 
            // listBox_Collecitons
            // 
            this.listBox_Collecitons.FormattingEnabled = true;
            this.listBox_Collecitons.ItemHeight = 31;
            this.listBox_Collecitons.Location = new System.Drawing.Point(403, 501);
            this.listBox_Collecitons.Name = "listBox_Collecitons";
            this.listBox_Collecitons.Size = new System.Drawing.Size(427, 345);
            this.listBox_Collecitons.TabIndex = 9;
            this.listBox_Collecitons.SelectedIndexChanged += new System.EventHandler(this.listBox_Collecitons_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1034);
            this.Controls.Add(this.listBox_Collecitons);
            this.Controls.Add(this.comboBox_Collections);
            this.Controls.Add(this.label_AppID);
            this.Controls.Add(this.comboBox_AppID);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.pictureBox_ProfilePicture);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox_ProfilePicture;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.ComboBox comboBox_AppID;
        private System.Windows.Forms.Label label_AppID;
        private System.Windows.Forms.ComboBox comboBox_Collections;
        private System.Windows.Forms.ListBox listBox_Collecitons;
    }
}

