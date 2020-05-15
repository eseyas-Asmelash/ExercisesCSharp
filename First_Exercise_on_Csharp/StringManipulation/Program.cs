using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main()
        {
            StringManipulation();
        }
        static void StringManipulation()
        {
            Console.Write("Write a Sentence: ");
            string mySentence = Console.ReadLine();

            string noSpaces = mySentence.Replace(" ", "_");
            Console.WriteLine(noSpaces);

            string noLeadingSpaces = mySentence.TrimStart();
            Console.WriteLine(noLeadingSpaces);

            string noEndingSpaces = mySentence.TrimEnd();
            Console.WriteLine(noEndingSpaces);

            string aToUpper = mySentence.Replace("a", "A");
            Console.WriteLine(aToUpper);

            Console.ReadKey();
        }
    }
}
