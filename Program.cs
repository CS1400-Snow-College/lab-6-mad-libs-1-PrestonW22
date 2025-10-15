//preston waters 10/15/25 MadLibs

using System.Text.RegularExpressions;

Console.Clear();
Console.WriteLine($"This is Mad Libs. When you are dong providing the requested words\nI will build them into a funny story for you\nEnter the requested word types\n");

string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”). Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body). My family is going to go to (place) and I will practice (verb ending in “ing”). Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";

        
        string pattern = @"(\([^)]*\))";
        string[] parts = Regex.Split(originalStory, pattern);

        string newStory = "";

        foreach (string part in parts)
        {
            string trimmed = part.Trim();

            if (trimmed.StartsWith("(") && trimmed.EndsWith(")"))
            {
                string placeholder = trimmed.Trim('(', ')');

                Console.Write($"Please enter a {placeholder}: ");
                string input = Console.ReadLine()!;

                newStory += input + " ";
            }
            else
            {
                newStory += trimmed + " ";
            }
        }

Console.WriteLine("\nNew Story:\n");
Console.WriteLine(newStory);