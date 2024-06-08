using System.ComponentModel;
using System.Xml.Serialization;
using static Cars.Car;

namespace Cars
{
    public class CarLab
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Hyundai", "Palisade", 2024, 38000),
                new Car("Kia", "Sorento", 2024, 33000),
                new Car("Ford", "Edge", 2024, 39000),
                new UsedCar("Chevrolet", "Bolt EV", 2020, 16000, 38000),
                new UsedCar("Mercedes-Benz", "C 300", 2020, 28000, 58000),
                new UsedCar("BMW", "X1 XDrive28i", 2017, 21000, 35000),        
            };
            Console.WriteLine("Prior to removing:");
            foreach (Car car in cars)
            {
                Console.WriteLine(car.model);
                //Car.remove(2);
            }
            Console.WriteLine("Welcome to GC's Car Emporium!");
            Console.WriteLine("Here are the cars we have:");
            ListCars(cars);
            Console.WriteLine();
            Console.WriteLine("Which car would you like? Kindly, enter your choice.");
            string userinput = Console.ReadLine();
            Console.WriteLine($"You selected: {userinput}");
            Console.WriteLine("Great! Our finance department will be in touch shortly.");
            Console.WriteLine("Have an amazing day!");

            Console.WriteLine("Used Cars:");
            foreach (Car car in cars)
            {
                if (car is UsedCar)
                {
                    Console.WriteLine(car.model + " " + car.make);
                }
            }

            static void ListCars(List<Car> cars)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {cars[i]}");
                }
      
            }
        }

        }
    }
