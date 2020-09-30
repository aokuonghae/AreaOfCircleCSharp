using System;

namespace AreaOfCircle
{
    class Program
    {
        public static void Main(string[] args)
        {           
            double radius;
            do
            {
                Console.WriteLine("Enter a positive radius:");
                if (Console.ReadLine() == "" || !Double.TryParse(Console.ReadLine(), out radius))
                {
                    Console.WriteLine("Radius is not a number. Ending program");
                    Environment.Exit(0);
                }
                radius = double.Parse(Console.ReadLine());
            }
            while (radius < 0);
             
            Console.WriteLine("Please select Circumference or Area of a circle");
            Console.WriteLine("Enter 1 for Circumference");
            Console.WriteLine("Enter 2 for  Area");
            Console.WriteLine($"Enter 3 to calculate gallons needed to travel a circle of radius {radius}");

            int selection = int.Parse(Console.ReadLine());
            string userSelection = (selection == 1) ? "circumference." : "area";
            string printLine = $"The {userSelection} of a circle with radius {radius} is:";
            switch (selection)
            {
                case 1:
                    double circumference = Circle.GetCircumferenceOfCircle(radius);
                    Console.WriteLine($"{printLine} {circumference}.");
                    break;
                case 2:
                    double area = Circle.GetAreaOfCircle(radius);
                    Console.WriteLine($"{printLine} {area}");
                    break;
                default:
                    break;
            }
        }
    }
}
