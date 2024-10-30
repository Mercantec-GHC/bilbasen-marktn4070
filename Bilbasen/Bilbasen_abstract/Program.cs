using System;
using Bilbasen_abstract;

namespace Bilbasen
{
    public class Program
    {
        static void Main()
        {
            Car[] cars = new Car[]
            {
        new Car("Ford", "Mustang", 1963, "Red", 430, 8),
        new Car("Toyota", "Camry", 2020, "Blue", 200, 6),
        new Car("Chevrolet", "Corvette", 2022, "Silver", 650, 8),
        new Car("BMW", "X5", 2021, "Black", 450, 6),
        new Car("Honda", "Civic", 2018, "White", 158, 4),
        new Car("Nissan", "Altima", 2019, "Gray", 188, 4),
        new Car("Volkswagen", "Golf", 2015, "Blue", 170, 4),
        new Car("Audi", "A4", 2017, "Red", 252, 4),
        new Car("Mercedes", "E-Class", 2016, "Silver", 302, 6),
        new Car("Volvo", "XC90", 2018, "Black", 316, 4),
        new Car("Ford", "Focus", 2019, "White", 160, 4),
        new Car("Toyota", "Corolla", 2017, "Green", 132, 4),
        new Car("Chevrolet", "Malibu", 2020, "Silver", 160, 4),
        new Car("BMW", "3 Series", 2014, "Blue", 180, 4),
        new Car("Honda", "Accord", 2015, "Gray", 185, 4),
        new Car("Nissan", "Sentra", 2018, "Red", 149, 4),
        new Car("Volkswagen", "Passat", 2016, "Blue", 174, 4),
        new Car("Audi", "Q7", 2020, "Black", 335, 6),
        new Car("Mercedes", "GLC", 2019, "White", 255, 4),
        new Car("Volvo", "S60", 2021, "Gray", 250, 4),
        new Car("Ford", "Explorer", 2017, "Red", 290, 6),
        new Car("Toyota", "Highlander", 2018, "Silver", 295, 6),
        new Car("Chevrolet", "Tahoe", 2021, "Blue", 355, 8),
        new Car("BMW", "5 Series", 2019, "Black", 248, 6),
        new Car("Honda", "HR-V", 2020, "Green", 141, 4),
        new Car("Nissan", "Rogue", 2021, "Silver", 181, 4),
        new Car("Volkswagen", "Jetta", 2015, "White", 170, 4),
        new Car("Audi", "A3", 2018, "Red", 228, 4),
        new Car("Mercedes", "CLA", 2017, "Gray", 208, 4),
        new Car("Volvo", "V90", 2018, "Black", 316, 4),
        new Car("Ford", "Ranger", 2020, "Blue", 270, 4),
        new Car("Toyota", "Tacoma", 2019, "White", 278, 6),
        new Car("Chevrolet", "Silverado", 2020, "Red", 420, 8),
        new Car("BMW", "X3", 2019, "Silver", 248, 4),
        new Car("Honda", "Pilot", 2020, "Black", 280, 6),
        new Car("Nissan", "Murano", 2021, "Gray", 260, 6),
        new Car("Volkswagen", "Tiguan", 2018, "Blue", 184, 4),
        new Car("Audi", "Q5", 2021, "White", 261, 4),
        new Car("Mercedes", "GLA", 2020, "Silver", 221, 4),
        new Car("Volvo", "XC40", 2019, "Red", 248, 4),
        new Car("Ford", "F-150", 2017, "Blue", 450, 8),
        new Car("Toyota", "RAV4", 2018, "White", 203, 4),
        new Car("Chevrolet", "Blazer", 2021, "Gray", 308, 6),
        new Car("BMW", "X1", 2020, "Silver", 228, 4),
        new Car("Honda", "CR-V", 2019, "Black", 190, 4),
        new Car("Nissan", "Kicks", 2020, "White", 125, 4),
        new Car("Volkswagen", "Arteon", 2021, "Red", 268, 4),
        new Car("Audi", "A6", 2017, "Gray", 335, 6),
        new Car("Mercedes", "S-Class", 2016, "Blue", 449, 8),
        new Car("Volvo", "S90", 2018, "Black", 316, 4),
        new Car("Volvo", "XC70", 2019, "Green", 316, 4),
        new Car("Ford", "Edge", 2021, "Silver", 250, 4),
        new Car("Toyota", "Avalon", 2019, "Black", 301, 6),
        new Car("Chevrolet", "Impala", 2017, "Blue", 305, 6),
        new Car("BMW", "7 Series", 2021, "Gray", 335, 6),
        new Car("Honda", "Insight", 2018, "White", 151, 4),
        new Car("Nissan", "Pathfinder", 2020, "Red", 284, 6),
        new Car("Volkswagen", "Atlas", 2019, "Silver", 276, 6),
        new Car("Audi", "A8", 2016, "Black", 333, 8),
        new Car("Mercedes", "GLB", 2021, "White", 221, 4),
        new Car("Volvo", "S70", 2017, "Red", 240, 4),
        new Car("Ford", "Bronco", 2022, "Green", 300, 6),
        new Car("Toyota", "4Runner", 2015, "Blue", 270, 6),
        new Car("Chevrolet", "Equinox", 2018, "Gray", 252, 4),
        new Car("BMW", "X6", 2019, "Silver", 335, 6),
        new Car("Honda", "Passport", 2020, "Black", 280, 6),
        new Car("Nissan", "Armada", 2021, "Red", 400, 8),
        new Car("Volkswagen", "Touareg", 2017, "White", 276, 6),
        new Car("Audi", "SQ5", 2022, "Gray", 349, 6),
        new Car("Mercedes", "AMG C", 2020, "Blue", 385, 4),
        new Car("Volvo", "V60", 2018, "Green", 250, 4),
        new Car("Ford", "Expedition", 2019, "Silver", 375, 6),
        new Car("Toyota", "Land Cruiser", 2021, "Black", 381, 8),
        new Car("Chevrolet", "Traverse", 2020, "White", 310, 6),
        new Car("BMW", "M4", 2018, "Gray", 425, 6),
        new Car("Honda", "Odyssey", 2017, "Blue", 280, 6),
        new Car("Nissan", "Maxima", 2022, "Silver", 300, 6),
        new Car("Volkswagen", "Beetle", 2019, "Red", 174, 4),
        new Car("Audi", "TT", 2020, "Black", 228, 4),
        new Car("Mercedes", "GLE", 2018, "White", 385, 6),
        new Car("Volvo", "C30", 2019, "Green", 248, 4),
        new Car("Ford", "Fusion", 2020, "Silver", 245, 4),
        new Car("Toyota", "Sequoia", 2021, "Gray", 381, 8),
        new Car("Chevrolet", "Spark", 2016, "Red", 98, 4),
        new Car("BMW", "Z4", 2017, "Blue", 255, 4),
        new Car("Honda", "Fit", 2018, "Gray", 130, 4),
        new Car("Nissan", "Versa", 2021, "Silver", 122, 4),
        new Car("Volkswagen", "CC", 2015, "Black", 200, 4),
        new Car("Audi", "RS3", 2018, "White", 400, 5),
        new Car("Mercedes", "AMG GLE", 2022, "Gray", 429, 8),
        new Car("Volvo", "XC60", 2017, "Red", 316, 4),
        new Car("Ford", "Maverick", 2022, "Blue", 250, 4),
        new Car("Toyota", "Venza", 2021, "Black", 219, 4),
        new Car("Chevrolet", "Trailblazer", 2019, "Silver", 155, 3),
        new Car("BMW", "8 Series", 2020, "White", 335, 6),
        new Car("Honda", "Element", 2011, "Green", 166, 4),
        new Car("Nissan", "Frontier", 2020, "Gray", 310, 6),
        new Car("Volkswagen", "Scirocco", 2016, "Red", 210, 4),
        new Car("Audi", "Allroad", 2019, "Blue", 248, 4),
        new Car("Mercedes", "AMG GT S", 2016, "Silver", 523, 8),
        new Car("Volvo", "XC20", 2021, "Gray", 248, 4)
        };
            /**/
            Motorcycle[] motorcycles = new Motorcycle[]
        {
                        new Motorcycle("Harley-Davidson", "Street 750", 2020, "Black", 750, 2),
                        new Motorcycle("Kawasaki", "Ninja 300", 2021, "Green", 300, 2),
                        new Motorcycle("Yamaha", "YZF-R3", 2021, "Blue", 320, 2),
                        new Motorcycle("Ducati", "Monster 821", 2019, "Red", 821, 2),
                        new Motorcycle("BMW", "S1000RR", 2022, "White", 200, 4),
                        new Motorcycle("Suzuki", "GSX-R1000", 2021, "Blue", 199, 4),
                        new Motorcycle("Honda", "CBR600RR", 2020, "Black", 120, 4),
                        new Motorcycle("KTM", "RC390", 2021, "Orange", 43, 1),
                        new Motorcycle("Triumph", "Street Triple", 2022, "Red", 765, 3),
                        new Motorcycle("Kawasaki", "Versys 650", 2019, "Green", 68, 2),
                        new Motorcycle("Harley-Davidson", "Iron 883", 2020, "Black", 883, 2),
                        new Motorcycle("Yamaha", "MT-07", 2022, "Gray", 75, 2),
                        new Motorcycle("Ducati", "Panigale V2", 2021, "Red", 155, 2),
                        new Motorcycle("BMW", "F850GS", 2019, "White", 95, 2),
                        new Motorcycle("Honda", "CB500F", 2020, "Black", 47, 2),
                        new Motorcycle("Suzuki", "SV650", 2021, "Blue", 75, 2),
                        new Motorcycle("KTM", "390 Duke", 2020, "Orange", 44, 1),
                        new Motorcycle("Triumph", "Bonneville T120", 2022, "Silver", 80, 2),
                        new Motorcycle("Harley-Davidson", "Road King", 2021, "Black", 107, 2),
                        new Motorcycle("Kawasaki", "Z900", 2019, "Green", 125, 4),
                        new Motorcycle("Yamaha", "FZ-09", 2020, "Blue", 115, 3),
                        new Motorcycle("Ducati", "Scrambler Icon", 2021, "Yellow", 73, 2),
                        new Motorcycle("BMW", "K1600GTL", 2019, "Gray", 160, 6),
                        new Motorcycle("Suzuki", "Hayabusa", 2021, "Black", 187, 4),
                        new Motorcycle("KTM", "1290 Super Duke R", 2022, "Orange", 177, 2),
                        new Motorcycle("Honda", "Gold Wing", 2020, "Blue", 125, 6),
                        new Motorcycle("Kawasaki", "Ninja H2", 2021, "Green", 228, 4),
                        new Motorcycle("Yamaha", "MT-09", 2019, "Black", 115, 3),
                        new Motorcycle("Ducati", "Multistrada V4", 2022, "Red", 170, 4),
                        new Motorcycle("BMW", "R1250GS", 2021, "White", 136, 2),
                        new Motorcycle("Harley-Davidson", "Fat Boy", 2020, "Black", 114, 2),
                        new Motorcycle("Suzuki", "Boulevard M109R", 2021, "Silver", 109, 2),
                        new Motorcycle("Triumph", "Rocket 3", 2022, "Red", 165, 3),
                        new Motorcycle("KTM", "690 Enduro R", 2020, "Orange", 74, 1),
                        new Motorcycle("Honda", "CRF1100L Africa Twin", 2021, "Black", 101, 2),
                        new Motorcycle("Yamaha", "XSR900", 2022, "Gray", 115, 3),
                        new Motorcycle("Ducati", "Streetfighter V4", 2021, "Red", 208, 4),
                        new Motorcycle("BMW", "R nineT", 2020, "White", 110, 2),
                        new Motorcycle("Harley-Davidson", "LiveWire", 2022, "Green", 105, 0),
                        new Motorcycle("Kawasaki", "W800", 2019, "Black", 48, 2),
                        new Motorcycle("Yamaha", "VMAX", 2020, "Black", 197, 4),
                        new Motorcycle("Suzuki", "V-Strom 1050", 2021, "Yellow", 107, 2),
                        new Motorcycle("Honda", "NC750X", 2022, "Black", 54, 2),
                        new Motorcycle("KTM", "790 Duke", 2020, "Orange", 105, 2),
                        new Motorcycle("Ducati", "Diavel 1260", 2021, "Red", 157, 2),
                        new Motorcycle("BMW", "F850R", 2020, "Gray", 90, 2),
                        new Motorcycle("Harley-Davidson", "Softail Slim", 2019, "Black", 107, 2),
                        new Motorcycle("Triumph", "Thruxton RS", 2021, "Red", 105, 2),
                        new Motorcycle("Kawasaki", "Z650", 2020, "Green", 68, 2),
                        new Motorcycle("Yamaha", "Tracer 900", 2021, "Blue", 115, 3),
                        new Motorcycle("Ducati", "Hyperstrada 939", 2019, "Red", 110, 2),
                        new Motorcycle("Suzuki", "GSX-S750", 2021, "Blue", 114, 4),
                        new Motorcycle("KTM", "450 SX-F", 2020, "Orange", 60, 1),
                        new Motorcycle("Honda", "Grom", 2022, "Black", 9, 1),
                        new Motorcycle("Harley-Davidson", "CVO Street Glide", 2021, "Silver", 117, 2),
                        new Motorcycle("BMW", "K1200LT", 2019, "Gray", 130, 4),
                        new Motorcycle("Yamaha", "YZF-R1", 2022, "Blue", 200, 4),
                        new Motorcycle("Kawasaki", "Ninja ZX-10R", 2021, "Green", 210, 4),
                        new Motorcycle("Ducati", "Panigale V4", 2020, "Red", 214, 4),
                        new Motorcycle("Honda", "CB1000R", 2022, "Black", 143, 4),
                        new Motorcycle("Suzuki", "GSX-S1000", 2020, "Blue", 150, 4),
                        new Motorcycle("Triumph", "Speed Triple 1200", 2021, "Gray", 178, 3),
                        new Motorcycle("KTM", "890 Duke", 2022, "Orange", 115, 2),
                        new Motorcycle("BMW", "S1000XR", 2021, "White", 165, 4),
                        new Motorcycle("Harley-Davidson", "Road Glide", 2022, "Black", 107, 2),
                        new Motorcycle("Yamaha", "FJR1300", 2020, "Silver", 146, 4),
                        new Motorcycle("Kawasaki", "Concours 14", 2021, "Green", 140, 4),
                        new Motorcycle("Ducati", "XDiavel", 2020, "Red", 126, 2),
                        new Motorcycle("Honda", "Rebel 500", 2021, "Black", 47, 2),
                        new Motorcycle("Suzuki", "SV650X", 2022, "Blue", 75, 2),
                        new Motorcycle("Triumph", "Scrambler 1200", 2021, "Red", 90, 2),
                        new Motorcycle("KTM", "1290 Super Adventure", 2021, "Orange", 160, 2),
                        new Motorcycle("BMW", "C400X", 2022, "Gray", 34, 1),
                        new Motorcycle("Harley-Davidson", "Street Rod", 2020, "Black", 750, 2),
                        new Motorcycle("Yamaha", "NMAX", 2021, "White", 15, 1),
                        new Motorcycle("Kawasaki", "Z125 Pro", 2020, "Green", 8, 1),
                        new Motorcycle("Ducati", "Monster 1100", 2019, "Red", 100, 2),
                        new Motorcycle("Honda", "CBR500R", 2022, "Black", 47, 2),
                        new Motorcycle("Suzuki", "GSX-R125", 2020, "Blue", 15, 1),
                        new Motorcycle("Triumph", "Tiger 900", 2021, "Gray", 95, 3),
                        new Motorcycle("KTM", "390 Adventure", 2021, "Orange", 44, 1),
                        new Motorcycle("BMW", "C650GT", 2020, "White", 60, 2),
                        new Motorcycle("Harley-Davidson", "Road King Special", 2021, "Black", 114, 2),
                        new Motorcycle("Yamaha", "TMAX", 2021, "Blue", 47, 2),
                        new Motorcycle("Kawasaki", "J300", 2020, "Green", 29, 1),
                        new Motorcycle("Ducati", "Multistrada 950", 2019, "Red", 113, 2),
                        new Motorcycle("Honda", "CB1100", 2021, "Black", 88, 4),
                        new Motorcycle("Suzuki", "V-Strom 650", 2020, "Blue", 71, 2),
                        new Motorcycle("Triumph", "Daytona Moto2", 2021, "Red", 123, 3),
                        new Motorcycle("KTM", "200 Duke", 2022, "Orange", 25, 1),
                        new Motorcycle("BMW", "G310R", 2021, "White", 34, 1),
                        new Motorcycle("Harley-Davidson", "Pan America", 2022, "Black", 125, 2),
                        new Motorcycle("Yamaha", "YZF-R125", 2020, "Blue", 15, 1),
                        new Motorcycle("Kawasaki", "KX450", 2021, "Green", 49, 1),
                        new Motorcycle("Ducati", "DesertX", 2022, "Red", 110, 2),
                        new Motorcycle("Honda", "CT125", 2021, "Black", 8, 1),
                        new Motorcycle("Suzuki", "SV650A", 2021, "Blue", 75, 2),
                        new Motorcycle("Triumph", "Bobber", 2021, "Gray", 78, 2)
        };
            /* */

            string filter_brand = "Ford";
            int filter_horsepower = 200;
            string filter_color = "Red";
            int filter_year_start = 1980;
            int filter_year_end = 1999;

            Console.WriteLine(Print_cars_with_brand(cars, filter_brand));
            Console.WriteLine(Print_cars_with_horsepower(cars, filter_horsepower));
            Console.WriteLine(Print_cars_with_color(cars, filter_color));
            Console.WriteLine(Print_cars_amount_of_brand(cars, filter_brand));
            Console.WriteLine(Print_cars_year(cars, filter_year_start, filter_year_end));
        }

