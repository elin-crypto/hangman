using System;
using static System.Console;

namespace VSC_Hangman.Classes
{
    public class Menu 
    {
        Dictionary getword = new Dictionary();
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
        }

        // public bool gameOptions()
        // {
        //     ForegroundColor = ConsoleColor.DarkMagenta;
        //     WriteLine("Vill du spela? Tryck [s]");
        //     WriteLine("Vill du lägga till ord i ordlistan? Tryck [o]");
        //     ForegroundColor = ConsoleColor.White;
        //     string playOrNey = ReadLine();
        //     Clear();
        //     if(playOrNey == "s")
        //     {
        //         return true;
        //     }
        //     else if(playOrNey == "o")
        //     {
        //         return false;
        //     }
        //     return false;
        // }

        
    }
    
}


//  _   _  _   _                                    _      _              _
// | | | ||_| |_|                                  | |    | |            | |
// | |_| | ____  _ __   ____   ____     ____  _   _| |___ | |___   ____  | |
// |  _  |/ _  \| '_ \ / _  \ / _  \   / _  \| | | | / _ \| / _ \ / __ \ |_|
// | | | | (_)  | | | | (_)  | (_)  | | (_)  | |_/ |  (_) |  (_) |  ___/  _
// |_| |_|\__/|_|_| |_|\__/| |\__/|_|  \__/| |\__|_|_|___/|_|___/ \____| |_|
//                     _   | |         _   | |                      
//                     \ \_/ /         \ \_/ /                      /\
//                      \___/           \___/                      /  \
//                                                                |    |
//                                                                 \__/    


//  _   _                                              _
// | | | |                                            | |
// | |_| | ____  _ __   ____  _ __  __   ____  _ __   | |
// |  _  |/ _  \| '_ \ / _  \| '_ \/_  |/ _  \| '_ \  |_| 
// | | | | (_)  | | | | (_)  | | | | | | (_)  | | | |  _
// |_| |_|\__/|_|_| |_|\__/| |_| |_| |_|\__/|_|_| |_| |_|
//                     _   | |         
//                     \ \_/ /         
//                      \___/          
//                                     
//                                     