﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint4
{
    public class Calculator
    {
        
        public int RandomKeyGenerator()
        {
            Random randomNumber = new Random();
            int key = randomNumber.Next(1, 100);
            while (true)
            {
                if (key != 26 || key != 52 || key != 78)
                {
                    return key;
                }
                else
                {
                    randomNumber = new Random();
                }
            }
           
        }
        private static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

    }
}
