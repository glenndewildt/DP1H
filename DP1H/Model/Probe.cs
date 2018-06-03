using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    public class Probe: Gate
    {
        public override void toString()
        {
            Console.WriteLine("Probe");
        }
        public Probe()
        {
            this.type = "Probe";
        }
        public override int Calculate()
        {
            return input1;
        }
        public override GateComposite Clone()
        {

            return new Probe() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }
        public override void Run()
        {
            TemplateRun();
        }

        public override void PrintResult()
        {
            var thisObject = self;
            Console.WriteLine("Result= " + input1 + "");
        }

        public override void SetValues(int value)
        {
            
        }

        public override void SetOutput()
        {
           
        }
        public override void CheckInputs()
        {
            
        }

        public override void RunInitial()
        {
           
        }

    }
}
