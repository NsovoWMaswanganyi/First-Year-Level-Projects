using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Check_your_IQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("What is your IQ socre? ");
            int IQ = int.Parse(ReadLine());

            if (IQ < 0 || IQ > 200)
                WriteLine("Invalid IQ");
            else if (IQ < 100)
                WriteLine("IQ is below Average");
            else if (IQ == 100)
                WriteLine("IQ is average");
            else if (IQ > 100)
                WriteLine("IQ is above average");

            ReadLine();

        }
    }
}
