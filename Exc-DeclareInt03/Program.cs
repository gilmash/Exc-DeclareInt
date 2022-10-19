using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exc_DeclareInt03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
            int k = 202;

            if (i % 2 == 0)
            {
                Console.WriteLine(i + "為偶數");
            }
            else
            {
                Console.WriteLine(i + "為奇數");

            }
            if (k % 2 == 0)
            {
                Console.WriteLine(k + "為偶數");
            }
            else
            {
                Console.WriteLine(k + "為奇數");
            }    
        }
    }
}
