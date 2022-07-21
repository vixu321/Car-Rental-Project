using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CarRentalProject
{
    public class Car
    {
        public Car(string CarName, string CarBrand, string Year, string Odometer, string PricePerHour, Bitmap CarImage)
        {
            name = CarName;
            brand = CarBrand;
            year = Year;
            odometer = Odometer;
            pricePerHour = PricePerHour;
            image = CarImage;
        }
        public string name { get; set; }
        public string brand { get; set; }
        public string year { get; set; }
        public string odometer { get; set; }
        public string pricePerHour { get; set; }
        public Bitmap image { get; set; }
        
    }
}
