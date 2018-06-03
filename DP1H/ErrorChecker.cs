using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H
{
    class ErrorChecker
    {

        public void CheckForErrors(Circuit c)
        {
            try
            {
                Circuit copy = c;
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
