using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    public class Program
    {

        static void Main(string[] args)
        {
            try
            {
                String str = "ab-cd";
                string revStr = ReverseString(str);
                Console.WriteLine("Output string: " + revStr);
                str = "aa-bC-dEf-ghIj";
                revStr = ReverseString(str);
                Console.WriteLine("Output string: " + revStr);
                str = "Test1ng-Leet=code-Q";
                revStr = ReverseString(str);
                Console.WriteLine("Output string: " + revStr);
                str = "";
                revStr = ReverseString(str);
                Console.WriteLine("Output string: " + revStr);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
               // Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();

        }

        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Exception: Empty string: ");
            }
            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input string: " + str);
            reverse(charArray);
            String revStr = new String(charArray);
            return revStr;
        }

        public static void reverse(char[] str)
        {   
            int r = str.Length - 1;
            int l = 0;
                          
            while (l < r)
            { 
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;  
                else
                {
                    Swap(ref str[r], ref str[l]);
                    l++;
                    r--;
                }
            }
        }
       
        static void Swap<T>(ref T left, ref T right )
        {
            T tmp;
            tmp= left;
            left = right;
            right = tmp;
        }
    }
}
