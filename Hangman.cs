namespace Hangman
{
    class Hangman
    {
        static public void ManageHangman()
        {   
            int wordLength;
            char guess;
            string word = setCurrentWord();
            wordLength = word.Length;
            int currentHangman = 0;
            string newDisplayString;
            string incorrectChars = "";
            bool gameOver = false;

            string displayString = createDisplayString(wordLength);

            

            while (true)
            {
                newDisplayString = hangmanState(currentHangman);
                Console.WriteLine(newDisplayString);  // displays the current hangman image, updates before check for game over to not skip final game image
                Console.WriteLine(displayString);
                Console.WriteLine(incorrectChars);
                // Console.WriteLine(currentHangman);

                // gameOver conditions
                if (currentHangman == 6)
                {
                    Console.WriteLine("The correct word was: " + word);
                    break;
                }
                else if (gameOver == true)
                {
                    Console.WriteLine("The correct word was: " + word + " You won!");
                    break;
                }
                // end of gameOver conditions
                try
                {
                    guess = Convert.ToChar(Console.ReadLine());
                    newDisplayString = checkGuess(word, guess);  // returns "none" if the guess was incorrect
                    if (newDisplayString == "none")
                    {
                        currentHangman++;

                        incorrectChars += guess;
                    } else {
                        displayString = updateDisplayString(displayString, newDisplayString, wordLength);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }




                gameOver = checkIfGameOver(displayString, wordLength);  // compares the number of correct letters guessed to the length of the target word
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

        private static string updateDisplayString(string oldString, string newString, int length)
        {
            string mergedString = "";
            char[] tempArray = new char[length * 2];
            int index = 0;

            foreach (char c in oldString)
            {
                tempArray[index] = c;
                index++;
            }
            index = 0;
            foreach (char c in newString)
            {
                if (c != '_')
                {
                    tempArray[index] = c;
                }
                index++;
            }
            foreach (char c in tempArray)
            {
                mergedString += c;
            }

 
            return mergedString;
        }

        private static string checkGuess(string word, char guess)
        {
            string newDisplayString = "";   
            int charInWord = 0;

            foreach (char c in word)
            {
                if (c == guess)
                {
                    newDisplayString += guess + " ";
                    charInWord++;
                } else {
                    newDisplayString += "_ ";
                }
            }
            // Console.WriteLine(newDisplayString);
            if (charInWord == 0)
            {
                return "none";
            } else {
                return newDisplayString;
            }
        }
        private static bool checkIfGameOver(string mergedString, int wordLength){
            int correctLetterCount = 0;
            bool gameOver = false;
            
            foreach (char c in mergedString)
            {
                if (c != ' ' && c != '_')
                {
                    correctLetterCount++;
                }
            }
            if (correctLetterCount == wordLength)
            {
                gameOver = true;
            }
            return gameOver;
        }
    }
}