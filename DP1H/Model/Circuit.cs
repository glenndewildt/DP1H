using DP1H.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class Circuit : GateComposite
    {
        public new Dictionary<string, GateComposite> circuit;

        public Circuit(string path) {
            FileReader r = new FileReader();
            circuit = r.ReadFile(path);

           
        }
        public Circuit(){ }
        public override string getType() { return type; }


        public override GateComposite Clone()
        {
            return new Circuit() { circuit = this.circuit };
        }

        public override List<GateComposite> GetConnectedNodes()
        {
            return circuit.Select(kvp => kvp.Value).ToList();
        }

        public override void Run()
        {
            foreach (KeyValuePair<string, GateComposite> entry in circuit)
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

        public void CreateGraphic(){
          
        }
    }
}
