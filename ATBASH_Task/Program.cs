using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ATBASH_Task
{
    internal class Program
    {


        static int checkIfDangrues(string text, string[] words)
        {
            int count = 0;
            string[] listOfText = Regex.Split(text, "[^a-zA-Z]+");
            foreach (string word  in listOfText)
            {
                if (words.Contains(word))
                {
                    count++;
                }
            }
            return  count;
        }


        //check if char is Not Uppercase!!
        static string DecryptAtbadh(string input)
        {

            Dictionary<char, char> atbashCipher = new Dictionary<char, char>
            {
                {'A', 'Z'}, {'B', 'Y'}, {'C', 'X'}, {'D', 'W'}, {'E', 'V'},
                {'F', 'U'}, {'G', 'T'}, {'H', 'S'}, {'I', 'R'}, {'J', 'Q'},
                {'K', 'P'}, {'L', 'O'}, {'M', 'N'}, {'N', 'M'}, {'O', 'L'},
                {'P', 'K'}, {'Q', 'J'}, {'R', 'I'}, {'S', 'H'}, {'T', 'G'},
                {'U', 'F'}, {'V', 'E'}, {'W', 'D'}, {'X', 'C'}, {'Y', 'B'},
                {'Z', 'A'}
            };

            string dicript = "";
            foreach (char c in input)
            {
                char ci = char.ToUpper(c);
                if (atbashCipher.ContainsKey(ci))
                {
                    dicript += atbashCipher[ci].ToString();
                }
                else
                {
                    dicript += c;
                }
            }
            return dicript;
        }

        static void Main(string[] args)
        {
            string x = "Abckhd ndhdd";
            Console.WriteLine(DecryptAtbadh(x));

        }
    }
}
