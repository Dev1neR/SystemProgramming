using System;
using Lab6Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor i7 = new Processor("i7", "8700", "1151", "6");
            i7.Freq = 3200;
            Console.WriteLine(i7);
            Processor i5 = new Processor("i5", "7700k", "1151", "4");
            i5.Freq = 4200;
            Console.WriteLine(i5);
            Console.ReadKey();
        }
    }
}