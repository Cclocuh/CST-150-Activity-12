using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Counting_Number_of_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str;
            int word, l;

            //str = Console.Readline();
            string str = System.IO.File.ReadAllText(@"C:\Users\ccloc\source\repos\Counting Number of Words\Text folder\TextFile2.txt");

            l = 1;
            word = 1;

            //loop till end of string
            while (l <= str.Length - 1)
            {
                //check whether the current character is white space or new line
                if((str[l] == '.' || str[l] == ' ' || str[l] == '\t' || str[l] == '!' || str[l] == ',' || str[l] == '?' || str[l] == '\n') && (str[l - 1] == 't' || str[l - 1] == 'e'))
                {   
                    word++;
                }

                l++;
            }

            Console.WriteLine("There are {0} words ending in t or e", word);
            Console.ReadLine();
        }
    }
}
