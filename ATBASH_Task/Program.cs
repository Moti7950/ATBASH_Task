using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.IO;

namespace ATBASH_Task
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a message: ");
            string message = Console.ReadLine().ToUpper();
            Encreypte encreyptMessage = new Encreypte();
            string encripyVerabl = encreyptMessage.DecryptAtbadh(message);
            File.WriteAllText("C:\\Users\\User\\OneDrive - SaharPro\\שולחן העבודה\\לימודים\\הכשרה מודעין 😁\\visual_P\\ATBASH_Task\\ATBASH_Task\\File_VS\\s.txt", encripyVerabl);
            Console.WriteLine(encripyVerabl);
            Encreypte DecreyptMessage = new Encreypte();
            string decryptVerbel = DecreyptMessage.DecryptAtbadh(File.ReadAllText("C:\\Users\\User\\OneDrive - SaharPro\\שולחן העבודה\\לימודים\\הכשרה מודעין 😁\\visual_P\\ATBASH_Task\\ATBASH_Task\\File_VS\\s.txt"));
            Console.WriteLine(decryptVerbel + " Done");
        
        }
    }
}
