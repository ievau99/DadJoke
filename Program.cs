using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;

namespace ConsoleAppJoke
{
    class Program
    {
        private static void Main(string[] args)
        {
            var database = new Database();
            var menu = new Menu();

            while (true)
            {
                var selection = menu.PrintMenu();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("All Dad Jokes: ");
                        Console.WriteLine();

                        foreach (var joke in database.Jokes)
                        {
                            Console.WriteLine("  {0} {1}", joke.Statement, joke.Punchline);
                        }

                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("One random Dad Joke: {0} ",
                            database.Jokes[new Random().Next(0, database.Jokes.Count)]);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Which index of Dad jokes should be printed ?");
                        int index = 0;

                        try
                        {
                            index = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wrong number entered");
                            Console.ReadLine();
                            break;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("The entered value is to big");
                            Console.ReadLine();
                            break;
                        }

                        Console.WriteLine("Your selected index {0}:", index);
                        Joke selectedJoke = null;
                        try
                        {
                            selectedJoke = database.Jokes[index];
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("No value in database");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Dad Joke: {0}", selectedJoke);

                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Our “database” supports {0} Dad Jokes", database.Jokes.Count);
                        Console.ReadLine();
                        break;
                    case "5":
                        Random rand = new Random();
                        var joke1 = database.Jokes[rand.Next(0, database.Jokes.Count)];
                        var joke2 = database.Jokes[rand.Next(0, database.Jokes.Count)];
                        Console.WriteLine("One mixed Dad Joke: {0} {1}", joke1.Statement, joke2.Punchline);
                        Console.ReadLine();
                        break;
                    case "6":
                        var statement = Console.ReadLine();
                        var punchline = Console.ReadLine();
                        var newJoke = new Joke(statement, punchline);
                        database.Jokes.Add(newJoke);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Your input is wrong '{0}', check it!", selection);
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
            }
            }
        }
    }

