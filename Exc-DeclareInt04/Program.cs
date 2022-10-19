using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_DeclareInt04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25;
            int num2 = 90;
            int change = num1;

            num1 = num2;
            num2 = change;

            Console.WriteLine($"對調結果:num1={num1},num2={num2}");
        }
    }
}
