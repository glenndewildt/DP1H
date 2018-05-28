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

            foreach (KeyValuePair<string, Node> entry in t)
            {
                if (entry.Value.GetType().Name == "InputHigh") {
                    entry.Value.Run();
                }
                else if (entry.Value.GetType().Name == "InputLow") {
                    entry.Value.Run();

                }
            }

                Console.ReadLine();
           
        }
    }
}
