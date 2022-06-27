namespace Hangman
{
    class Hangman
    {
        static public void ManageHangman()
        {
            Hangman hangman = new Hangman();
            setCurrentWord();
            Console.WriteLine(hangmanState());
        }

        private static string setCurrentWord()
        {
            Random random = new Random();
            string[] wordList = {"super", "help", "virginia", "idaho", "computer", "compiler"};
            
            string currentWord = wordList[random.Next(0, wordList.Length)];

            return currentWord;
        }

        private static string hangmanState()
        {
            string[] hangman = 
            {
                "_________\n|/      |\n|\n|\n|\n|\n|___\n", 
            };

            return hangman[0];


// "
//    _________
//     |/   |      
//     |              
//     |                
//     |                 
//     |               
//     |                   
//     |___                 
//     H",

// "
//    _________       
//     |/   |              
//     |   (_)
//     |                         
//     |                       
//     |                         
//     |                          
//     |___                       
//     HA",

// "
//    ________               
//     |/   |                   
//     |   (_)                  
//     |    |                     
//     |    |                    
//     |                           
//     |                            
//     |___                    
//     HAN",


// "
//    _________             
//     |/   |               
//     |   (_)                   
//     |   /|                     
//     |    |                    
//     |                        
//     |                          
//     |___                          
//     HANG",


// "
//    _________              
//     |/   |                     
//     |   (_)                     
//     |   /|\                    
//     |    |                       
//     |                             
//     |                            
//     |___                          
//     HANGM",



// "
//    ________                   
//     |/   |                         
//     |   (_)                      
//     |   /|\                             
//     |    |                          
//     |   /                            
//     |                                  
//     |___                              
//     HANGMA",


// "
//    ________
//     |/   |     
//     |   (_)    
//     |   /|\           
//     |    |        
//     |   / \        
//     |               
//     |___           
//     HANGMAN"


        }
    }
}