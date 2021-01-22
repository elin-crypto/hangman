using System;
using static System.Console;
using System.Threading;

namespace VSC_Hangman.Classes
{
    public class Word
    {
        char[] letters;
        int nbrOfErr = 0;
        char[] hiddenWord;
        string wrongLetters = "";
        string incorrect = "";
        string word;
        // int numberOfLetters;
        string hwLines = "";
        string hw;

        public void createWord()
        {
            Dictionary wordlist = new Dictionary();

            word = wordlist.getNewWord(); // get random word from method            
            // numberOfLetters = word.Length;
            letters = word.ToCharArray(); // separate letters from word

            for(var i = 0; i < letters.Length; i++)
            {
                hw = hwLines.Insert(i, "_");
                hwLines = hw;
            }
            
            hiddenWord = hwLines.ToCharArray();
        }
        
        // find out if guess is good or bad 
        public bool handleGuess(char guess)
        {
            bool correctGuess = false;  

            for(int i = 0; i < letters.Length; i++)
            {
                if(guess == letters[i])
                {
                    correctGuess = true;        
                    hiddenWord[i] = guess;
                    string s = string.Join("", hiddenWord);
                    if(s == word)
                    {
                        return false; // correct word found, quit play
                    }   
                }
            }                 
            if(correctGuess == false)
            {
                nbrOfErr++;

                if(nbrOfErr > 5)
                {
                    return false; // you loose, to many errors
                } 
                else
                {
                    for(int i = 0; i < letters.Length; i++)
                    {
                        char wrong = guess;
                        incorrect = wrong.ToString();   // convert char to string
                        wrongLetters = wrongLetters.Insert(i, incorrect + " ");  // add char to list
                        incorrect = wrongLetters;  
                        return true; // wrong guess, but please continue play
                    }
                }      
            }
            return true; // correct guess, but you´re not finnished yet
        }

        // write incorrect letter
        public void getIncorrectLetters()
        {
            if(incorrect != "")
            {
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine($"Oj, fel bokstav: {incorrect}");
                ForegroundColor = ConsoleColor.White;
            }
        }
       
       public void getHiddenWord()
       {
           // loop through hidden word and write the found letters or hidden underscores
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
                WriteLine(@"          |  ║");
                WriteLine(@"          o  ║");
                WriteLine(@"         /|\ ║"); 
                WriteLine(@"         / \ ║");
                WriteLine(@"             ║");
                WriteLine(@"         =====");
                
                ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(500);
                WriteLine(@"  ____    ____    _ __  __     ____      ___  __    __  ____   _ __      ");
                Thread.Sleep(500);
                WriteLine(@" / _  \  / _  \  | '_ \/_ \   / __ \    / _ \ \ \  / / / __ \ | ' /           ");
                Thread.Sleep(500);
                WriteLine(@"| (_)  || (_)  | | | | | | | |  ___/   | (_) | \ \/ / |  ___/ | |                ");
                Thread.Sleep(500);
                WriteLine(@" \__/| | \__/|_| |_| |_| |_|  \____|    \___/   \__/   \____| |_|               ");
                Thread.Sleep(500);
                WriteLine(@" _   | |                     ");
                Thread.Sleep(500);
                WriteLine(@" \ \_/ /            ");
                Thread.Sleep(500);
                WriteLine(@"  \___/             ");
                Thread.Sleep(1000);
                WriteLine();
                ForegroundColor = ConsoleColor.White;
                Write("Rätt ord är: ");
                Thread.Sleep(1000);
                Write(word);
                WriteLine();
                Thread.Sleep(500);    
            } 
            else
            {
                ForegroundColor = ConsoleColor.DarkMagenta;
                
                WriteLine(@"       \o/");
                WriteLine(@"        |");
                WriteLine(@"       / \");
                WriteLine();
                WriteLine("Grattis du har vunnit!");
                
                Thread.Sleep(1000);
                WriteLine();
                ForegroundColor = ConsoleColor.White;
                Write("Rätt ord är: ");
                Thread.Sleep(1000);
                Write(hiddenWord);
                WriteLine();
                Thread.Sleep(1000);
                ForegroundColor = ConsoleColor.White;
            }
       }
    }
}





   