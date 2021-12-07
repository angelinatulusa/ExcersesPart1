using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            Console.WriteLine("Enter your favorite color");
            color = Console.ReadLine().ToLower();

            string template = $"You picked {color}";
            if (color == "red")
            {
                Console.WriteLine($"{template} you are romantic");

            }
            if (color == "blue")
            {
                Console.WriteLine($"{template} you are reliable");
            }
            if (color == "yellow")
            {
                Console.WriteLine($"{template} you are cheerfull");
            }
            else
            {
                Console.WriteLine($"{template}. You are {color} unicorn");
}
