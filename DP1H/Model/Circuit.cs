using DP1H.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class Circuit : Node
    {
        public Dictionary<string, Node> circuit;

        public Circuit(string path) {
            FileReader r = new FileReader();
            circuit = r.ReadFile(path);

           
        }
        public Circuit(){ }

        public override Node Clone()
        {
            return new Circuit() { circuit = this.circuit };
        }

        public override List<Node> GetConnectedNodes()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            foreach (KeyValuePair<string, Node> entry in circuit)
            {
                if (entry.Value.GetType().Name == "InputHigh")
                {
                    entry.Value.Run();
                }
                else if (entry.Value.GetType().Name == "InputLow")
                {
                    entry.Value.Run();

                }
            }
        }

        public override void toString()
        {
            throw new NotImplementedException();
        }
    }
}
