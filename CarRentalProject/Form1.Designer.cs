
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
            this.logOutButton = new System.Windows.Forms.Button();
            this.saveListingsButton = new System.Windows.Forms.Button();
            this.loadListingsButton = new System.Windows.Forms.Button();
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
            this.userLoggedInPanel = new System.Windows.Forms.Panel();
            this.carListingsButton = new System.Windows.Forms.Button();
            this.rentedCarsPanelButton = new System.Windows.Forms.Button();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.logOutButtonTwo = new System.Windows.Forms.Button();
            this.signedInUserLabel = new System.Windows.Forms.Label();
            this.carListingsPanel = new System.Windows.Forms.Panel();
            this.rentedCarsPanel = new System.Windows.Forms.Panel();
            this.loginPanel.SuspendLayout();
            this.signedInPanel.SuspendLayout();
            this.createCarPanel.SuspendLayout();
            this.userLoggedInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(21, 61);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = false;
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
            // 
            // loginPanel
            // 
            this.loginPanel.AutoSize = true;
            this.loginPanel.Controls.Add(this.adminLogInButton);
            this.loginPanel.Controls.Add(this.signupButton);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Location = new System.Drawing.Point(350, 134);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(121, 166);
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
            this.signedInPanel.Controls.Add(this.logOutButton);
            this.signedInPanel.Controls.Add(this.saveListingsButton);
            this.signedInPanel.Controls.Add(this.loadListingsButton);
            this.signedInPanel.Controls.Add(this.userNameLabel);
            this.signedInPanel.Controls.Add(this.createCarPanel);
            this.signedInPanel.Controls.Add(this.createCarButton);
            this.signedInPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.signedInPanel.Location = new System.Drawing.Point(0, 0);
            this.signedInPanel.Margin = new System.Windows.Forms.Padding(0);
            this.signedInPanel.Name = "signedInPanel";
            this.signedInPanel.Size = new System.Drawing.Size(133, 611);
            this.signedInPanel.TabIndex = 5;
            this.signedInPanel.Visible = false;
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOutButton.Location = new System.Drawing.Point(65, 3);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(61, 23);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // saveListingsButton
            // 
            this.saveListingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveListingsButton.Location = new System.Drawing.Point(7, 545);
            this.saveListingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveListingsButton.Name = "saveListingsButton";
            this.saveListingsButton.Size = new System.Drawing.Size(104, 23);
            this.saveListingsButton.TabIndex = 6;
            this.saveListingsButton.Text = "Save Listings";
            this.saveListingsButton.UseVisualStyleBackColor = true;
            this.saveListingsButton.Click += new System.EventHandler(this.saveListingsButton_Click);
            // 
            // loadListingsButton
            // 
            this.loadListingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadListingsButton.Location = new System.Drawing.Point(7, 577);
            this.loadListingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.loadListingsButton.Name = "loadListingsButton";
            this.loadListingsButton.Size = new System.Drawing.Size(104, 23);
            this.loadListingsButton.TabIndex = 8;
            this.loadListingsButton.Text = "Load Listings";
            this.loadListingsButton.UseVisualStyleBackColor = true;
            this.loadListingsButton.Click += new System.EventHandler(this.loadListingsButton_Click);
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
            this.createCarPanel.Location = new System.Drawing.Point(7, 61);
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
            this.carPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericOnlyTextBox);
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
            this.carOdoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericOnlyTextBox);
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
            this.carYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericOnlyTextBox);
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
            this.createCarButton.Location = new System.Drawing.Point(7, 32);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(109, 23);
            this.createCarButton.TabIndex = 1;
            this.createCarButton.Text = "Create listing";
            this.createCarButton.UseVisualStyleBackColor = false;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // userLoggedInPanel
            // 
            this.userLoggedInPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(19)))), ((int)(((byte)(68)))));
            this.userLoggedInPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userLoggedInPanel.Controls.Add(this.carListingsButton);
            this.userLoggedInPanel.Controls.Add(this.rentedCarsPanelButton);
            this.userLoggedInPanel.Controls.Add(this.accountBalanceLabel);
            this.userLoggedInPanel.Controls.Add(this.logOutButtonTwo);
            this.userLoggedInPanel.Controls.Add(this.signedInUserLabel);
            this.userLoggedInPanel.Location = new System.Drawing.Point(0, 0);
            this.userLoggedInPanel.Margin = new System.Windows.Forms.Padding(0);
            this.userLoggedInPanel.Name = "userLoggedInPanel";
            this.userLoggedInPanel.Size = new System.Drawing.Size(133, 607);
            this.userLoggedInPanel.TabIndex = 9;
            this.userLoggedInPanel.Visible = false;
            // 
            // carListingsButton
            // 
            this.carListingsButton.Location = new System.Drawing.Point(3, 79);
            this.carListingsButton.Name = "carListingsButton";
            this.carListingsButton.Size = new System.Drawing.Size(92, 23);
            this.carListingsButton.TabIndex = 10;
            this.carListingsButton.Text = "Show listings";
            this.carListingsButton.UseVisualStyleBackColor = true;
            this.carListingsButton.Click += new System.EventHandler(this.carListingsButton_Click);
            // 
            // rentedCarsPanelButton
            // 
            this.rentedCarsPanelButton.Location = new System.Drawing.Point(3, 108);
            this.rentedCarsPanelButton.Name = "rentedCarsPanelButton";
            this.rentedCarsPanelButton.Size = new System.Drawing.Size(92, 23);
            this.rentedCarsPanelButton.TabIndex = 9;
            this.rentedCarsPanelButton.Text = "Rented Cars";
            this.rentedCarsPanelButton.UseVisualStyleBackColor = true;
            this.rentedCarsPanelButton.Click += new System.EventHandler(this.rentedCarsPanelButton_Click);
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.AutoSize = true;
            this.accountBalanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.accountBalanceLabel.Location = new System.Drawing.Point(7, 51);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(38, 15);
            this.accountBalanceLabel.TabIndex = 8;
            this.accountBalanceLabel.Text = "label1";
            // 
            // logOutButtonTwo
            // 
            this.logOutButtonTwo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOutButtonTwo.Location = new System.Drawing.Point(7, 25);
            this.logOutButtonTwo.Name = "logOutButtonTwo";
            this.logOutButtonTwo.Size = new System.Drawing.Size(61, 23);
            this.logOutButtonTwo.TabIndex = 6;
            this.logOutButtonTwo.Text = "Log out";
            this.logOutButtonTwo.UseVisualStyleBackColor = true;
            this.logOutButtonTwo.Click += new System.EventHandler(this.logOutButtonTwo_Click);
            // 
            // signedInUserLabel
            // 
            this.signedInUserLabel.AutoSize = true;
            this.signedInUserLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signedInUserLabel.Location = new System.Drawing.Point(11, 7);
            this.signedInUserLabel.Name = "signedInUserLabel";
            this.signedInUserLabel.Size = new System.Drawing.Size(38, 15);
            this.signedInUserLabel.TabIndex = 7;
            this.signedInUserLabel.Text = "label1";
            // 
            // carListingsPanel
            // 
            this.carListingsPanel.Location = new System.Drawing.Point(136, 5);
            this.carListingsPanel.Name = "carListingsPanel";
            this.carListingsPanel.Size = new System.Drawing.Size(153, 151);
            this.carListingsPanel.TabIndex = 10;
            // 
            // rentedCarsPanel
            // 
            this.rentedCarsPanel.Location = new System.Drawing.Point(0, 0);
            this.rentedCarsPanel.Name = "rentedCarsPanel";
            this.rentedCarsPanel.Size = new System.Drawing.Size(124, 128);
            this.rentedCarsPanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(924, 611);
            this.Controls.Add(this.userLoggedInPanel);
            this.Controls.Add(this.signedInPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.carListingsPanel);
            this.Controls.Add(this.rentedCarsPanel);
            this.MaximumSize = new System.Drawing.Size(940, 650);
            this.MinimumSize = new System.Drawing.Size(940, 650);
            this.Name = "Form1";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signedInPanel.ResumeLayout(false);
            this.signedInPanel.PerformLayout();
            this.createCarPanel.ResumeLayout(false);
            this.createCarPanel.PerformLayout();
            this.userLoggedInPanel.ResumeLayout(false);
            this.userLoggedInPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel userLoggedInPanel;
        private System.Windows.Forms.Button logOutButtonTwo;
        private System.Windows.Forms.Label signedInUserLabel;
        public System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.Button rentedCarsPanelButton;
        public System.Windows.Forms.Panel carListingsPanel;
        private System.Windows.Forms.Button carListingsButton;
        public System.Windows.Forms.Panel rentedCarsPanel;
    }
}

