using System;
using System.Collections.Generic;

namespace AdvancedTypes
{
    public class App
    {
        public void Greeting()
        {
            Console.WriteLine("Hello Class.");
        }

        public void FrequentLetter(string randomWord)
        {
            //1. we need to initialize a dictionary to keep track of all of the letters and their number of instances
            Dictionary<char, int> instances = new Dictionary<char, int>();
            //2. iterate over each letter in the word and increment the count of that letter's instances
            for (int i = 0; i < randomWord.Length; i++)
            {
                char ltr = randomWord[i];
                if (instances.ContainsKey(ltr))
                {
                    instances[ltr]++;
                }
                else
                {
                    instances.Add(ltr, 1);
                }
            }
            //3. after looping return the letter with the greatest count
            /**
            {
                m: 1,
                i: 4,
                s: 4,
                p: 2
                ...
            }
             */
            char letter = ' ';
            int mostOccurances = 0;
            foreach (var kvp in instances)
            {
                if (kvp.Value > mostOccurances)
                {
                    mostOccurances = kvp.Value;
                    letter = kvp.Key;
                }
            }
            Console.WriteLine($"The most occuring letter in {randomWord} is: {letter}");
        }








        public void Run()
        {
            //NOTE Bracket vs Dot notation
            //colors.red; //NOTE looks for the property literally called red
            // string color = "red";
            // colors[color]; //NOTE looks for the property whos name is the same as the value of this variable

            Console.WriteLine("Give me a word and I'll tell you the most frequently occuring letter");
            string randomWord = Console.ReadLine();
            FrequentLetter(randomWord);
            return;









            Dictionary<int, int> studentGrades = new Dictionary<int, int>();
            studentGrades.Add(2, 88);
            studentGrades.Add(12, 80);
            studentGrades.Add(22, 98);
            studentGrades.Add(33, 70);

            Dictionary<string, List<string>> colors = new Dictionary<string, List<string>>();
            colors.Add("red", new List<string>() { "Firetruck", "Apple", "Stop Sign" });
            colors.Add("blue", new List<string>() { "Ocean", "Sky" });
            colors.Add("green", new List<string>() { "Grass", "Leaves", "The Grinch" });
            colors.Add("yellow", new List<string>() { "Sun", "Sun Flowers", "Sun Dresses" });

            Console.WriteLine("Please select one of the following:");
            foreach (var kvp in colors)
            {
                Console.WriteLine($"{kvp.Key}");
            }














            string userInput = Console.ReadLine();
            if (colors.ContainsKey(userInput)) //Allieviated the danger on the lines below
            {
                Console.WriteLine("These things are " + userInput + ":");
                foreach (string item in colors[userInput]) //Dangerous because not checking if key exists first
                {
                    Console.WriteLine($"{item}");
                }
            }






















            // NOTE don't forget to instantiate your lists and dictionaries.
            List<string> staff = new List<string>();
            staff.Add("Porter");
            staff.Add("Zach");
            staff.Add("Brittany");
            staff.Add("Brooklyn");
            staff.Add("Jake");
            for (int i = 0; i < staff.Count; i++)
            {
                string name = staff[i]; //alias
                // Console.WriteLine($"{i+1}. {name}");
            }
            // lets learn how to utilize a list method that takes a callback function
            // NOTE with query functions the syntax is: `variableName` => condition utilizing the `variableName`
            staff.Exists(staffMember => staffMember == "Brittany");
            staff.FindAll(staffMember => staffMember[0] == 'B');
        }


        bool ExistsLongHandExample(string target)
        {
            #region
            List<string> staff = new List<string>();
            staff.Add("Porter");
            staff.Add("Zach");
            staff.Add("Brittany");
            staff.Add("Jake");
            #endregion
            for (int i = 0; i < staff.Count; i++)
            {
                string staffMember = staff[i]; //alias
                if (staffMember == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}