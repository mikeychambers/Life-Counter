using System;

namespace LifeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type name and press enter. ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello there " + name + " and welcome to the life counter! Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Type your date of birth and include the /'s then press enter: dd/mm/yyyy ");
            string dob = Console.ReadLine();
            DateTime ageX = DateTime.Parse(dob); 
            TimeSpan userAge = DateTime.Now.Subtract(ageX);
            Console.Clear();
            Console.WriteLine("Do you want to know how many");
            Console.WriteLine("1) Days");
            Console.WriteLine("2) Hours");
            Console.WriteLine("3) Minutes");
            Console.WriteLine("4) Seconds");
            Console.WriteLine("you've been alive for? Type number and press enter.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine(name + " you've been alive for " + userAge.TotalDays + " days!");
            }

            else if (choice == "2")
            {
                Console.WriteLine(name + " you've been alive for " + userAge.TotalHours + " hours!");
            }

            else if (choice == "3")
            {
                Console.WriteLine(name + " you've been alive for " + userAge.TotalMinutes + " minutes!");
            }

            else if (choice == "4")
            {
                Console.WriteLine(name + " you've been alive for " + userAge.TotalSeconds + " seconds!");
            }

        }
    }
}
