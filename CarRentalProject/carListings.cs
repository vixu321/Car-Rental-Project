using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Linq;



namespace CarRentalProject
{
    public static class carListings
    {
        public static void createCarListing(Form1 form)
        {
            form.carImageBitmaps[form.carsMade] = form.tempBitmap;
            form.tempBitmap = null;
            Car newCar = new Car(form.carNameTextBox.Text, form.carBrandTextBox.Text, form.carYearTextBox.Text, form.carOdoTextBox.Text, form.carPriceTextBox.Text, form.carImageBitmaps[form.carsMade]);
            if (form.carNameTextBox.Text == "" || form.carBrandTextBox.Text == "" || form.carYearTextBox.Text == "" || form.carOdoTextBox.Text == "" || form.carPriceTextBox.Text == "" || form.carImageBitmaps[form.carsMade] == null)
            {
                MessageBox.Show("Some car info is missing!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        

            createNewCarPanel(form.carsMade, newCar, form, false);
            form.visiblePanel.Visible = false;
            form.visiblePanel = form.basePanel;
            form.carsMade++;
        }

        static int numOfInfoBoxes = 5;

        public static void createNewCarPanel(int carsMade, Car car, Form1 form, bool isRented)
        {
            Panel panel = new Panel();
            
            Label[] textBoxes = new Label[numOfInfoBoxes];
            int x = 0, y = 0;

            if(isRented)
                panel.Location = new Point(150 + 150 * form.xplace, 10 + 300 * form.yplace);
            else
                panel.Location = new Point(150 + 150 * form.xplaceRented, 10 + 300 * form.yplaceRented);



            Size TextBoxSize = new Size(104, 16);

            //Change x and y place for next panel
            form.xplace++;
            if (form.xplace >= form.numOfCarsInRow)
            {
                form.yplace++;
                form.xplace = 0;
            }
            x = form.xplace;
            y = form.yplace;

            if (isRented)
            {
                form.xplaceRented++;
                if (form.xplaceRented >= form.numOfCarsInRow)
                {
                    form.yplaceRented++;
                    form.xplaceRented = 0;
                }
                x = form.xplaceRented;
                y = form.yplaceRented;
            }



            panel.Size = new Size(140, 290);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


            form.Controls.Add(panel);


            //Create the pictureBox for car imaage
            PictureBox carImage = new PictureBox();
            carImage.Location = new Point(10, 10);
            carImage.Size = new Size(120, 74);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.Image = car.image;

            panel.Controls.Add(carImage);


            //Make the buttons, change numOfInfoBoxes to increase buttons
            for (int i = 0; i < numOfInfoBoxes; i++)
            {
                textBoxes[i] = new Label();
                textBoxes[i].Location = new Point(10, 105 + 25 * i);
                textBoxes[i].Size = TextBoxSize;
                textBoxes[i].ForeColor = Color.White;
                textBoxes[i].Name = i.ToString();
                panel.Controls.Add(textBoxes[i]);
            }

            //Create button for deleteing the listing
            Button deleteListingButton = new Button();
            deleteListingButton.Text = "Delete listing";
            deleteListingButton.Location = new Point(10, 105 + 25 * numOfInfoBoxes);
            deleteListingButton.BackColor = Color.White;
            deleteListingButton.ForeColor = Color.Black;
            deleteListingButton.Name = "deleteListingButton";
            


            panel.Name = carsMade.ToString();

            form.deleteListingClick(panel);
            //Set the click event, send panel through the arguments
            deleteListingButton.Click += form.deleteclick;

            panel.Controls.Add(deleteListingButton);

            //Poor solution, no easier way to do it
            textBoxes[0].Text = "Name: " + car.name;
            textBoxes[1].Text = "Brand: " + car.brand;
            textBoxes[2].Text = "Year: " + car.year;
            textBoxes[3].Text = "Odometer: " + car.odometer;
            textBoxes[4].Text = "Price/h: " + "$" + car.pricePerHour;

            form.panels[carsMade] = panel;
            form.cars[carsMade] = car;
            if (!isRented)
                form.carListingsPanel.Controls.Add(panel);
            else
            {
                form.rentedCarsPanel.Controls.Add(panel);
            }
        }


        public static void deleteListing(Form1 form, Panel panel)
        {
            int position = Int32.Parse(panel.Name);
            //System.Diagnostics.Debug.WriteLine("Deleteing position: " + position+", cars made: "+form.carsMade);
            //Change locations of the panels
            for (int i = form.carsMade - 1; i > position; i--)
            {
                //System.Diagnostics.Debug.WriteLine("Changing position: " + i + ", with: " + (i-1));
                form.panels[i].Location = form.panels[i - 1].Location;
            }

            //Dispose of the deleted panel, free the array index
            form.panels[position].Dispose();
            form.panels[position] = null;
            form.cars[position] = null;

            //Set the array to the proper order
            for (int i = position; i < form.carsMade - 1; i++)
            {
                form.panels[i] = form.panels[i + 1];
                form.panels[i].Name = i.ToString();
                form.cars[i] = form.cars[i + 1];
            }
            //Free the last listing in array (its moved to the second to last)
            form.panels[form.carsMade - 1] = null;
            form.cars[form.carsMade - 1] = null;

            form.carsMade -= 1;

            //Change xplace and yplace to the correct coordinates
            if (form.xplace - 1 < 0)
            {
                form.xplace = form.numOfCarsInRow-1;
                form.yplace -= 1;
            }
            else
            {
                form.xplace -= 1;
            }
        }

        public static void deleteRented(Form1 form, Panel panel)
        {
            int position = Int32.Parse(panel.Name);
            //System.Diagnostics.Debug.WriteLine("Deleteing position: " + position+", cars made: "+form.carsMade);
            //Change locations of the panels
            for (int i = form.carsRentedNumber - 1; i > position; i--)
            {
                //System.Diagnostics.Debug.WriteLine("Changing position: " + i + ", with: " + (i-1));
                form.rentedPanels[i].Location = form.rentedPanels[i - 1].Location;
            }

            //Dispose of the deleted panel, free the array index
            form.rentedPanels[position].Dispose();
            form.rentedPanels[position] = null;
            form.rentedCars[position] = null;

            //Set the array to the proper order
            for (int i = position; i < form.carsRentedNumber - 1; i++)
            {
                form.rentedPanels[i] = form.rentedPanels[i + 1];
                form.rentedPanels[i].Name = i.ToString();
                form.rentedCars[i] = form.rentedCars[i + 1];
            }
            //Free the last listing in array (its moved to the second to last)
            form.rentedPanels[form.carsRentedNumber - 1] = null;
            form.rentedCars[form.carsRentedNumber - 1] = null;

            form.carsRentedNumber -= 1;

            //Change xplace and yplace to the correct coordinates
            if (form.xplaceRented - 1 < 0)
            {
                form.xplaceRented = form.numOfCarsInRow - 1;
                form.yplaceRented -= 1;
            }
            else
            {
                form.xplaceRented -= 1;
            }
        }

        public static void selectCarImage(Form1 form)
        {
            //Create dialog box so the user can select the correct image
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                form.tempBitmap = new Bitmap(open.FileName);
            }

            form.selectCarImageButton.Text = Path.GetFileName(open.FileName);
        }

        public static void userSideListings(Form1 form)
        {
            
            for (int i = 0; i < form.carsMade; i++)
            {
                //Remove the delete listing button from listings
                foreach (Control item in form.panels[i].Controls.OfType<Control>().ToList())
                {
                
                    if (item.Name == "deleteListingButton")
                        form.panels[i].Controls.Remove(item);
                }

                //Create the rent car button
                Button rentCarButton = new Button();
                rentCarButton.Text = "Rent car";
                rentCarButton.Location = new Point(10, 105 + 25 * numOfInfoBoxes);
                rentCarButton.BackColor = Color.White;
                rentCarButton.ForeColor = Color.Black;
                rentCarButton.Name = "rentCarButton";

                form.rentCarClick(form.panels[i]);
                //Set the click event, send panel through the arguments
                rentCarButton.Click += form.rentclick;

                form.panels[i].Controls.Add(rentCarButton);

            }


        }


        public static Panel examinedPanel;
        private static bool isRenting = false;
        static Form1 examinedForm;

        public static void rentCar(Form1 form, Panel panel)
        {
            int position = Int32.Parse(panel.Name);
            examinedForm = form;

            //Check if button has been clicked already
            if (panel.Size.Height ==290 && isRenting == false)
            {
                examinedPanel = panel;
                isRenting = true;
                panel.Size += new Size(0, 75);
                for(int i = 0; i<form.carsMade; i++)
                {
                    foreach (Control item in form.panels[i].Controls.OfType<Control>().ToList())
                    {
                        if (item.Name == "rentCarButton" && form.panels[i]!=panel)
                            item.Visible = false;
                    }
                }

                foreach (Control item in panel.Controls.OfType<Control>().ToList())
                {
                    if (item.Name == "rentCarButton")
                        item.Location = new Point(10, 175 + 25 * numOfInfoBoxes);
                }


                Button cancelButton = new Button();
                cancelButton.Text = "Cancel";
                cancelButton.Location = new Point(10, 205 + 25 * numOfInfoBoxes);
                cancelButton.BackColor = Color.White;
                cancelButton.ForeColor = Color.Black;
                cancelButton.Name = "cancelButton";
                cancelButton.Click += new EventHandler(cancelButtonClick);

                NumericUpDown hoursCounter = new NumericUpDown();
                hoursCounter.Minimum = 0;
                hoursCounter.Maximum = 100;
                hoursCounter.Location = new Point(60, 102 + 25 * numOfInfoBoxes);
                hoursCounter.BackColor = Color.White;
                hoursCounter.ForeColor = Color.Black;
                hoursCounter.Name = "hoursCounter";
                hoursCounter.Increment = 0.5M;
                hoursCounter.DecimalPlaces = 1;
                hoursCounter.Size = new Size(60, 30);

                Label hoursLabel = new Label();
                hoursLabel.Location = new Point(10, 105 + 25 * numOfInfoBoxes);
                hoursLabel.ForeColor = Color.White;
                hoursLabel.Text = "Hours: ";
                hoursLabel.Size = new Size(45, 30);

                Label priceLabel = new Label();
                priceLabel.Location = new Point(10, 145 + 25 * numOfInfoBoxes);
                priceLabel.ForeColor = Color.White;
                priceLabel.Name = "priceLabel";

                form.hoursChangedValue(hoursCounter, position);
                //Set the click event, send panel through the arguments
                hoursCounter.ValueChanged += form.hoursChanged;

                panel.Controls.Add(hoursLabel);
                panel.Controls.Add(cancelButton);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(hoursCounter);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Rented a car"+position+cost);
                form.userBalance -= cost;
                form.accountBalanceLabel.Text = "Balance: $"+form.userBalance.ToString();
                MessageBox.Show("Succssfully rented car: " + form.cars[position].name+" for $"+cost+", current balance: $"+form.userBalance, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cancelButtonClicked();
                form.rentedCars[form.carsRentedNumber] = form.cars[position];
                form.rentedPanels[form.carsRentedNumber] = form.panels[position];
                form.carsRentedNumber++;
                deleteListing(form, panel);
            }

        }
        private static float hours;

        static float cost;
        public static void hoursChangedControl(Form1 form, NumericUpDown numeric, int position)
        {
            System.Diagnostics.Debug.WriteLine(numeric.Value);
            hours= (float)numeric.Value;
            float price = float.Parse(form.cars[position].pricePerHour);
            cost = hours * price;

            foreach (Control item in examinedPanel.Controls.OfType<Control>().ToList())
            {
                if (item.Name == "priceLabel")
                    item.Text = "Cost: $"+cost.ToString();
            }
        }

        private static void cancelButtonClick(object sender, EventArgs e)
        {
            cancelButtonClicked();
        }

       
        public static void cancelButtonClicked()
        {
            foreach (Control item in examinedPanel.Controls.OfType<Control>().ToList())
            {
                if (item.Name == "rentCarButton")
                    item.Location = new Point(10, 105 + 25 * numOfInfoBoxes);
                if (item.Name == "priceLabel")
                    item.Dispose();
                if (item.Name == "hoursCounter")
                    item.Dispose();
            }
            for (int i = 0; i < examinedForm.carsMade; i++)
            {
                foreach (Control item in examinedForm.panels[i].Controls.OfType<Control>().ToList())
                {
                    if (item.Name == "rentCarButton")
                        item.Visible = true;
                }
            }

            examinedPanel.Height = 290;
            isRenting = false;
        }

        public static void showRentedCars(Form1 form)
        {
            form.rentedCarsPanel.Visible = true;
            form.carListingsPanel.Visible = false;

            for (int i = 0; i<form.carsRentedNumber; i++)
            {
                System.Diagnostics.Debug.WriteLine(form.rentedCars[i].name);

                createNewCarPanel(i, form.rentedCars[i], form, true);
            }
        }

        public static void showListings(Form1 form)
        {
            form.carListingsPanel.Visible = true;
            form.rentedCarsPanel.Visible = false;
        }

    }
    }
    

