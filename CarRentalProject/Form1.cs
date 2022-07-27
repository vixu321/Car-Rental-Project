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
        public float userBalance = 0;

        //Change this variable to change number of listings in a row
        public int numOfCarsInRow = 5;

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
            logInSignUp.logInUser(loginTextBox, passwordTextBox, this);
        }

        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            logInSignUp.logInAdmin(loginTextBox, passwordTextBox, this);
        }


        public void signedInAdmin()
        {
            visiblePanel.Visible = false;
            visiblePanel = basePanel;
            carListingsPanel.Visible = true;
            visiblePanel.Visible = true;
            signedInLabel.Text = "Welcome " + name +"!";
            saveAndLoad.loadSave(this, false);
        }

        public void signedInUser()
        {
            visiblePanel.Visible = false;
            visiblePanel = userLoggedInPanel;
            visiblePanel.Visible = true;
            signedInUserLabel.Text = "Welcome " + name + "!";
            accountBalanceLabel.Text = "Balance: $"+userBalance.ToString();
            saveAndLoad.loadSave(this, false);
            saveAndLoad.loadSaveRented(this, false);
            carListings.userSideListings(this);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void logOutButtonTwo_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void logOut()
        {
            userLoggedInPanel.Visible = false;
            visiblePanel.Visible = false;
            visiblePanel = loginPanel;
            visiblePanel.Visible = true;
            int temp = carsMade;
            for (int i = 0; i < temp; i++)
            {
                carListings.deleteListing(this, panels[0]);
            }
            passwordTextBox.Text = "password";
            loginTextBox.Text = "Login";
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

        public Panel[] panels = new Panel[25];
        public Car[] cars = new Car[25];
        public Bitmap[] carImageBitmaps = new Bitmap[25];
        public Panel[] rentedPanels = new Panel[25];
        public Car[] rentedCars = new Car[25];
        public Bitmap tempBitmap;
        public int carsRentedNumber = 0;
        public string[] hoursRented = new string[25];

        public int yplace = 0;
        public int xplace = 0;
        public int yplaceRented = 0;
        public int xplaceRented = 0;

        
        
        //Event handler with lambda function for deleteListing button, has to be done this way to send the panel element through the arguments
        void deleteListingButton_Click(object sender, EventArgs e, Panel panel)
        {
            carListings.deleteListing(this, panel);
        }

        public EventHandler deleteclick;
        public void deleteListingClick(Panel panel)
        {
            deleteclick = new EventHandler((sender, e) => deleteListingButton_Click(sender, e, panel));
        }

        //Event handler with lambda function for rentCar button, has to be done this way to send the panel element through the arguments
        void rentCarButton_Click(object sender, EventArgs e, Panel panel)
        {
            carListings.rentCar(this, panel);
        }
        public EventHandler rentclick;
        public void rentCarClick(Panel panel)
        {
            rentclick = new EventHandler((sender, e) => rentCarButton_Click(sender, e, panel));
        }



        //Event handler with lambda functon for when the hours counter when renting is changed
        void hoursCounter_ValueChanged(object sender, EventArgs e, NumericUpDown numeric, int position)
        {
            carListings.hoursChangedControl(this, numeric, position);
        }
        public EventHandler hoursChanged;
        public void hoursChangedValue(NumericUpDown numeric, int position)
        {
            hoursChanged = new EventHandler((sender, e) => hoursCounter_ValueChanged(sender, e, numeric, position));
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

        private void numericOnlyTextBox(object sender, KeyPressEventArgs e)
        {
            //Make the text box with this even handler only accept numbers as inputs (with decimal point)
            if(char.IsControl(e.KeyChar)==false && char.IsDigit(e.KeyChar)==false && e.KeyChar!='.')
            {
                e.Handled = true;
            }

            if((e.KeyChar=='.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void rentedCarsPanelButton_Click(object sender, EventArgs e)
        {
            carListings.showRentedCars(this);
        }

        private void carListingsButton_Click(object sender, EventArgs e)
        {
            carListings.showListings(this);
        }

        private void saveRentedButton_Click(object sender, EventArgs e)
        {
            saveAndLoad.saveRentedPanels(this);
        }

        private void loadRentedButton_Click(object sender, EventArgs e)
        {
            saveAndLoad.loadSaveRented(this, true);
        }
    }
}
