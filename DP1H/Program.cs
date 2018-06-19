using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP1H.Reader;
using DP1H.View;
using System.IO;

namespace DP1H
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            while (s != "x") {

                string filename = "Circuit1_FullAdder.txt";
 //             string filename = "Circuit4_InfiniteLoop.txt";
 //             string filename = "Circuit5_NotConnected.txt";
               var path =  Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+"\\Data\\",filename);

                Circuit c = new Circuit(path);


                ErrorChecker errorChecker = new ErrorChecker();
                errorChecker.CheckForErrors(c.path);
                ViewController vc = new ViewController();
                vc.CreateGraphic(c);
                
                c.Run();
                vc.DrawGraphics();

                Console.WriteLine("x to exit");
                s = Console.ReadLine();
                Console.Clear();
            }        
        }
    }
}
