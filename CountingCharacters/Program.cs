using System;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = "Test String Here";
            string lowerCaseInput = inputString.ToLower();

            //I am using linq and will require an import which is at the top of my file. 
            // Really nifty stuff:  https://www.tutorialsteacher.com/linq/linq-query-syntax 

            //METHOD 1
            var charGroups = (from characters in lowerCaseInput
                              group characters by characters into charGroup
                              select String.Format("{0}:{1} \n", charGroup.Key, charGroup.Count()));
            //String.format is a .NET method. https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1

            foreach (var pair in charGroups)
            {
                Console.Write(pair);
            }


            //METHOD TWO 
            int count = 0;

            var myChars = (from characters in lowerCaseInput
                           group characters by characters into charGroup
                           select new
                           {
                               charKeys = charGroup.Key,
                               charCount = charGroup.Count(),
                           }).OrderBy(charKeys => charKeys.charCount);
            foreach (var x in myChars)
            {
                Console.WriteLine(x.charKeys + ": " + x.charCount);
                count = x.charCount;
            }
        }
    }
}

