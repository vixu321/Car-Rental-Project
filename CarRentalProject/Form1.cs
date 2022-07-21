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
        public static Panel visiblePanel;
        public static Panel basePanel;
        public static Panel createListingPanel;
        private static Label signedInLabel;
        public static string name;
        private int carsMade = 0;

        public Form1()
        {
            InitializeComponent();
            visiblePanel = loginPanel;
            basePanel = signedInPanel;
            signedInLabel = userNameLabel;
            createListingPanel = createCarPanel;

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }




        private void signupButton_Click_1(object sender, EventArgs e)
        {
            Program.signUp(loginTextBox, passwordTextBox);

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            Program.logIn(loginTextBox, passwordTextBox);
        }


        public static void signedIn()
        {
            visiblePanel.Visible = false;
            visiblePanel = basePanel;
            visiblePanel.Visible = true;
            signedInLabel.Text = "Witaj " + name +"!";
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
            carImageBitmap = null;
            selectCarImageButton.Text = "Select Image";
        }


        private void createListingButton_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(carNameTextBox.Text, carBrandTextBox.Text, carYearTextBox.Text, carOdoTextBox.Text, carPriceTextBox.Text, carImageBitmap);
            if(carNameTextBox.Text == "" || carBrandTextBox.Text == "" || carYearTextBox.Text == "" || carOdoTextBox.Text == "" || carPriceTextBox.Text == "" || carImageBitmap == null)
            {
                MessageBox.Show("Some car info is missing!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            createNewCarPanel(carsMade, newCar);
            visiblePanel.Visible = false;
            visiblePanel = basePanel;
            carsMade++;
        }

        Panel[] panels = new Panel[18];
        Car[] cars = new Car[18];

        private int yplace = 0;
        private int xplace = 0;
        Bitmap carImageBitmap;
        public void createNewCarPanel(int carsMade, Car car)
        {
            int numOfInfoBoxes = 6;

            Panel panel = new Panel();
            Label[] textBoxes = new Label[numOfInfoBoxes];

            Size TextBoxSize = new Size(104, 16);
            panel.Location = new Point(150 + 130 * xplace, 10 + 270 * yplace);

            //Change x and y place for next panel
            xplace++;
            if (xplace >= 3)
            {
                yplace++;
                xplace = 0;
            }


            panel.Size = new Size(124, 270);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            

            this.Controls.Add(panel);

            
            //Create the pictureBox for car imaage
            PictureBox carImage = new PictureBox();
            carImage.Location = new Point(10, 10);
            carImage.Size = new Size(104, 60);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.Image = car.image;

            panel.Controls.Add(carImage);


            //Make the buttons, change numOfInfoBoxes to increase buttons
            for (int i = 0; i<numOfInfoBoxes; i++)
            {
                textBoxes[i] = new Label();
                textBoxes[i].Location = new Point(10, 80 + 25 * i);
                textBoxes[i].Size = TextBoxSize;
                textBoxes[i].ForeColor = Color.White;
                panel.Controls.Add(textBoxes[i]);
            }

            //Create button for deleteing the listing
            Button deleteListingButton = new Button();
            deleteListingButton.Text = "Delete listing";
            deleteListingButton.Location = new Point(10, 80 + 25 * numOfInfoBoxes);
            deleteListingButton.BackColor = Color.White;
            deleteListingButton.ForeColor = Color.Black;


            panel.Name = carsMade.ToString();

            //Set the click event, send panel through the arguments
            deleteListingButton.Click += new EventHandler((sender, e)=>deleteListingButton_Click(sender, e, panel));

            panel.Controls.Add(deleteListingButton);

            //Poor solution, no easier way to do it
            textBoxes[0].Text = "Name: " + car.name;
            textBoxes[1].Text = "Brand: " + car.brand;
            textBoxes[2].Text = "Year: " + car.year;
            textBoxes[3].Text = "Odometer: " + car.odometer;
            textBoxes[4].Text = "Price/h: " + "$" + car.pricePerHour;
            textBoxes[5].Text = panel.Name;

            panels[carsMade] = panel;
            cars[carsMade] = car;
        }

        void deleteListingButton_Click(object sender, EventArgs e, Panel panel)
        {
            int position = Int32.Parse(panel.Name);

            //Change locations of the panels
            for (int i = carsMade-1; i>position; i--)
            {
                panels[i].Location = panels[i - 1].Location;
            }

            //Dispose of the deleted panel, free the array index
            panels[position].Dispose();
            panels[position] = null;
            cars[position] = null;

            //Set the array to the proper order
            for(int i = position; i<carsMade-1; i++)
            {
                panels[i] = panels[i + 1];
                panels[i].Name = i.ToString();
                cars[i] = cars[i + 1];
            }
            //Free the last listing in array (its moved to the second to last)
            panels[carsMade - 1] = null;
            cars[carsMade - 1] = null;

            carsMade -= 1;

            //Change xplace and yplace to the correct coordinates
            if (xplace - 1 < 0)
            {
                xplace = 2;
                yplace -= 1;
            }
            else
            {
                xplace -= 1;
            }

        }



        void savePanels()
        {
            //The listing info is saved into a .txt file
            //The file needs all the info from the panel saved to it

            string path = @"..\carsSaveFile.txt";
            
            //Create the file if it doesnt already exist
            if (File.Exists(path) != true)
            {
                FileStream temp = File.Create(path);
                temp.Close();
            }

            //Make the SavedImages file empty
            if (Directory.Exists(@"..\SavedImages") == true)
            {
                Directory.Delete(@"..\SavedImages", true);
                Directory.CreateDirectory(@"..\SavedImages");
            }
            else
            {
                Directory.CreateDirectory(@"..\SavedImages");
            }

            FileStream fsWrite = new FileStream(path, FileMode.Create, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fsWrite))
            {
                //Write the cars data to file
                for (int i = 0; i < carsMade; i++)
                {
                    sw.WriteLine(cars[i].name + ";" + cars[i].brand + ";" + cars[i].year + ";" + cars[i].odometer + ";" + cars[i].pricePerHour);
                    //Save the car iamge to SavedImages file
                    cars[i].image.Save(@"..\SavedImages\" + (i + 1).ToString() + ".png");
                }

                MessageBox.Show("Successfully saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            fsWrite.Close();

        }

        private void selectCarImageButton_Click(object sender, EventArgs e)
        {
            //Create dialog box so the user can select the correct image
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                carImageBitmap = new Bitmap(open.FileName);
            }
            selectCarImageButton.Text = Path.GetFileName(open.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savePanels();
        }
    }
}
