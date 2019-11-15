﻿using System;
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
        }
    }
}
