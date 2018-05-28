using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class Probe: Gate
    {
        public override void toString()
        {
            Console.WriteLine("Probe");
        }
        public override Node Clone()
        {

            return new Probe() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }
        public override void Run()
        {

            Console.WriteLine("Result= " +input1 + "");
        }
    }
}
