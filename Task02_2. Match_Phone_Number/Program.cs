using System;
using System.Text.RegularExpressions;

namespace Task02_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\+359(-| )2\1\d{3}\1\d{4}\b";

            string sofiaPhoneNumbers = Console.ReadLine();

            MatchCollection validSofiaPhoneNumbers = Regex.Matches(sofiaPhoneNumbers, patern);

            
                Console.WriteLine(string.Join(", ", validSofiaPhoneNumbers));
        }
    }
}
