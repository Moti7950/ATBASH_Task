using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH_Task
{
    internal class Program
    {
        static void DecryptAtbadh(string input)
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

            List<string> dicript = new List<string>();
            foreach (char c in input)
            {
                if (atbashCipher.ContainsKey(c))
                {
                    dicript.Add(atbashCipher[c].ToString());
                }
                else if (char.IsWhiteSpace(c))
                {
                    dicript.Add(" ");
                }
                else
                {
                    Console.WriteLine("Not in ATBASH Dicti!");
                }
                    
            }
        }

        static void Main(string[] args)
        {
            


        }
    }
}
