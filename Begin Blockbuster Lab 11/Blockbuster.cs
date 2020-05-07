using System;
using System.Collections.Generic;
using System.Text;

namespace Begin_Blockbuster_Lab_11
{
    class Blockbuster
    {
        public static List<MovieAbstract> Movies { get; set; }

        public static void AddMovies()
        {
            List <MovieAbstract> Movies = new List<MovieAbstract>();

            List<string> aristoScenes = new List<string> { "The Milk Scene", "Meet Thomas OMalley", "Long Journey Home", "Everybody Wants To Be A Cat" };
            List<string> lionScenes = new List<string> { "Simba is born", "Mufasa Dies & Simba Runs Aaway", "Meet Timon & Pumba", "Reclaim The Lion Throne" };
            List<string> toyScenes = new List<string> { "Woody Meets Buzz", "Andy Forgets Buzz & Woody", "Toys Find Their Way Back TO Andy" };
            List<string> frozenScenes = new List<string> { "Townspeople hunt Elsa down", "Else sings Let It Go", "Anna Saves Elsa" };
            List<string> moanaScenes = new List<string> { "Moana Looks To Go To The Reef", "Moana Leaves and Discovers HeiHei", "Moana Learns to Sail" };
            List<string> tangledScenes = new List<string> { "Rapunzel Turns 18", "Rapunzel Leaves Tower", "Eugene Is Brought To Life and Marries Rapunzel" };

            VHS aristoCats = new VHS("The AristoCats", "Drama", 110, aristoScenes);
            VHS lionKing = new VHS("The Lion King", "Romance", 195, lionScenes);
            VHS toyStory = new VHS("Toy Story", "Horror", 100, toyScenes);
            DVD frozen = new DVD("Frozen", "Comedy", 108, frozenScenes);
            DVD moana = new DVD("Moana", "Action", 118, moanaScenes);
            DVD tangled = new DVD("Tangled", "Comedy", 113, tangledScenes);

            Movies.Add(aristoCats);
            Movies.Add(lionKing);
            Movies.Add(toyStory);
            Movies.Add(frozen);
            Movies.Add(moana);
            Movies.Add(tangled);

        }

        public static void PrintMovies()
        {
            int index = 0;

            AddMovies();

            foreach (MovieAbstract m in Movies)
            {
                Console.WriteLine($"{index}: {m}");
                index++;
            }

        }

        public static void CheckOut()
        {
            bool runCheckOut = true;
            while (runCheckOut)
            {
                MovieAbstract selectedMovie;
                int movieChoice = 10;

                PrintMovies();
                Console.WriteLine();

                try
                {
                    Console.WriteLine("Which movie would you like to rent? Please choose a number below.");
                    movieChoice = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                if (movieChoice < Movies.Count)
                {
                    selectedMovie = Movies[movieChoice];
                    Console.WriteLine(selectedMovie);

                }
                else
                {
                    Console.WriteLine("Sorry, I couldn't locate that movie. Please try again.");
                    continue;
                }

                Console.WriteLine("Would you like to rent another movie? (y/n)");
                string userChoice = Console.ReadLine().ToLower().Trim();
                if (userChoice == "y")
                {
                    Console.WriteLine();
                    selectedMovie.Play();
                    Console.WriteLine();

                    bool keepPlaying = true;
                    while (keepPlaying)
                    {
                        Console.WriteLine("Would you like to watch another scene?");
                        string sceneDecision = Console.ReadLine().ToLower().Trim();
                        if (sceneDecision == "y")
                        {
                            selectedMovie.Play();
                        }
                        else if (sceneDecision == "n")
                        {
                            Console.WriteLine("Returning to main menu.");
                            keepPlaying = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again");
                            keepPlaying = true;
                        }
                    }
                }
                else if (userChoice == "n")
                {
                    runCheckOut = false;
                }
                else
                {
                    Console.WriteLine("I'm sorry, that was not a proper selection. Please try again.");
                    runCheckOut = true;
                }

            }
        }
    }
}