using System;

namespace AreaOfCircle
{
    public static class Circle
    {
        public static double GetAreaOfCircle(double radius)
        {
            double area = Math.Round((Math.PI * Math.Pow(radius, 2)), 2); 
            return area;

        }
        public static double GetCircumferenceOfCircle(double radius)
        {
            double circumference = Math.Round((2 * Math.PI * radius), 2);
            return circumference;
        }  
        
        public static double GetDistanceTravelled(double radius, double mph)
        {
            double numGallons = GetCircumferenceOfCircle(radius) / mph;
            return Math.Round(numGallons,2);
        }

    }
}