using System;

namespace AreaOfCircle
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your radius:");
            string input = Console.ReadLine();            
            double radius;

            if (input == "" || !Double.TryParse(input, out radius))
            {
                Console.WriteLine("Your radius is not valid");
                Environment.Exit(0);
            }
            radius = Double.Parse(input);
            while (radius < 0)
            {
                Console.WriteLine("Enter your radius:");
                radius = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please select Circumference or Area of a circle");
            Console.WriteLine("Enter 1 for Circumference");
            Console.WriteLine("Enter 2 for  Area");

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
