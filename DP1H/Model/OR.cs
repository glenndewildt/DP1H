using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class OR:Gate
    {
        public override void toString()
        {
            Console.WriteLine("OR");
        }
        public override Node Clone()
        {

            return new OR() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }
    }
}
