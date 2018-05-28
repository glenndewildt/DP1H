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


        public Dictionary<string, Node> ReadFile() {
            Dictionary<string, Node> nodes = new Dictionary<string, Node>();

            string[] lines = System.IO.File.ReadAllLines(@"c:\users\glenn\documents\visual studio 2015\Projects\DP1H\DP1H\Data\Circuit1_FullAdder.txt");
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
                            nodes.Add(k, factory.createNode(g));

                        }
                    

                    
                counter++;

                if (line.Contains("#")) {
                    break;
                }
            }
            for (int x = lines.Length-1 ; x > counter-1; x--) {
                foreach (KeyValuePair<string, Node> entry in nodes)
                {
                    Regex regex = new Regex("^(.*):");
                    var r = regex.Match(lines[x]);
                    string k = r.Groups[1].ToString();

                    if (k == entry.Key )
                    {
                        entry.Value.connected_nodes = new List<Node>();

                        Regex regex1 = new Regex(":\t(.*);");
                        var r1 = regex1.Match(lines[x]);
                        string t = r1.Groups[1].ToString();

                        string[] data = t.ToString().Split(',');
                        foreach (var d in data)
                        {
                            Node myNode ;
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
