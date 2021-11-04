using System;

namespace SelectionStatement_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //int favoriteNumber = 7;

            //Console.WriteLine("Guess the favorite number. Hint: below 100");

            //int userGuess = int.Parse(Console.ReadLine());

            //if (userGuess < favoriteNumber)
            //{
            //    Console.WriteLine("Too Low!!!");
            //}
            //else if (userGuess > favoriteNumber)
            //{
            //    Console.WriteLine("Too High!!!");
            //}
            //else if (userGuess == favoriteNumber)
            //{
            //    Console.WriteLine("you were correct here is a cookie");
            //}
            //else
            //{
            //    Console.WriteLine("Nevermind");

            string subject = "c#";

            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "c#":
                    Console.WriteLine("You are in the right class");
                    break;
                case "java":
                    Console.WriteLine("c# is better than java");
                    break;
                default:
                    Console.WriteLine("We teach coding here");
                    break;
            }       

        }   

    }
}
