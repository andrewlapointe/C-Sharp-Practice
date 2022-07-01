namespace TicTacToe
{
    class TicTacToe
    {
        private string currentGameBoard;
        private string currentPlayer = "X";
        private bool gameIsOver = false;
        private string[] pos = {"0", "1", "2", "3", "4", "5", "6", "7", "8"};
        private string gameBoard; 


        public TicTacToe()
        {
            currentGameBoard = createDisplayString();
        }
        public void Main()
        {   
            int move;
            while (!gameIsOver)
            {
                updateDisplayString();
                displayString();
                Console.WriteLine(String.Format("{0}'s turn. Which space will you take?: ", currentPlayer));
                move = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(move);
                pos[move] = currentPlayer;
                nextPlayer();
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
    }
}