        static string Print_cars_with_brand(Car[] cars, string filter_brand)
        {
            string result = "";
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Vehicle_Brand == filter_brand)
                {
                    result += $"Brand: {cars[i].Vehicle_Brand} {cars[i].Vehicle_Model}\t Årgang: {cars[i].Vehicle_Year}\tFarve: {cars[i].Vehicle_Color}\tHestekræfter: {cars[i].Car_HorsePower}\n";
                }
            }
            return result;
        }

        static string Print_cars_with_horsepower(Car[] cars, int filter_horsepower)
        {
            string result = "";
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Car_HorsePower > filter_horsepower)
                {
                    result += $"Brand: {cars[i].Vehicle_Brand} {cars[i].Vehicle_Model}\t Årgang: {cars[i].Vehicle_Year}\tFarve: {cars[i].Vehicle_Color}\tHestekræfter: {cars[i].Car_HorsePower}\n";
                }
            }
            return result;
        }

        static string Print_cars_with_color(Car[] cars, string filter_color)
        {
            string result = "";
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Vehicle_Color == filter_color)
                {
                    result += $"Brand: {cars[i].Vehicle_Brand} {cars[i].Vehicle_Model}\t Årgang: {cars[i].Vehicle_Year}\tFarve: {cars[i].Vehicle_Color}\tHestekræfter: {cars[i].Car_HorsePower}\n";
                }
            }
            return result;
        }

        static int Print_cars_amount_of_brand(Car[] cars, string filter_brand)
        {
            int count_brand = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Vehicle_Brand == filter_brand)
                {
                    count_brand++;
                }
            }
            return count_brand;
        }

        static string Print_cars_year(Car[] cars, int filter_year_start, int filter_year_end)
        {
            string result = "";
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Vehicle_Year >= filter_year_start && cars[i].Vehicle_Year <= filter_year_end)
                {
                    result += $"Brand: {cars[i].Vehicle_Brand} {cars[i].Vehicle_Model}\t Årgang: {cars[i].Vehicle_Year}\tFarve: {cars[i].Vehicle_Color}\tHestekræfter: {cars[i].Car_HorsePower}\n";
                }
            }
            return result;
        }
    }
}
