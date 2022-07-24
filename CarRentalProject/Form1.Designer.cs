
namespace CarRentalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.adminLogInButton = new System.Windows.Forms.Button();
            this.signedInPanel = new System.Windows.Forms.Panel();
            this.loadListingsButton = new System.Windows.Forms.Button();
            this.saveListingsButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.createCarPanel = new System.Windows.Forms.Panel();
            this.selectCarImageButton = new System.Windows.Forms.Button();
            this.createListingButton = new System.Windows.Forms.Button();
            this.carPriceTextBox = new System.Windows.Forms.TextBox();
            this.carOdoTextBox = new System.Windows.Forms.TextBox();
            this.carYearTextBox = new System.Windows.Forms.TextBox();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.createCarButton = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.signedInPanel.SuspendLayout();
            this.createCarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(21, 61);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(21, 90);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(75, 23);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click_1);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(0, 3);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(118, 23);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.Text = "Login";
            this.loginTextBox.Click += new System.EventHandler(this.loginTextBox_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(0, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(118, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.adminLogInButton);
            this.loginPanel.Controls.Add(this.signupButton);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Location = new System.Drawing.Point(224, 73);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(121, 163);
            this.loginPanel.TabIndex = 4;
            // 
            // adminLogInButton
            // 
            this.adminLogInButton.Location = new System.Drawing.Point(3, 140);
            this.adminLogInButton.Name = "adminLogInButton";
            this.adminLogInButton.Size = new System.Drawing.Size(115, 23);
            this.adminLogInButton.TabIndex = 6;
            this.adminLogInButton.Text = "Log in as admin";
            this.adminLogInButton.UseVisualStyleBackColor = true;
            this.adminLogInButton.Click += new System.EventHandler(this.adminLogInButton_Click);
            // 
            // signedInPanel
            // 
            this.signedInPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(19)))), ((int)(((byte)(68)))));
            this.signedInPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signedInPanel.Controls.Add(this.loadListingsButton);
            this.signedInPanel.Controls.Add(this.saveListingsButton);
            this.signedInPanel.Controls.Add(this.userNameLabel);
            this.signedInPanel.Controls.Add(this.createCarPanel);
            this.signedInPanel.Controls.Add(this.createCarButton);
            this.signedInPanel.Location = new System.Drawing.Point(-5, -3);
            this.signedInPanel.Name = "signedInPanel";
            this.signedInPanel.Size = new System.Drawing.Size(133, 455);
            this.signedInPanel.TabIndex = 5;
            this.signedInPanel.Visible = false;
            // 
            // loadListingsButton
            // 
            this.loadListingsButton.Location = new System.Drawing.Point(7, 418);
            this.loadListingsButton.Name = "loadListingsButton";
            this.loadListingsButton.Size = new System.Drawing.Size(84, 23);
            this.loadListingsButton.TabIndex = 8;
            this.loadListingsButton.Text = "Load Listings";
            this.loadListingsButton.UseVisualStyleBackColor = true;
            this.loadListingsButton.Click += new System.EventHandler(this.loadListingsButton_Click);
            // 
            // saveListingsButton
            // 
            this.saveListingsButton.Location = new System.Drawing.Point(7, 389);
            this.saveListingsButton.Name = "saveListingsButton";
            this.saveListingsButton.Size = new System.Drawing.Size(84, 23);
            this.saveListingsButton.TabIndex = 6;
            this.saveListingsButton.Text = "Save Listings";
            this.saveListingsButton.UseVisualStyleBackColor = true;
            this.saveListingsButton.Click += new System.EventHandler(this.saveListingsButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.userNameLabel.Location = new System.Drawing.Point(11, 7);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(38, 15);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "label1";
            // 
            // createCarPanel
            // 
            this.createCarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createCarPanel.Controls.Add(this.selectCarImageButton);
            this.createCarPanel.Controls.Add(this.createListingButton);
            this.createCarPanel.Controls.Add(this.carPriceTextBox);
            this.createCarPanel.Controls.Add(this.carOdoTextBox);
            this.createCarPanel.Controls.Add(this.carYearTextBox);
            this.createCarPanel.Controls.Add(this.carBrandTextBox);
            this.createCarPanel.Controls.Add(this.carNameTextBox);
            this.createCarPanel.Location = new System.Drawing.Point(7, 54);
            this.createCarPanel.Name = "createCarPanel";
            this.createCarPanel.Size = new System.Drawing.Size(109, 279);
            this.createCarPanel.TabIndex = 2;
            this.createCarPanel.Visible = false;
            // 
            // selectCarImageButton
            // 
            this.selectCarImageButton.Location = new System.Drawing.Point(4, 151);
            this.selectCarImageButton.Name = "selectCarImageButton";
            this.selectCarImageButton.Size = new System.Drawing.Size(100, 23);
            this.selectCarImageButton.TabIndex = 6;
            this.selectCarImageButton.Text = "Select Image";
            this.selectCarImageButton.UseVisualStyleBackColor = true;
            this.selectCarImageButton.Click += new System.EventHandler(this.selectCarImageButton_Click);
            // 
            // createListingButton
            // 
            this.createListingButton.Location = new System.Drawing.Point(4, 180);
            this.createListingButton.Name = "createListingButton";
            this.createListingButton.Size = new System.Drawing.Size(75, 23);
            this.createListingButton.TabIndex = 5;
            this.createListingButton.Text = "Create";
            this.createListingButton.UseVisualStyleBackColor = true;
            this.createListingButton.Click += new System.EventHandler(this.createListingButton_Click);
            // 
            // carPriceTextBox
            // 
            this.carPriceTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.carPriceTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.carPriceTextBox.Location = new System.Drawing.Point(4, 122);
            this.carPriceTextBox.Name = "carPriceTextBox";
            this.carPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.carPriceTextBox.TabIndex = 4;
            this.carPriceTextBox.Text = "Price/h";
            this.carPriceTextBox.Click += new System.EventHandler(this.carPriceTextBox_Click);
            // 
            // carOdoTextBox
            // 
            this.carOdoTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.carOdoTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.carOdoTextBox.Location = new System.Drawing.Point(4, 93);
            this.carOdoTextBox.Name = "carOdoTextBox";
            this.carOdoTextBox.Size = new System.Drawing.Size(100, 23);
            this.carOdoTextBox.TabIndex = 3;
            this.carOdoTextBox.Text = "Odometer";
            this.carOdoTextBox.Click += new System.EventHandler(this.carOdoTextBox_Click);
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.carYearTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.carYearTextBox.Location = new System.Drawing.Point(4, 64);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.Size = new System.Drawing.Size(100, 23);
            this.carYearTextBox.TabIndex = 2;
            this.carYearTextBox.Text = "Year";
            this.carYearTextBox.Click += new System.EventHandler(this.carYearTextBox_Click);
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.carBrandTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.carBrandTextBox.Location = new System.Drawing.Point(4, 35);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(100, 23);
            this.carBrandTextBox.TabIndex = 1;
            this.carBrandTextBox.Text = "Brand";
            this.carBrandTextBox.Click += new System.EventHandler(this.carBrandTextBox_Click);
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.carNameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.carNameTextBox.Location = new System.Drawing.Point(4, 3);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.carNameTextBox.TabIndex = 0;
            this.carNameTextBox.Text = "Name";
            this.carNameTextBox.Click += new System.EventHandler(this.carNameTextBox_Click);
            // 
            // createCarButton
            // 
            this.createCarButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createCarButton.Location = new System.Drawing.Point(7, 25);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(109, 23);
            this.createCarButton.TabIndex = 1;
            this.createCarButton.Text = "Create listing";
            this.createCarButton.UseVisualStyleBackColor = false;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(624, 449);
            this.Controls.Add(this.signedInPanel);
            this.Controls.Add(this.loginPanel);
            this.MaximumSize = new System.Drawing.Size(640, 488);
            this.MinimumSize = new System.Drawing.Size(640, 488);
            this.Name = "Form1";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signedInPanel.ResumeLayout(false);
            this.signedInPanel.PerformLayout();
            this.createCarPanel.ResumeLayout(false);
            this.createCarPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel signedInPanel;
        private System.Windows.Forms.Button createCarButton;
        private System.Windows.Forms.Panel createCarPanel;
        private System.Windows.Forms.Button createListingButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button saveListingsButton;
        private System.Windows.Forms.Button loadListingsButton;
        private System.Windows.Forms.Button adminLogInButton;
        public System.Windows.Forms.TextBox carBrandTextBox;
        public System.Windows.Forms.TextBox carNameTextBox;
        public System.Windows.Forms.TextBox carYearTextBox;
        public System.Windows.Forms.TextBox carPriceTextBox;
        public System.Windows.Forms.TextBox carOdoTextBox;
        public System.Windows.Forms.Button selectCarImageButton;
    }
}

