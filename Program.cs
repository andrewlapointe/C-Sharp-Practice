// See https://aka.ms/new-console-template for more information

namespace Main
{
    using Calculator;
    using Hangman;
    class Program
    {
        static void Main(string[] args)
        {
            string? appSelection;
            
            Console.WriteLine("What app would you like to use?");
            Console.WriteLine("[Calculator, Hangman]");
            Console.Write("> "); appSelection = Console.ReadLine().ToLower();

            if (appSelection == "calculator")
            {
                Calculator.ManageCalculator();
            }
            else if (appSelection == "hangman")
            {
                Hangman.ManageHangman();
            }
        }
    }
}
