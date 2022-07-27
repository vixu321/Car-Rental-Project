using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace CarRentalProject
{
    static class saveAndLoad
    {
        
        public static void savePanels(Form1 form)
        {
            //The listing info is saved into a .txt file

            string path = @"..\carsSaveFile.txt";

            //Create the file if it doesnt already exist
            if (File.Exists(path) != true)
            {
                FileStream temp = File.Create(path);
                temp.Close();
            }

            Directory.CreateDirectory(@"..\SavedImages");

            FileStream fsWrite = new FileStream(path, FileMode.Create, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fsWrite))
            {
                //Write the cars data to file
                for (int i = 0; i < form.carsMade; i++)
                {
                    sw.WriteLine(form.cars[i].name);
                    sw.WriteLine(form.cars[i].brand);
                    sw.WriteLine(form.cars[i].year);
                    sw.WriteLine(form.cars[i].odometer);
                    sw.WriteLine(form.cars[i].pricePerHour);
                    sw.WriteLine();

                    //Save the car iamge to SavedImages file
                    if (File.Exists(@"..\SavedImages\" + (i + 1).ToString() + ".png"))
                    {
                        File.Delete(@"..\SavedImages\" + (i + 1).ToString() + ".png");
                    }

                    Bitmap test = (Bitmap)form.cars[i].image.Clone();
                    test.Save(@"..\SavedImages\" + (i + 1).ToString() + ".png");
                    test.Dispose();
                }

                MessageBox.Show("Successfully saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            fsWrite.Close();

        }

        public static void saveRentedPanels(Form1 form)
        {
            //The listing info is saved into a .txt file

            string path = @"..\carsSaveFileRented.txt";

            //Create the file if it doesnt already exist
            if (File.Exists(path) != true)
            {
                FileStream temp = File.Create(path);
                temp.Close();
            }

            Directory.CreateDirectory(@"..\SavedImagesRented");

            FileStream fsWrite = new FileStream(path, FileMode.Create, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fsWrite))
            {
                //Write the cars data to file
                for (int i = 0; i < form.carsRentedNumber; i++)
                {
                    sw.WriteLine(form.rentedCars[i].name);
                    sw.WriteLine(form.rentedCars[i].brand);
                    sw.WriteLine(form.rentedCars[i].year);
                    sw.WriteLine(form.rentedCars[i].odometer);
                    sw.WriteLine(form.rentedCars[i].pricePerHour);
                    sw.WriteLine(form.hoursRented[i]);
                    sw.WriteLine();

                    //Save the car iamge to SavedImages file
                    if (File.Exists(@"..\SavedImagesRented\" + (i + 1).ToString() + ".png"))
                    {
                        File.Delete(@"..\SavedImagesRented\" + (i + 1).ToString() + ".png");
                    }

                    Bitmap test = (Bitmap)form.rentedCars[i].image.Clone();
                    test.Save(@"..\SavedImagesRented\" + (i + 1).ToString() + ".png");
                    test.Dispose();
                }

                MessageBox.Show("Successfully saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            fsWrite.Close();

        }



        public static void loadSave(Form1 form, bool showNotification)
        {
            string path = @"..\carsSaveFile.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("No save file found!", "Loading error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string line;
            int index = 0;
            int iteration = 0;
            string Name = "", Brand = "", Year = "", Odo = "", Price = "";

            if (!File.Exists(path))
            {
                MessageBox.Show("No save file found!", "Loading error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int temp = form.carsMade;

            //Delete existing panels
            if (form.panels[0] != null)
            {
                for (int i = 0; i < temp; i++)
                {
                    carListings.deleteListing(form, form.panels[0]);
                }
                
            }

            FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);

            //Write the lines from file to strings, then create Car class with those strings
            using (StreamReader sr = new StreamReader(fsRead))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    switch (iteration)
                    {
                        case 0:
                            Name = line;
                            iteration++;
                            break;
                        case 1:
                            Brand = line;
                            iteration++;
                            break;
                        case 2:
                            Year = line;
                            iteration++;
                            break;
                        case 3:
                            Odo = line;
                            iteration++;
                            break;
                        case 4:
                            Price = line;
                            iteration++;
                            break;
                        case 5:
                            //Retrieve the image for car class, cant use Bitmap.Clone() because it maintains memory stream, which is a problem in the save method
                            Bitmap original = new Bitmap(@"..\SavedImages\" + (index + 1).ToString() + ".png");
                            form.carImageBitmaps[index] = new Bitmap(original);
                            original.Dispose();
                            //Create Car class and panels with the data from the file
                            Car car = new Car(Name, Brand, Year, Odo, Price, form.carImageBitmaps[index]);
                            form.cars[index] = car;
                            System.Diagnostics.Debug.WriteLine("Creating car panel with name: " + Name + ", at index: " + index + "At x: "+form.xplace +"; y:"+form.yplace);
                            carListings.createNewCarPanel(index, car, form, form.carListingsPanel, false);
                            index++;
                            iteration = 0;
                            break;
                    }

                }

            }
            form.carsMade = index;
            
            fsRead.Close();
            //Set the copy of the original fiels to the bitmap array
            //Cant use Bitmap.Clone() because it maintains the memory stream, which later on makes problems with save function
            
            if (showNotification)
                MessageBox.Show("Successfully loaded the save file!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void loadSaveRented(Form1 form, bool showNotification)
        {
            string path = @"..\carsSaveFileRented.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("No save file found!", "Loading error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string line;
            int index = 0;
            int iteration = 0;
            string Name = "", Brand = "", Year = "", Odo = "", Price = "", RentedUntil = "";

            if (!File.Exists(path))
            {
                MessageBox.Show("No save file found!", "Loading error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int temp = form.carsRentedNumber;

            //Delete existing panels
            if (form.rentedPanels[0] != null)
            {
                form.rentedCarsPanel.Controls.Clear();
                form.xplaceRented = 0;
                form.yplaceRented = 0;
            }

            FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);

            //Write the lines from file to strings, then create Car class with those strings
            using (StreamReader sr = new StreamReader(fsRead))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    switch (iteration)
                    {
                        case 0:
                            Name = line;
                            iteration++;
                            break;
                        case 1:
                            Brand = line;
                            iteration++;
                            break;
                        case 2:
                            Year = line;
                            iteration++;
                            break;
                        case 3:
                            Odo = line;
                            iteration++;
                            break;
                        case 4:
                            Price = line;
                            iteration++;
                            break;
                        case 5:
                            RentedUntil = line;
                            iteration++;
                            break;
                        case 6:
                            //Retrieve the image for car class, cant use Bitmap.Clone() because it maintains memory stream, which is a problem in the save method
                            Bitmap original = new Bitmap(@"..\SavedImagesRented\" + (index + 1).ToString() + ".png");
                            form.carImageBitmaps[index] = new Bitmap(original);
                            original.Dispose();
                            //Create Car class and panels with the data from the file
                            Car car = new Car(Name, Brand, Year, Odo, Price, form.carImageBitmaps[index]);
                            form.rentedCars[index] = car;
                            System.Diagnostics.Debug.WriteLine(form.rentedCars[0].name);

                            //System.Diagnostics.Debug.WriteLine("Creating car panel with name: " + Name + ", at index: " + index + "At x: " + form.xplace + "; y:" + form.yplace);
                            carListings.createNewCarPanel(index, car, form, form.rentedCarsPanel, true);
                            index++;
                            iteration = 0;
                            break;
                    }

                }

            }
            form.carsRentedNumber = index;

            fsRead.Close();
            //Set the copy of the original fiels to the bitmap array
            //Cant use Bitmap.Clone() because it maintains the memory stream, which later on makes problems with save function

            if (showNotification)
                MessageBox.Show("Successfully loaded the save file!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
