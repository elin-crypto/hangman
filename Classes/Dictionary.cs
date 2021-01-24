using System;
using static System.Console;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;

namespace VSC_Hangman.Classes
{
    public class Dictionary 
    {
        FileControl serialize = new FileControl();
        WordList wordList = new WordList();

        public void addNewWord()
        {
            string word;
            do
            {
                CursorVisible = true;
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Lägg till ett nytt ord i listan.");
                word = ReadLine();
                if(word == "")
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Du måste skriva något");
                    ForegroundColor = ConsoleColor.White;
                    word = ReadLine();
                } 
                else if(Regex.Matches(word, @"^[a-zåäöA-ZÅÄÖ]+$").Count == 0)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Ordet får inte innehålla siffror!");
                    ForegroundColor = ConsoleColor.White;
                    word = ReadLine();
                }
                
            }    
            while(word == "" || Regex.Matches(word, @"^[a-zåäöA-ZÅÄÖ]+$").Count == 0 );

            //deserialize method
            serialize.Deserialize(out string jsonData, out List<WordList> wordList);

            // add new word to list
            wordList.Add(new WordList()
            {
                Word = word,
            });

            // serialize list method
            serialize.Serialize(jsonData, wordList);
            Clear();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("Ditt ord har blivit tillagt!");
            Thread.Sleep(3000);
            Clear();
        }

        public string getNewWord()
        {
            // Deserialize existing words
            serialize.Deserialize(out string jsonData, out List<WordList> wordList);

            // pick random word from json-file and return it
            Random rnd = new Random();
            var rndWord = wordList[rnd.Next(0, wordList.Count)];
            return rndWord.Word;
        }

        public void writeWordlist()
        {
            serialize.Deserialize(out string jsonData, out List<WordList> wordList);
            // Skriver ut en lista med alla orden!
            int id = 1;
            foreach(var ord in wordList)
            {
                Write($"{id} \t {ord.Word}\n");
                id++;
            }
        }

        public void deleteWord()
        {
            bool delControl = true;
            serialize.Deserialize(out string jsonData, out List<WordList> wordList);


        
            writeWordlist();
         

            while(delControl)
            {
                WriteLine();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Skriv id på det ord du vill radera");
                ForegroundColor = ConsoleColor.White;
                string chosenId = ReadLine();
                try
                {
                    int intId = int.Parse(chosenId) -1; // convert to integer and correct id
                    WriteLine();
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine($"Är du säker på att du vill radera inlägg {chosenId}. [j/n]");
                    WriteLine();
                    if(ReadLine() == "j")
                    {
                        wordList.RemoveAt(intId);

                        // serialize list method
                        serialize.Serialize(jsonData, wordList);
                        Clear();

                        ForegroundColor = ConsoleColor.DarkMagenta;
                        WriteLine("Ordet har raderats");
                        Thread.Sleep(2000);
                        Clear();
                        delControl = false;
                    }
                    else
                    {
                        Clear();
                        ForegroundColor = System.ConsoleColor.DarkMagenta;
                        WriteLine("\nGött, listan är alltså bra som den är! :) \n");
                        Thread.Sleep(3000);
                        Clear();
                        delControl = false; // get out of loop and quit
                    }
                }
                catch(ArgumentOutOfRangeException) // if number isn't in list
                {
                    Clear();
                    ForegroundColor = System.ConsoleColor.White;
                    writeWordlist();
                    WriteLine();
                    ForegroundColor = System.ConsoleColor.DarkRed;
                    WriteLine("Du måste ange ett nummer som finns i listan.");
                    ForegroundColor = System.ConsoleColor.White;
                }
                catch(FormatException) // if input isn't a number
                {
                    Clear();
                    writeWordlist();
                    WriteLine();
                    ForegroundColor = System.ConsoleColor.DarkRed;
                    WriteLine("Du måste ange en siffra. Försök igen");
                }      
            }
        }   
    }
}


