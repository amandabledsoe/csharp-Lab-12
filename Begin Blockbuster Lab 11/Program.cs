using System;
using System.Collections.Generic;

namespace Begin_Blockbuster_Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //List<string> vhsScenes = new List<string>();
            //vhsScenes.Add("The sand scene");
            //vhsScenes.Add("The lot scene");
            //vhsScenes.Add("The baseball scene");
            //VHS v = new VHS("The Sandlot", "Drama", 90, vhsScenes);
            //v.Play();
            //v.PrintScenes();
            //Console.WriteLine("\n");

            //List<string> dumbAndDumber = new List<string>();
            //dumbAndDumber.Add("Most annoying sound in the world");
            //dumbAndDumber.Add("Scene where he got tongue stuch on an icy pole");
            //dumbAndDumber.Add("The Pretty Bird Scene");

            //DVD dumdum = new DVD("Dumb and Dumber", "Comedy", 80, dumbAndDumber);
            //dumdum.Play();
            //dumdum.PrintScenes();

            bool runProgram = true;
            while (runProgram)
            {

                int movieChoice = 10;
                MovieAbstract userMovie;

                Console.WriteLine("Would you like to watch scenes from a movie or a whole movie? Choose scenes or movie");
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "scenes")
                {
                    Blockbuster.CheckOut();
                }
                else if (input == "movie")
                {
                    bool askAgain = true;
                    while (askAgain)
                    {
                        Blockbuster.PrintMovies();
                        Console.WriteLine();

                        try
                        {
                            Console.WriteLine("What movie would you like to see? Please enter an index number");
                            movieChoice = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            //Console.WriteLine("This is not a number try again.");
                        }
                        if (movieChoice < Blockbuster.Movies.Count)
                        {
                            userMovie = Blockbuster.Movies[movieChoice];
                            userMovie.Play();
                            askAgain = false;

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again");
                            askAgain = true;
                        }
                    }
                }

                Console.WriteLine("Do you want to watch another movie? y or n");
                string againChoice = Console.ReadLine().ToLower().Trim();
                if (againChoice == "y")
                {
                    runProgram = true;
                }
                else if (againChoice == "n")
                {
                    Console.WriteLine("Goodbye");
                    runProgram = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Returning to main menu");
                    runProgram = true;
                }
            }
        }
    }
}