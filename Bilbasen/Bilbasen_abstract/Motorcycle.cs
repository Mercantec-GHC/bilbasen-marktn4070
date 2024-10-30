using System;

namespace Bilbasen_abstract
{
    public class Motorcycle : Vehicle
    {
        private bool HasSidecar;



        public bool Motorcycle_HasSidecar
        {
            get { return HasSidecar; }
            set { HasSidecar = value; }
        }

        public Motorcycle(string brand, string model, int year, string color, bool hasSidecar)
            : base(brand, model, year, color)
        {
            HasSidecar = hasSidecar;
        }

        public override string GetVehicleInfo()
        {
            return $"Motorcycle - Brand: {Vehicle_Brand}, Model: {Vehicle_Model}, Year: {Vehicle_Year}, Color: {Vehicle_Color}, Sidecar: {Motorcycle_HasSidecar}";
        }
    }
}
