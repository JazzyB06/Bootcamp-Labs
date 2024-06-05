using System;

public class Program
{
    public class Circle
    {
        private double radius;

        public Circle()
        {
            radius = 0.0;
        }
        public Circle(double r)
        {
            radius = r;
        }
        public void GetRadius()
        {
            Console.WriteLine("Please enter the radius.");
            radius = double.Parse(Console.ReadLine());
        }

        public void CalculateDiameter()
        {
            double diameter = 0;

            diameter = 2 * radius;
            Console.WriteLine("The diameter of the circle is" + diameter);
        }
        public void CalculateAreaCircle()
        {
            double area = 0;
            double factor = 3.14;

            area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is" + area);
        }
        public void Grow(double radius)
        {
            double grow = 0;
            double factor = 3.14;
            Console.WriteLine("The growth of the circle is" + grow ); 
        }
    }
}