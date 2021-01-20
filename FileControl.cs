using System;
using static System.Console;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VSC_Hangman
{
    public class FileControl
    {
        public string jsonPath = @"dictionary.json";

        // serialize json-data
        public void Serialize(string jsonData, List<WordList> wordList)
        {
            // serialize data and save to json
            jsonData = JsonConvert.SerializeObject(wordList);
        }
    }
}