using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;

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
        static string displayWarning(string text, string[] words)
        {
            string decryptedText = DecryptAtbadh(text);
            int count = checkIfDangrues(decryptedText, words);

            string finalMessage = "";
            if (count > 0 && count <= 5)
            {
                finalMessage += "WARNING";
            }
            else if (count > 5 && count <= 10)
            {
                finalMessage += "DANGER!";
            }
            else if (count > 10 && count <= 15)
            {
                finalMessage += "ULTRA ALERT";
            }

            return $"{decryptedText}  {"\n"}  {finalMessage} {count}";
        }
        

        static void Main(string[] args)
        {
            string x = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.\r\n\r\n";
            string[] y = { "BOMB", "NUKBA", "FIGHTER", "ROCKET", "SECRET" };
            Console.WriteLine(displayWarning(x, y));

        }
    }
}
