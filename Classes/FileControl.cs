using System;
using static System.Console;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VSC_Hangman.Classes
{
    public class FileControl
    {
        public string jsonPath = @"dictionary.json";

        // serialize json-data
        public void Serialize(string jsonData, List<WordList> wordList)
        {
            // serialize data and save to json
            jsonData = JsonConvert.SerializeObject(wordList);
            System.IO.File.WriteAllText(jsonPath, jsonData);
        }

        public void Deserialize(out string jsonData, out List<WordList> wordList)
        {
            var json = System.IO.File.ReadAllText(jsonPath);

            // deserialize and make list
            var DeserializedWord = JsonConvert.DeserializeObject<List<WordList>>(json);

            jsonData = json;
            wordList = DeserializedWord;
        }
    }
}