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
            FileReader r = new FileReader();
            var t = r.ReadFile();

            Console.ReadLine();
           
        }
    }
}
