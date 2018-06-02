using DP1H.Exceptions;
using DP1H.Factory;
using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DP1H.Reader
{
    public class FileReader
    {


        public Dictionary<string, GateComposite> ReadFile(string path) {
            Dictionary<string, GateComposite> nodes = new Dictionary<string, GateComposite>();

            string[] lines = System.IO.File.ReadAllLines(path);
            NodeFactory factory = new NodeFactory();
            factory.RegisterNode("PROBE", new Probe());
            factory.RegisterNode("OR", new OR());
            factory.RegisterNode("AND", new AND());
            factory.RegisterNode("NOT", new NOT());
            factory.RegisterNode("INPUT_HIGH", new InputHigh());
            factory.RegisterNode("INPUT_LOW", new InputLow());


            int counter = 0;
            foreach (string line in lines)
            {
                    Regex regex = new Regex("^(.*):");
                    var r = regex.Match(line);
                    string k = r.Groups[1].ToString();
                  

                        Regex regex1 = new Regex(":\t(.*);");
                        var r2 = regex1.Match(line);
                        string g = r2.Groups[1].ToString();
                        if (k != "" &&g != "" )
                        {
                            try {
                                nodes.Add(k, factory.createNode(g));
                            }catch (WrongInputException e){
                                Console.WriteLine("Input corrupted!");
                                Console.WriteLine("corruption at line: " + counter);
                                Console.WriteLine("line: " + line);

                                String seperator = "";
                                for (int i = 0; i < (e.InnerException.Message.Length * 1.1); i++){
                                    seperator += "-"; 
                                }
                                Console.WriteLine(seperator);
                                Console.WriteLine("Error: " + e.InnerException.Message);
                                Console.WriteLine(seperator);
                                Console.WriteLine("Press any key to exit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                                return null;
                            }

                        }
                    

                    
                counter++;

                if (line.Contains("#")) {
                    break;
                }
            }
            for (int x = lines.Length-1 ; x > counter-1; x--) {
                foreach (KeyValuePair<string, GateComposite> entry in nodes)
                {
                    Regex regex = new Regex("^(.*):");
                    var r = regex.Match(lines[x]);
                    string k = r.Groups[1].ToString();

                    if (k == entry.Key )
                    {
                        entry.Value.connected_nodes = new List<GateComposite>();

                        Regex regex1 = new Regex(":\t(.*);");
                        var r1 = regex1.Match(lines[x]);
                        string t = r1.Groups[1].ToString();

                        string[] data = t.ToString().Split(',');
                        foreach (var d in data)
                        {
                            GateComposite myNode ;
                            if (nodes.TryGetValue(d, out myNode))
                            {
                                entry.Value.connected_nodes.Add(myNode);
                            }

                        }

                    }


                }
                
            }
            return nodes;

        }

    }
}
