// See https://aka.ms/new-console-template for more information

namespace Main
{
    using Calculator;
    using Hangman;
    using TicTacToe;
    class Program
    {
        static void Main(string[] args)
        {
            string? appSelection;
            
            Console.WriteLine("What app would you like to use?");
            Console.WriteLine("[Calculator, Hangman, TicTacToe]");
            Console.Write("> "); 
            appSelection = Console.ReadLine();
            if (appSelection != null)
            {
                appSelection = appSelection.ToLower();
            
                switch (appSelection)
                {
                    case "calculator": 
                        Calculator.ManageCalculator();
                        break;
                    case "hangman": 
                        Hangman.ManageHangman();
                        break;
                    case "t":
                    TicTacToe ticTacToe = new TicTacToe();
                        ticTacToe.Main();
                        break;
                }
            }
        }
    }
}
