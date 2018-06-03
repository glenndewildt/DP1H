using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DP1H
{
    class ErrorChecker
    {

        public void CheckForErrors(Circuit c)
        {
            Console.WriteLine("error checking.");
            Circuit copy = c;


            Thread t = new Thread(new ThreadStart(c.Run));
            t.Start();

            Console.WriteLine();

            int counter = 0;
            while (true)
            {
                Console.Write(". ");
                System.Threading.Thread.Sleep(1000);
                counter++;
                if(counter == 5)
                {
                    break;
                }
                
            }

            Console.WriteLine(t.ThreadState);
            Console.ReadKey();
            


            try
            {
                copy.Run();
                List<GateComposite> faultygates = new List<GateComposite>();
                foreach (GateComposite gc in copy.GetConnectedNodes())
                {
                    if(gc.value == -1)
                    {
                        faultygates.Add(gc);
                    }
                }
                   
                if(faultygates.Count() > 0)
                {
                    Console.WriteLine("Error occured.");
                    Console.WriteLine("Not all gates are in use.");
                    Console.WriteLine("Faulty gates: ");

                    foreach(GateComposite gc in faultygates)
                    {
                        Console.WriteLine(gc.getType());
                    }

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            } catch(Exception e)
            {

            }


        }
    }
}
