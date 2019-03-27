using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Lesson_1
{
    class Program
    {
        public static void PhotoCheckMethod()
        {
            Console.WriteLine("Now we need to check your photo for application form. Please, answer the questions only 'yes' or 'no'");
            Console.WriteLine("Do you have a photo?");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Is it less than three months?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("Is it in your passport photo?");
                    if (Console.ReadLine().ToLower() == "no")
                        Console.WriteLine("Great!");
                    else
                        Console.WriteLine("You need to make a new photo in photobooth");
                }
                else
                    Console.WriteLine("You need to make a new photo in photobooth");
            }
            else
                Console.WriteLine("You need to make a new photo in photobooth");

            Console.WriteLine("Did you include your photo in form?");

            while (Console.ReadLine().ToLower() != "yes")
            {
                Console.WriteLine("Please, include your photo in application form");
                Console.WriteLine("Did you include your photo in form now?");
            }

            Console.WriteLine("Perfect! you can go to pay");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравсвуйте, меня зовут Василиса. Предоставьте список документов");
            Program.PhotoCheckMethod();
            var documents = new  string [1];
            const int adultAge = 18;

            var document = Console.ReadLine();
            documents[0] = document;

            Console.WriteLine("How old are you?");
            var age = Int32.Parse(Console.ReadLine());

            if (age >= adultAge)
            {
                Console.WriteLine("Ok. Go to pay");
            }
            else
            {
                Console.WriteLine("Do you have parent permission?");
                bool hasPermision = bool.Parse(Console.ReadLine());

                if (hasPermision == true)
                {
                    Console.WriteLine("Ok. Go to pay");
                }
                else
                {
                    Console.WriteLine("Fail. Go to parents");
                }

            }

            Console.ReadLine();
        }
    }
}
