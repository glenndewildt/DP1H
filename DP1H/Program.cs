using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP1H.Reader;
using DP1H.View;

namespace DP1H
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            while (s != "x") {
               // Circuit c = new Circuit(@"F:\School\DP1H\DP1H\Data\Circuit1_FullAdder.txt");
                Circuit c = new Circuit(@"c:\users\glenn\documents\visual studio 2015\Projects\DP1H\DP1H\Data\Circuit1_FullAdder.txt");

                
                c.Run();
                Console.WriteLine("Press any key to show cicuit");
                Console.ReadLine();
                Console.Clear();

                ViewController vc = new ViewController();
                vc.CreateGraphic(c);
                vc.DrawGraphics();

                Console.WriteLine("x to exit");
                s = Console.ReadLine();
                Console.Clear();
            }        
        }
    }
}
