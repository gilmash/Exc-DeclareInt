using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_DeclareInt02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 120 / 7;
            Console.WriteLine("120除以7商數:"+i);

            i = 120 % 7;
            Console.WriteLine("120除以7餘數:" + i);

        }
    }
}
