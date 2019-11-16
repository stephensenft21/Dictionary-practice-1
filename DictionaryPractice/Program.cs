using System;
using System.Collections.Generic;
namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

// Add several more words and their definitions
wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
wordsAndDefinitions.Add("Great", "of an extent, amount, or intensity considerably above the normal or average the article was of great interest");
wordsAndDefinitions.Add("Happy", "feeling or showing pleasure or contentment.");
wordsAndDefinitions.Add("Sad", "feeling or showing sorrow; unhappy. I was sad and subdued");
wordsAndDefinitions.Add("Content", "of an extent, amount, or intensity considerably above the normal or average the article was of great interest");


Console.WriteLine($"1. The Definition of Awesome is:{wordsAndDefinitions["Awesome"]}");
Console.WriteLine($"2. The Definition of Great is:{wordsAndDefinitions["Great"]}");
Console.WriteLine($"3. The Definition of Happy is:{wordsAndDefinitions["Happy"]}");
Console.WriteLine($"4. The Definition of Sad is:{wordsAndDefinitions["Sad"]}");
Console.WriteLine($"5. The Definition of Content is:{wordsAndDefinitions["Content"]}");

/*

    Use square brackets to get the definition of two of the
    words and then output them to the console
*/

/*
    Below, loop over the wordsAndDefinitions dictionary to get the following output:
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
*/
foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
{
        Console.WriteLine($" {word.Key} is {word.Value}");


}

// Make a new list
List<Dictionary<string, string>> dictionaryOfExcitedWords = new List<Dictionary<string, string>>();
List<Dictionary<string, string>> dictionaryOfBadWords = new List<Dictionary<string, string>>();
List<Dictionary<string, string>> dictionaryOfFunWords = new List<Dictionary<string, string>>();
List<Dictionary<string, string>> dictionaryOfNewWords = new List<Dictionary<string, string>>();




/*
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

// Create dictionary to represent a few words
Dictionary<string, string> excitedWord = new Dictionary<string, string>();
Dictionary<string, string> funWord = new Dictionary<string, string>();
Dictionary<string, string> badWord = new Dictionary<string, string>();
Dictionary<string, string> newWord = new Dictionary<string, string>();

// Add each of the 4 bits of data about the word to the Dictionary
excitedWord.Add("Word", "Yahoo!");
excitedWord.Add("Definition", "a rude, noisy, or violent person!");
excitedWord.Add("Part of speech", "noun");
excitedWord.Add("Example sentence", "that dude was such a yahoo!");
// Add each of the 4 bits of data about the word to the Dictionary
funWord.Add("Word","Bitchin");
funWord.Add("Definition","remarkably good or cool");
funWord.Add("Part of speech","adjective");
funWord.Add("Example sentence","that store was bitchin");
// Add each of the 4 bits of data about the word to the Dictionary
badWord.Add("Word","Butt");
badWord.Add("Definition","the thicker end of something, especially a tool or a weapon");
badWord.Add("Part of speech","noun");
badWord.Add("Example sentence","Thats a nice butt");

newWord.Add("Word","New");
newWord.Add("Defintion","Not existing before; made, introduced, or discovered recently or now for the first time.");
newWord.Add("Part of speech","adjective");
newWord.Add("Example sentence","She helped Carmen into the new dress.");


// Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfExcitedWords.Add(excitedWord);
            dictionaryOfBadWords.Add(badWord);
            dictionaryOfFunWords.Add(funWord);
            dictionaryOfNewWords.Add(newWord);
            



// create another Dictionary and add that to the list


/*
    Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/

// Iterate the List of Dictionaries
foreach (var wordData in dictionaryOfWords )
{

    // Iterate the KeyValuePairs of the Dictionary
    foreach (var word in wordData)
    {
        Console.WriteLine($"{word.Key}: {word.Value}");
    }
}
        }
    }
}
