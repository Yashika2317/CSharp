using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            String str, str2;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            str2 = interchage(str);
            Console.WriteLine("New string is: " + str2);
            Console.Read();

           
            


        }
         static string interchage(string str){
            if (str.Length > 1)
            {
                return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);

            }
            else
            {
                return str;
            }

        }
    }
}
