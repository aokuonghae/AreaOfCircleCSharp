using System;
using System.IO;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static readonly string textFile = @"C:\Users\aokuo\Desktop\theColdEarthSleptBelow.txt";
        //you will of course want to make sure that the path file is for your system;
        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {
               string inputString = File.ReadAllText(textFile);

                //I am using linq and will require an import which is at the top of my file. 
                // Really nifty stuff:  https://www.tutorialsteacher.com/linq/linq-query-syntax 

                //METHOD 1
                var charGroups = (from characters in inputString.Trim().ToLower().Where(char.IsLetter)
                                  group characters by characters into charGroup
                                  select String.Format("{0}:{1} \n", charGroup.Key, charGroup.Count()));
                //String.format is a .NET method. https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1

                foreach (var pair in charGroups)
                {
                    Console.Write(pair);
                }

            }

        }
    }
}

