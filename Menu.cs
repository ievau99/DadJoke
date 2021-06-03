using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppJoke
{
    public class Menu
    {
        public string PrintMenu()
        {
            Console.WriteLine("---------------Menu:---------------");
            Console.WriteLine("1. Print all full dad jokes ");
            Console.WriteLine("2. Print one random full dad joke");
            Console.WriteLine("3. Print dad joke by index");
            Console.WriteLine("4. Print current amount of jokes in “database” ");
            Console.WriteLine("5. Print one random mixed dad joke");
            Console.WriteLine("6. Add new joke");
            Console.WriteLine("7. Exit");
            return Console.ReadLine();
        }

    }
}
