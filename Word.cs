using System;
using static System.Console;
using System.Text;
using System.Collections.Generic;

namespace VSC_Hangman
{
    public class Word
    {
        char[] letters;
        int nbrOfErr = 0;
        char[] hiddenWord;
        string word;
        int numberOfLetters;
        string hwLines = "";
        string hw;
        public void createWord()
        {
            
            word = "huvudvärk"; // the word 
             
            numberOfLetters = word.Length;
            letters = word.ToCharArray(); // separate letters from word

            for(var i = 0; i < letters.Length; i++)
            {
                hw = hwLines.Insert(i, "_");
                hwLines = hw;
            }
            
            hiddenWord = hwLines.ToCharArray();
        }
        
        


        public bool handleGuess(char guess)
        {
            bool correctGuess = false;  



            for(var i = 0; i < letters.Length; i++)
            {
                if(guess == letters[i])
                {
                    correctGuess = true;        
                    hiddenWord[i] = guess;
                    string s =string.Join("", hiddenWord);
                    if(s == word)
                    {
                        return false;
                    }   
                }

            }
            
            if(correctGuess == false)
            {
                nbrOfErr++;

                if(nbrOfErr > 5)
                {
                    return false;
                }
            }
            return true;
        }
       
       public void getHiddenWord()
       {
           // loop through hidden word nad write the found letters or hidden underscores
            for(int i = 0; i < hiddenWord.Length; i++)
            {
                Write($"{hiddenWord[i]} "); 
            }
       }

       public int getNbrOfErr()
       {
           return nbrOfErr;
       }

       public void checkWinLoose()
       {
            if(nbrOfErr > 5)
            {
                WriteLine(@"         =====");
                WriteLine(@"          o  ║");
                WriteLine(@"         /|\ ║"); 
                WriteLine(@"         / \ ║");
                WriteLine(@"             ║");
                WriteLine(@"         =====");

                 WriteLine("Game over");
                
            } else
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Grattis du har vunnit!");
                WriteLine(numberOfLetters);
                WriteLine();
                ForegroundColor = ConsoleColor.White;
            }
       }

    }
}





        // public void numberOfLetters()
        // {
        //     // int numberOfLetters = lettersCount;

        //     for (int i = 0; i < lettersCount.length; i++)
        //     {
        //         Write("_");
        //     }
        // }