namespace TicTacToe
{
    using System.Linq;

    class TicTacToe
    {
        private string currentGameBoard;
        private string currentPlayer = "O";
        private bool gameIsOver = false;
        private string[] defaultPosition = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string[] positition = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private int[] takenSpaces = new int[10];
        private string gameBoard;
        private string? play;

        public TicTacToe() // Constructor
        {
            currentGameBoard = createDisplayString();
        }

        public void Main()
        {
            int move;
            while (true) // allows players to play again
            {
                for (int i = 0; i < defaultPosition.Length; i++) // resets board
                {
                    positition[i] = defaultPosition[i];
                }
                Array.Clear(takenSpaces);
                takenSpaces[9] = -1;
                move = -1;
                gameIsOver = false;

                while (!gameIsOver) // main game play loop
                {
                    updateDisplayString();
                    displayString();
                    nextPlayer();

                    // Player input
                    while (takenSpaces.Contains(move))
                    {
                        Console.Write(
                            String.Format("{0}'s turn. Which space will you take?: ", currentPlayer)
                        );
                        move = Convert.ToInt16(Console.ReadLine());

                        if (takenSpaces.Contains(move) == false)
                        {
                            positition[move - 1] = currentPlayer;
                            takenSpaces[move] = move;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Space is already taken. Try again.");
                        }
                    }
                    checkForWin();
                }
                updateDisplayString();
                displayString();
                Console.WriteLine(String.Format("Game Over. {0} won!", currentPlayer));
                Console.Write("Play Again? [y/n]: ");
                play = Console.ReadLine().ToLower();
                if (play == "n" || play == "quit")
                {
                    break;
                }
            }
        }

        private string createDisplayString()
        {
            currentGameBoard = String.Format(
                " {0} | {1} | {2}\n___|___|___\n {3} | {4} | {5}\n___|___|___\n {6} | {7} | {8}\n   |   |  \n",
                positition[0],
                positition[1],
                positition[2],
                positition[3],
                positition[4],
                positition[5],
                positition[6],
                positition[7],
                positition[8]
            );

            return currentGameBoard;
        }

        private void updateDisplayString()
        {
            currentGameBoard = String.Format(
                " {0} | {1} | {2}\n___|___|___\n {3} | {4} | {5}\n___|___|___\n {6} | {7} | {8}\n   |   |  \n",
                positition[0],
                positition[1],
                positition[2],
                positition[3],
                positition[4],
                positition[5],
                positition[6],
                positition[7],
                positition[8]
            );
        }

        private void displayString()
        {
            Console.Write(currentGameBoard);
        }

        private void nextPlayer()
        {
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }
        }

        private void checkForWin()
        {
            int lineHead = -1;

            if (positition[4] == currentPlayer) // Check the center
            {
                for (int i = 0; i < 4; i++) // Check the start of each possible line from center
                {
                    if (positition[i] == currentPlayer)
                    {
                        lineHead = i;
                        break;
                    }
                }
                switch (lineHead) // Checks each of the 4 win cases with the center
                {
                    case 0:
                        if (positition[8] == currentPlayer)
                        {
                            gameIsOver = true;
                        }
                        return;
                    case 1:
                        if (positition[7] == currentPlayer)
                        {
                            gameIsOver = true;
                        }
                        return;
                    case 2:
                        if (positition[6] == currentPlayer)
                        {
                            gameIsOver = true;
                        }
                        return;
                    case 3:
                        if (positition[5] == currentPlayer)
                        {
                            gameIsOver = true;
                        }
                        return;
                    default:
                        break;
                }
            }
            else if (positition[0] == currentPlayer)
            {
                if (positition[2] == currentPlayer)
                {
                    lineHead = 2;
                    if (positition[1] == currentPlayer)
                    {
                        gameIsOver = true;
                    }
                    return;
                }
                else if (positition[6] == currentPlayer)
                {
                    lineHead = 6;
                    if (positition[3] == currentPlayer)
                    {
                        gameIsOver = true;
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            else if (positition[8] == currentPlayer)
            {
                switch (lineHead)
                {
                    case 2:
                        if (positition[5] == currentPlayer)
                        {
                            gameIsOver = true;
                        }
                        return;
                    case 6:
                        if (positition[3] == currentPlayer)
                        {
                            gameIsOver = true;
                        }
                        return;
                }
            }
        }
    }
}
