using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class InputHigh: Gate
    {
        public override void toString()
        {
            Console.WriteLine("INPUT");
        }
        public override Node Clone()
        {

            return new InputHigh() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }

    }
}
