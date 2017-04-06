using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> keyPad = new List<string> { " ", " ", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            List<string> finalCombinations = new List<string> { "" };

            while (true)
            {
                string input = System.Console.ReadLine();   // read user input

                foreach (char number in input)  // loop through each number in user input
                {
                    List<string> currentCombinations = new List<string>();

                    foreach (char letter in keyPad[number - 48])    // loop through each "letter" for each "digit" in keypad
                    {
                        foreach (string item in finalCombinations)
                        {
                            currentCombinations.Add(item.Replace(" ", "") + letter); // append current "letter" in keypad to existing combinations
                        }
                    }

                    finalCombinations = currentCombinations;    // store current combinations found with previous combinations
                }

                foreach (string item in finalCombinations)
                {
                    System.Console.WriteLine(item); // print output - all combinations found
                }

                // clear and rest list
                finalCombinations.Clear();
                finalCombinations.Add("");
            }
        }
    }
}
