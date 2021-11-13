using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            string oldInput = "";
            string newInput = "";

            Console.WriteLine("Have a conversation with chat bot!");

            while (run)
            {
                Console.WriteLine("What would you like to say to the bot?");

                newInput = Console.ReadLine();
                if (newInput.ToLower() == "hello")
                {
                    if (newInput.ToLower() != oldInput.ToLower())
                    {
                        Console.WriteLine("Hi good to see you");
                    } else
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                }
                else if (newInput.ToLower() == "sup")
                {
                    if (newInput.ToLower() != oldInput.ToLower())
                    {
                        Console.WriteLine("I am good");
                    } else
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                }
                else if (newInput.ToLower() == "hello there")
                {
                    if (newInput.ToLower() != oldInput.ToLower())
                    {
                        Console.WriteLine("General Kenobi");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                }
                else if (newInput.ToLower() == "bye")
                {
                    Console.WriteLine("Good bye!");
                    run = false;
                } else
                {
                    Console.WriteLine("I'm sorry I can't understand what you said :(");
                }
                oldInput = newInput;
            }
        }
    }
}
