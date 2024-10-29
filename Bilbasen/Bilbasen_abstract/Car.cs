
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilbasen_abstract
{
    public class Car
    {
        private String Brand;
        private String Model;
        private int Year;
        private String Color;
        private int HorsePower;
        private int NumberOfCylinders;


        public String Car_Brand
        {
            get { return Brand; }
            set { Brand = value; }
        }
        public String Car_Model
        {
            get { return Model; }
            set { Model = value; }
        }
        public int Car_Year
        {
            get { return Year; }
            set { Year = value; }
        }
        public String Car_Color
        {
            get { return Color; }
            set { Color = value; }
        }
        public int Car_HorsePower
        {
            get { return HorsePower; }
            set { HorsePower = value; }
        }
        public int Car_NumberOfCylinders
        {
            get { return NumberOfCylinders; }
            set { NumberOfCylinders = value; }
        }

        public Car(string brand, string model, int year, string color, int horsePower, int numberOfCylinders)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            HorsePower = horsePower;
            NumberOfCylinders = numberOfCylinders;
        }
    }

}
