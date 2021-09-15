using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONDITIONAL_STATEMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            double pepperLength = 4;

            string message = (pepperLength >= 3.5) ? "Are you ready!" : "Just wait a little while longer";

            Console.WriteLine(message);
        }
    }
}
