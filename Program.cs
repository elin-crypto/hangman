using System;
using static System.Console;
using System.Text.RegularExpressions;
using System.Threading;

namespace VSC_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;

            do
            {

                // instansiate classes
                Word word = new Word(); // just nu är det bara ett testord
                Menu menu = new Menu();
                Hangman man = new Hangman();

                bool contPlay = true;
           
                Clear();
                CursorVisible = false;
                word.createWord();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("                          Välkommen till");
                menu.WriteTitle();
                menu.gameOptions();
                while (contPlay)
                {
                    
                    menu.WriteTitle();

                    // call class hangman and send in number of errors
                    man.printMan(word.getNbrOfErr());
                    WriteLine();
                    word.getHiddenWord();
                    WriteLine();
                    WriteLine($"\nGissa bokstav");
                    string bokstav = ReadLine();

                    Clear();
                    if(bokstav.Length > 1)
                    {
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("Skriv endast en bokstav!");
                        ForegroundColor = ConsoleColor.White;
                    }
                    else if(Regex.Matches(bokstav, @"^[a-zåäöA-ZÅÄÖ]+$").Count == 0)
                    {
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("Var det där en bokstav eller? Tror inte det, försök igen!");
                        ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        char guess = char.Parse(bokstav); // convert string to char[]
                        contPlay = word.handleGuess(guess);
                    
                    }
                    
                    
                } 
                menu.WriteTitle();
                word.checkWinLoose();
                WriteLine("För att spela igen [j]. För att avsluta tryck [n].");
                var playOrEnd = ReadLine();
                
                if(playOrEnd.ToLower() == "n")
                {
                    Clear();
                    menu.WriteTitle();
                    WriteLine();
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("Tack för idag! Välkommen åter!");
                    ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(2000);
                    Clear();
                    restart = false;
                }
            } while (restart);
            
         
            
        }
    }
}
