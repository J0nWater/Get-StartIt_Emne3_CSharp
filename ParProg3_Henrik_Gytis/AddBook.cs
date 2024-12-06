using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParProg3_Henrik_Gytis
{
    internal class AddBook
    {
        public void Run()
        {

            string inputTitle = "";
            string inputGenre = "";
            string inputReleaseDate = "";
            string inputAuthor = "";
            string inputAbout = "";
            bool isRunning = true;


            while (isRunning)
            {
                Console.WriteLine("Welcome! Let's begin with the Title of your book.");
                string input = Console.ReadLine();
                inputTitle = input;
                Console.WriteLine("Nice! Now, what Genre is it?");
                input = Console.ReadLine();
                inputGenre = input;
                Console.WriteLine("Superb now, what is the release date?");
                input = Console.ReadLine();
                inputReleaseDate = input;
                Console.WriteLine("Fantastic, now who is the Author?");
                input = Console.ReadLine();
                inputAuthor = input;
                Console.WriteLine("Sounds cool, now, tell me a little bit About the book!");
                input = Console.ReadLine();
                inputAbout = input;
                Console.WriteLine("Nice! That about does it, would you like to view your book Y/N ?");
                input = Console.ReadLine();

                Book book1 = new Book(inputTitle, inputGenre, inputReleaseDate, inputAuthor, inputAbout);
                switch (input)
                {
                    case "Y":
                        isRunning = false;
                        Console.WriteLine("Nice!!! Here it is is! It's one of the books of all time!");
                        Console.WriteLine($" Title: {book1.Title}");
                        Console.WriteLine($" Genre: {book1.Genre}");
                        Console.WriteLine($" Release Date: {book1.ReleaseDate}");
                        Console.WriteLine($" The Author: {book1.Author}");
                        Console.WriteLine($" A little About the book: {book1.About}");
                        break;
                    case "N":
                        Console.WriteLine("...Wow, ok? What did you write all that for then? Whatever.");
                        System.Environment.Exit(0);
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }



        }

    }
}
