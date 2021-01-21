using System;
using System.Text.RegularExpressions;

namespace _Task01_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection validNames = Regex.Matches(names, patern);

            foreach (Match name in validNames)
            {
                Console.Write($"{name.Value} ");
            }
            
        }
    }
}
