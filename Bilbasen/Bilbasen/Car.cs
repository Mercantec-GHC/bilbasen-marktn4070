namespace DomainModels
{
    /*
    public class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }
        public int HoursePower { get; set; }
        public int NumberOfCylinders { get; set; }

        public Car(string? brand, string? model, int year, string? color, int hoursePower)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            HoursePower = hoursePower;
        }
    }
    */

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
