using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;


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
            createNewCarPanel(form.carsMade, newCar, form);
            form.visiblePanel.Visible = false;
            form.visiblePanel = form.basePanel;
            form.carsMade++;
        }

        public static void createNewCarPanel(int carsMade, Car car, Form1 form)
        {
            int numOfInfoBoxes = 6;

            Panel panel = new Panel();
            Label[] textBoxes = new Label[numOfInfoBoxes];

            Size TextBoxSize = new Size(104, 16);
            panel.Location = new Point(150 + 130 * form.xplace, 10 + 270 * form.yplace);

            //Change x and y place for next panel
            form.xplace++;
            if (form.xplace >= 3)
            {
                form.yplace++;
                form.xplace = 0;
            }


            panel.Size = new Size(124, 270);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


            form.Controls.Add(panel);


            //Create the pictureBox for car imaage
            PictureBox carImage = new PictureBox();
            carImage.Location = new Point(10, 10);
            carImage.Size = new Size(104, 60);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.Image = car.image;

            panel.Controls.Add(carImage);


            //Make the buttons, change numOfInfoBoxes to increase buttons
            for (int i = 0; i < numOfInfoBoxes; i++)
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
            deleteListingButton.Click += new EventHandler((sender, e) => form.deleteListingButton_Click(sender, e, panel));

            panel.Controls.Add(deleteListingButton);

            //Poor solution, no easier way to do it
            textBoxes[0].Text = "Name: " + car.name;
            textBoxes[1].Text = "Brand: " + car.brand;
            textBoxes[2].Text = "Year: " + car.year;
            textBoxes[3].Text = "Odometer: " + car.odometer;
            textBoxes[4].Text = "Price/h: " + "$" + car.pricePerHour;
            textBoxes[5].Text = panel.Name;

            form.panels[carsMade] = panel;
            form.cars[carsMade] = car;
        }


        public static void deleteListing(Form1 form,Panel panel)
        {
            int position = Int32.Parse(panel.Name);

            //Change locations of the panels
            for (int i = form.carsMade - 1; i > position; i--)
            {
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
                form.xplace = 2;
                form.yplace -= 1;
            }
            else
            {
                form.xplace -= 1;
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
    }
}
