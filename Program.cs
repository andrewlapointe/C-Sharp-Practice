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
            bool run = true;
            string? appSelection;
            Console.WriteLine(
                "Welcome to the \"best\" multi-function app you will ever use! It's a one stop shop for entertainment and learning."
            );
            Console.WriteLine(
                "When menuing, be sure to avoid typos. There is very little in the way of exception handling. (0_0;)"
            );
            Console.WriteLine("Not case sensitive. \n");

            while (run)
            {
                Console.WriteLine("What app would you like to use?");
                Console.WriteLine("[Calculator, Hangman, Tic Tac Toe, Quit]");
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
                        case "tic tac toe":
                            TicTacToe ticTacToe = new TicTacToe();
                            ticTacToe.Main();
                            break;
                        case "quit":
                            run = false;
                            break;
                    }
                }
            }
        }
    }
}
