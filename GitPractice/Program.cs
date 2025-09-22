
using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        //klasdf
        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Team Practice Console App ===");
            Console.WriteLine("1. Greet Me");
            Console.WriteLine("2. Roll a Dice");
            Console.WriteLine("3. Tell a Joke");
            Console.WriteLine("0. Exit");
            Console.Write("\nChoose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Greet();
                    break;
                case "2":
                    RollDice();
                    break;
                case "3":
                    TellJoke();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }

        Console.WriteLine("Goodbye 👋");
    }

    static void Greet()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! 👋");
        Pause();
    }

    static void RollDice()
    {
        Random rnd = new Random();
        int dice = rnd.Next(1, 7);
        Console.WriteLine($"You rolled a {dice} 🎲");
        Pause();
    }

    static void TellJoke()
    {
        string[] jokes =
        {
            "Why do programmers prefer dark mode? Because light attracts bugs.",
            "Why did the developer go broke? Because he used up all his cache.",
            "How many programmers does it take to change a light bulb? None, it's a hardware problem."
        };

        Random rnd = new Random();
        Console.WriteLine(jokes[rnd.Next(jokes.Length)]);
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}
