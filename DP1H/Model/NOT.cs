using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class NOT : Gate
    {
     

        public override void toString()
        {
            Console.WriteLine("NOT");
        }
        public override Node Clone()
        {

            return new NOT() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }
    }
}
