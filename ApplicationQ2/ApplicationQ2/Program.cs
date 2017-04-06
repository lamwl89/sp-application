using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationQ2
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

                for (int i = 0; i < input.Length; i++)  // loop through each letter in user input
                {
                    for (int j = 0; j < keyPad.GetLength(0); j++)   // loop through each "digit" in keypad
                    {
                        for (int k = 0; k < keyPad.GetLength(1); k++)   // loop through each "letter" for each "digit" in keypad
                        {
                            if (input[i] == keyPad[j, k])   // check if letter in input matches the letter in keypad
                            {
                                System.Console.Write(j);    // print output - "digit" in keypad for letter
                            }
                        }
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}
