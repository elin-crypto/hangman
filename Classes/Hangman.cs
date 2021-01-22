using System;
using static System.Console;

namespace VSC_Hangman.Classes
{
    public class Hangman 
    {
        public void printMan(int nbrOfErr)
        {

            switch(nbrOfErr)
            {
                case 0:
                    WriteLine(@"         =====");
                    WriteLine(@"          |  ║");
                    WriteLine(@"             ║");
                    WriteLine(@"             ║"); 
                    WriteLine(@"             ║");
                    WriteLine(@"             ║");
                    WriteLine(@"         =====");
                    break;
                case 1:
                    WriteLine(@"         =====");
                    WriteLine(@"          |  ║");
                    WriteLine(@"          o  ║");
                    WriteLine(@"             ║"); 
                    WriteLine(@"             ║");
                    WriteLine(@"             ║");
                    WriteLine(@"         =====");
                    break;
                case 2:
                    WriteLine(@"         =====");
                    WriteLine(@"          |  ║");
                    WriteLine(@"          o  ║");
                    WriteLine(@"          |  ║"); 
                    WriteLine(@"             ║");
                    WriteLine(@"             ║");
                    WriteLine(@"         =====");
                    break;
                case 3:
                    WriteLine(@"         =====");
                    WriteLine(@"          |  ║");
                    WriteLine(@"          o  ║");
                    WriteLine(@"         /|  ║"); 
                    WriteLine(@"             ║");
                    WriteLine(@"             ║");
                    WriteLine(@"         =====");
                    break;
                case 4:
                    WriteLine(@"         =====");
                    WriteLine(@"          |  ║");
                    WriteLine(@"          o  ║");
                    WriteLine(@"         /|\ ║"); 
                    WriteLine(@"             ║");
                    WriteLine(@"             ║");
                    WriteLine(@"         =====");
                    break;
                case 5:
                    WriteLine(@"         =====");
                    WriteLine(@"          |  ║");
                    WriteLine(@"          o  ║");
                    WriteLine(@"         /|\ ║"); 
                    WriteLine(@"           \ ║");
                    WriteLine(@"             ║");
                    WriteLine(@"         =====");
                    break;
                case 6:
                    WriteLine(@"         =====");
                    WriteLine(@"          |  ║");
                    WriteLine(@"          o  ║");
                    WriteLine(@"         /|\ ║"); 
                    WriteLine(@"         / \ ║");
                    WriteLine(@"             ║");
                    WriteLine(@"         =====");
                    break;
            }
                  
        }

        
    }
    
}