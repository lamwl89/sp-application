using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] keyPad = new char[10, 4] 
            { { ' ', ' ', ' ',' ' }, { ' ', ' ', ' ',' ' }, { 'a', 'b', 'c',' ' }, { 'd', 'e', 'f',' ' }, { 'g', 'h', 'i',' ' },
            { 'j', 'k', 'l',' ' }, { 'm', 'n', 'o',' ' }, { 'p', 'q', 'r', 's' }, { 't', 'u', 'v',' ' }, { 'w', 'x', 'y', 'z' } };

            while (true)
            {
                char[] input = System.Console.ReadLine().ToCharArray(); // read user input

                string word;

                int counter = 0;

                List<string> result = new List<string>();

                System.IO.StreamReader dictionary = new System.IO.StreamReader("c:\\WordsRTF.RTF");    // read file
                while ((word = dictionary.ReadLine()) != null)
                {
                    if (word.Length == input.Length)    // check for words in file with same length as user input
                    {
                        for (int i = 0; i < input.Length; i++)  // loop through each letter in user input
                        {
                            for (int j = 0; j < keyPad.GetLength(1); j++)   // loop through each "letter" for each "digit" in keypad
                            {
                                if (Char.ToLower(word[i]) == keyPad[Convert.ToInt16(input[i]) - 48, j]) // check if letter in input matches the letter in keypad
                                {
                                    counter++;
                                }
                            }
                        }

                        if (counter == word.Length) // check if all letters in input matches
                        {
                            result.Add(word);
                        }

                        counter = 0;
                    }
                }

                dictionary.Close(); // end file reading

                foreach (string item in result)
                {
                    Console.WriteLine(item);    // print output - possible combinations from file
                }
            }
        }
    }
}
