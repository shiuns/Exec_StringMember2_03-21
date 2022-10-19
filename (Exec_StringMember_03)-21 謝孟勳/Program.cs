using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Exec_StringMember_03__21_謝孟勳
{
    //將字串 "aLLeN kUO" 轉換成 "Allen Kuo"

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "a", "L", "L", "e", "N"," ", "k", "U", "O" };

            Console.Write(name[0].ToUpper());
            Console.Write(name[1].ToLower());
            Console.Write(name[2].ToLower());
            Console.Write(name[3].ToLower());
            Console.Write(name[4].ToLower());
            Console.Write(name[5].ToLower());
            Console.Write(name[6].ToUpper());
            Console.Write(name[7].ToLower());
            Console.WriteLine(name[8].ToLower());
        }
    }
}
