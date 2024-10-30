using System;

namespace Bilbasen_abstract
{
    public class Car : Vehicle
    {
        private int HorsePower;
        private int NumberOfCylinders;

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
            : base(brand, model, year, color)
        {
            HorsePower = horsePower;
            NumberOfCylinders = numberOfCylinders;
        }

        public override string GetVehicleInfo()
        {
            return $"Car - Brand: {Vehicle_Brand}, Model: {Vehicle_Model}, Year: {Vehicle_Year}, Color: {Vehicle_Color}, HorsePower: {Car_HorsePower}, Cylinders: {Car_NumberOfCylinders}";
        }
    }
}
