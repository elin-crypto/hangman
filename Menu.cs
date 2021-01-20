using System;
using static System.Console;

namespace VSC_Hangman
{
    public class Menu 
    {
        public void WriteTitle()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(@" _   _                                                          _ ");
            WriteLine(@"| | | |                                                        | |");
            WriteLine(@"| |_| |   ____    _ __     ____    _ __  __     ____    _ __   | |");
            WriteLine(@"|  _  |  / _  \  | '_ \   / _  \  | '_ \/_ \   / _  \  | '_ \  |_|");
            WriteLine(@"| | | | | (_)  | | | | | | (_)  | | | | | | | | (_)  | | | | |  _");
            WriteLine(@"|_| |_|  \__/|_| |_| |_|  \__/| | |_| |_| |_|  \__/|_| |_| |_| |_|");
            WriteLine(@"                          _   | |");
            WriteLine(@"                         \ \_/ /");
            WriteLine(@"                          \___/");

            ForegroundColor = ConsoleColor.White;
            // WriteLine("VÄLKOMMEN TILL HÄNGA GUBBE!\n");        
        }

        public bool gameOptions()
        {
            WriteLine("Vill du spela? Tryck [s]");
            WriteLine("Vill du lägga till ord i ordlistan? Tryck [o]");
            string playOrNey = ReadLine();
            Clear();
            if(playOrNey == "s")
            {
                return true;
            }
            return false;
        }

        
    }
    
}


//  _   _                                                          _   
// | | | |                                                        | |
// | |_| |   ____    _ __     ____    _ __  __     ____    _ __   | |
// |  _  |  / _  \  | '_ \   / _  \  | '_ \/_ \   / _  \  | '_ \  |_|
// | | | | | (_)  | | | | | | (_)  | | | | | | | | (_)  | | | | |  _
// |_| |_|  \__/|_| |_| |_|  \__/| | |_| |_| |_|  \__/|_| |_| |_| |_|
//                           _   | |
//                          \ \_/ /
//                           \___/