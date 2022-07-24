using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CarRentalProject
{
    public partial class Form1 : Form
    {
        public Panel visiblePanel;
        public Panel basePanel;
        public static Panel createListingPanel;
        private static Label signedInLabel;
        public static string name;
        public  int carsMade = 0;

        public Form1()
        {
            InitializeComponent();
            visiblePanel = loginPanel;
            basePanel = signedInPanel;
            signedInLabel = userNameLabel;
            createListingPanel = createCarPanel;

        }

        private void signupButton_Click_1(object sender, EventArgs e)
        {
            logInSignUp.signUp(loginTextBox, passwordTextBox, this);

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            logInSignUp.logIn(loginTextBox, passwordTextBox, this);
        }

        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            logInSignUp.logInAdmin(loginTextBox, passwordTextBox, this);
        }


        public void signedInAdmin()
        {
            visiblePanel.Visible = false;
            visiblePanel = basePanel;
            visiblePanel.Visible = true;
            signedInLabel.Text = "Witaj " + name +"!";
            saveAndLoad.loadSave(this, false);
        }



        private void createCarButton_Click(object sender, EventArgs e)
        {
            visiblePanel = createListingPanel;
            //Show the panel with the info fillout
            if (visiblePanel.Visible == true)
            {
                visiblePanel.Visible = false;
            }
            else
            {
                visiblePanel.Visible = true;
            }

            //Reset image button
            tempBitmap = null;
            selectCarImageButton.Text = "Select Image";
        }


        public void createListingButton_Click(object sender, EventArgs e)
        {
            carListings.createCarListing(this);
        }

        public Panel[] panels = new Panel[18];
        public Car[] cars = new Car[18];
        public Bitmap[] carImageBitmaps = new Bitmap[18];
        public Bitmap tempBitmap;


        public int yplace = 0;
        public int xplace = 0;
        

        void deleteListingButton_Click(object sender, EventArgs e, Panel panel)
        {
            carListings.deleteListing(this, panel);
        }

        void selectCarImageButton_Click(object sender, EventArgs e)
        {
            carListings.selectCarImage(this);
        }

        private void loadListingsButton_Click(object sender, EventArgs e)
        {
            saveAndLoad.loadSave(this, true);
        }

        private void saveListingsButton_Click(object sender, EventArgs e)
        {
            saveAndLoad.savePanels(this);
        }

        //Functions for better textBox usability
        private void textBoxClickedErase(TextBox textBox)
        {
            textBox.Text="";
        }

        private void loginTextBox_Click(object sender, EventArgs e)
        {
            textBoxClickedErase(loginTextBox);
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            textBoxClickedErase(passwordTextBox);
        }

        private void carNameTextBox_Click(object sender, EventArgs e)
        {
            textBoxClickedErase(carNameTextBox);
        }

        private void carBrandTextBox_Click(object sender, EventArgs e)
        {
            textBoxClickedErase(carBrandTextBox);
        }

        private void carPriceTextBox_Click(object sender, EventArgs e)
        {
            textBoxClickedErase(carPriceTextBox);
        }

        private void carYearTextBox_Click(object sender, EventArgs e)
        {
            textBoxClickedErase(carYearTextBox);
        }

        private void carOdoTextBox_Click(object sender, EventArgs e)
        {
            textBoxClickedErase(carOdoTextBox);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
