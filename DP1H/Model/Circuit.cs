using DP1H.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
   public class Circuit : GateComposite
    {
        public new Dictionary<string, GateComposite> circuit;
        public string path;
        public Circuit(string path) {
            FileReader r = new FileReader();
            r.ReadFile(path);
            circuit = r.GetNodes();
            this.path = path;

           
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

        public void DefaultRun()
        {
            foreach (KeyValuePair<string, GateComposite> entry in circuit)
            {
                if (entry.Value.GetType().Name == "InputHigh")
                {
                    InputHigh ih = (InputHigh) entry.Value;
                    ih.DefaultRun();
                }
                else if (entry.Value.GetType().Name == "InputLow")
                {
                    InputLow il = (InputLow) entry.Value;
                    il.DefaultRun();

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
