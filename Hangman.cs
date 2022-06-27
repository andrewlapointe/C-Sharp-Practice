namespace Hangman
{
    class Hangman
    {
        static public void ManageHangman()
        {   
            int wordLength;

            string word = setCurrentWord();
            wordLength = word.Length;

            int currentHangman = 0;

            string displayString = createDisplayString(wordLength);

            

            while (true)
            {
                Console.WriteLine(hangmanState(currentHangman));
                Console.WriteLine(displayString);
                Console.WriteLine(word);

                break;
            }
        }

        private static string setCurrentWord()
        {
            Random random = new Random();
            string[] wordList = {"super", "help", "virginia", "idaho", "computer", "compiler"};
            
            string currentWord = wordList[random.Next(0, wordList.Length)];

            return currentWord;
        }

        private static string hangmanState(int args)
        {
            int currentState = args;

            // string representation of the hangman gallows.
            string[] hangman = 
            {
                "_________\n|/      |\n|        \n|       \n|       \n|\n|___\n",
                "_________\n|/      |\n|       0\n|       \n|       \n|\n|___\n",
                "_________\n|/      |\n|       0\n|       |\n|       \n|\n|___\n",
                "_________\n|/      |\n|       0\n|       |\\\n|       \n|\n|___\n",
                "_________\n|/      |\n|       0\n|      /|\\\n|       \n|\n|___\n",
                "_________\n|/      |\n|       0\n|      /|\\\n|        \\\n|\n|___\n",
                "_________\n|/      |\n|       0\n|      /|\\\n|      / \\\n|\n|___\n",
            };

            return hangman[currentState];

        }

        private static string createDisplayString(int args)
        {
            string displayString = "";

            foreach (int value in Enumerable.Range(1, args))
            {
                displayString = displayString + "_ ";
            }

            return displayString;
        }
    }
}