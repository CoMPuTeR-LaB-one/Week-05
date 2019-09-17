using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Line 1");
            goto line4;
            line2:
            Console.Write("Line 2");
            goto line9;
            Console.WriteLine("Line 3");
        line4:
            Console.Write("Line 4");
            Console.Write("Line 5");
            goto line2;
            Console.Write("Line 6");
            Console.Write("Line 7");
            Console.Write("Line 8");
            line9:
            Console.Write("Line 9");
       
        }
    }
}
