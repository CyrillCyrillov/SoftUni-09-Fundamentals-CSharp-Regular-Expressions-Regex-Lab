using System;
using System.Text.RegularExpressions;

namespace Task03_Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // string patern = @"\b(?<day>\d{2})([-.\/])(?<mounth>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string patern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string datesToCheck = Console.ReadLine();

            MatchCollection validDates = Regex.Matches(datesToCheck, patern);
           

            foreach (Match date in validDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
            

        }
    }
}
