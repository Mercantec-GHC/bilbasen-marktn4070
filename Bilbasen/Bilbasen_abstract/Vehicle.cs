using System;

namespace Bilbasen_abstract
{
    public abstract class Vehicle
    {
        private string Brand;
        private string Model;
        private int Year;
        private string Color;

        public string Vehicle_Brand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public string Vehicle_Model
        {
            get { return Model; }
            set { Model = value; }
        }

        public int Vehicle_Year
        {
            get { return Year; }
            set { Year = value; }
        }

        public string Vehicle_Color
        {
            get { return Color; }
            set { Color = value; }
        }

        public Vehicle(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }

        public abstract string GetVehicleInfo();
    }
}
