using System;

namespace ExetcisesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string fName, lName;
            int Year, age;
            Console.WriteLine("Enter your first name");
            fName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lName = Console.ReadLine();
            Console.WriteLine($"Hello, {fName} {lName}");
            Console.WriteLine("Enter the year of birth");
            Year = Convert.ToInt32(Console.ReadLine());

            int currentDate =DateTime.Now.Year;
            age = currentDate - Year;

            if (age >= 13)
            {
                Console.WriteLine("Welcome to Instagramm");
            } else
            {
                Console.WriteLine("You ar etoo young to have an Instagramm account");
             }
        }

    }
}
