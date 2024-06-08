
using Cars;
using System.Diagnostics;
using System.Reflection;

namespace Cars;
public class Car
{
    public string make { get; set; }
    public string model { get; set; }
    public int year { get; set; }
    public decimal price { get; set; }

    public Car()
    {

    }
    public Car(string make, string model, int year, decimal price)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.price = price;
    }
    public override string ToString()
    {
        return ($"{year} {make} {model} ${price:N2} ");
    }

 
    public class UsedCar : Car
    {
        public double mileage { get; set; }
        public UsedCar()
        {
        }
        public UsedCar(string make, string model, int year, decimal price, double mileage)
        : base(make, model, year, price)
        {
            this.mileage = mileage;
        }
        public override string ToString()
        {
            return ($"{year} {make} {model} ${price:N2} {mileage:N1} miles");
        }
        public static void Remove (int index)
        {
            if (index >= 0 && index < index)
            {
                Cars.Car Remove;
                index--;
            }
            else
            {
                Console.WriteLine("The index is invalid. As a result, no car was removed.");
            }
        }
    }
}
