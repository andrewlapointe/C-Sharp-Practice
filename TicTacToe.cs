namespace TicTacToe
{
    class TicTacToe
    {
        private string currentGameBoard;
        private string currentPlayer = "X";
        private bool gameIsOver = false;
        private string[] defaultPos = {"0", "1", "2", "3", "4", "5", "6", "7", "8"};
        private string[] pos = {"0", "1", "2", "3", "4", "5", "6", "7", "8"};
        private string gameBoard; 
        private string? play;


        public TicTacToe()
        {
            currentGameBoard = createDisplayString();
        }
        public void Main()
        {   
            int move;
            while (true)
            {
                pos = defaultPos;
                while (!gameIsOver)
                {
                    nextPlayer();
                    updateDisplayString();
                    displayString();
                    Console.WriteLine(String.Format("{0}'s turn. Which space will you take?: ", currentPlayer));
                    move = Convert.ToInt16(Console.ReadLine());
                    pos[move] = currentPlayer;
                    checkForWin();
                }
                displayString();
                Console.WriteLine(String.Format("Game Over. {0} won!", currentPlayer));
                Console.Write("Play Again? [y/n]: "); play = Console.ReadLine().ToLower();
                if (play == "n")
                {
                    break;
                }
            }
        }

        private string createDisplayString()
        {
            currentGameBoard = String.Format(" {0} | {1} | {2}\n___|___|___\n {3} | {4} | {5}\n___|___|___\n {6} | {7} | {8}\n   |   |  \n", 
            pos[0], pos[1], pos[2], pos[3], pos[4], pos[5], pos[6], pos[7], pos[8]);

            return currentGameBoard;
        }
        private void updateDisplayString()
        {
            currentGameBoard = String.Format(" {0} | {1} | {2}\n___|___|___\n {3} | {4} | {5}\n___|___|___\n {6} | {7} | {8}\n   |   |  \n", 
            pos[0], pos[1], pos[2], pos[3], pos[4], pos[5], pos[6], pos[7], pos[8]);
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
            } else {
                currentPlayer = "X";
            }
        }
        private void checkForWin()
        {
            int lineHead = -1;

            if (pos[4] == currentPlayer)  // Check the center
            {
                for(int i = 0; i < 4; i++)  // Check the start of each possible line from center
                {
                    if (pos[i] == currentPlayer)
                    {
                        lineHead = i;
                        break;
                    }
                }
                switch (lineHead)  // Checks each of the 4 win cases with the center
                {
                    case 0:
                        if (pos[8] == currentPlayer) {gameIsOver = true;}
                        return;
                    case 1:
                        if (pos[7] == currentPlayer) {gameIsOver = true;}
                        return;
                    case 2:
                        if (pos[6] == currentPlayer) {gameIsOver = true;}
                        return;
                    case 3:
                        if (pos[5] == currentPlayer) {gameIsOver = true;}
                        return;
                    default:
                        break;
                    
                }
            }
            else if (pos[0] == currentPlayer)
            {
                if (pos[2] == currentPlayer)
                {
                    lineHead = 2;
                    if (pos[1] == currentPlayer) {gameIsOver = true;}
                    return;
                }
                else if (pos[6] == currentPlayer)
                {
                    lineHead = 6;
                    if (pos[3] == currentPlayer) {gameIsOver = true;}
                    return;
                } else {
                    return;
                }
            }
            else if (pos[8] == currentPlayer)
            {
                switch (lineHead)
                {
                    case 2:
                        if (pos[5] == currentPlayer) {gameIsOver = true;}
                        return;
                    case 6:
                        if (pos[3] == currentPlayer) {gameIsOver = true;}
                        return;
                }
            }
        }
    }
}