using DP1H.Exceptions;
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

        public void CheckForErrors(String s)
        {
            Circuit copy = new Circuit(@s);
            
            try
            {

                foreach (KeyValuePair<string, GateComposite> entry in copy.circuit)
                {
                    if (entry.Value.GetType().Name == "InputHigh")
                    {
                        Gate g = (Gate) entry.Value;
                        g.CheckConnected();
                    }
                    else if (entry.Value.GetType().Name == "InputLow")
                    {
                        Gate g = (Gate)entry.Value;
                        g.CheckConnected();

                    }
                }

                copy.DefaultRun();

                List<GateComposite> faultygates = new List<GateComposite>();
                foreach (GateComposite gc in copy.GetConnectedNodes())
                {
                    if(gc.value == -1)
                    {
                        faultygates.Add(gc);
                    }
                }

                bool faulty = false;
                
                if(faultygates.Count() > 0)
                {
                    foreach (GateComposite gc in faultygates)
                    {
                        if(gc.getType() == "Probe")
                        {
                            faulty = true;
                            break;
                        }
                    }


                    if (faulty){
                        Console.WriteLine("Error occured.");
                        Console.WriteLine("Probes not reachable");

                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                
            } catch(InfiniteLoopException e)
            {
                Console.WriteLine("Error occured.");
                Console.WriteLine("Infinite Loop");

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            } catch(Exception j)
            {

            }


            Console.Clear(); 


        }
    }
}
