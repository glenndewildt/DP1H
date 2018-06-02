using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP1H.Reader;

namespace DP1H
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            while (s != "x") {
                Circuit c = new Circuit(@"/Users/daPlaque/Documents/School/DP1H/DP1H/Data/Circuit1_FullAdder.txt");
                c.Run();
            }
           
            Console.WriteLine("x to exit");
             s = Console.ReadLine();
           
        }
    }
}
