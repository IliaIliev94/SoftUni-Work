using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    static class Morse
    {
        public static Dictionary<string, char> morseCodeToLetters = new Dictionary<string, char>()
            {
                {".-",  'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G' },
                {"....", 'H' },
                {"..", 'I' },
                {".---", 'J'},
                {"-.-", 'K' },
                {".-..", 'L'},
                {"--", 'M' },
                {"-.", 'N'},
                {"---", 'O' },
                {".--.", 'P' },
                {"--.-", 'Q' },
                {".-.", 'R' },
                {"...", 'S' },
                {"-", 'T' },
                {"..-", 'U' },
                {"...-", 'V' },
                {".--", 'W' },
                {"-..-", 'X' },
                {"-.--", 'Y' },
                {"--..", 'Z' }
            };
        public static List<string> TextToMorse(string[] s)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                string[] letters = s[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string temp = new string("");
                for (int j = 0; j < letters.Length; j++)
                {
                    temp += morseCodeToLetters[letters[j]];
                }
                result.Add(temp);
            }
            return result;
        }
    }
}
