using DP1H.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class NOR : Gate
    {
        public override void toString()
        {
            Console.WriteLine("NOR");
        }
        public NOR()
        {
            this.type = "NOR";
        }
        public override GateComposite Clone()
        {

            return new NOR() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }
 
        public override int Calculate()
        {
            if (input1 == 0 && input2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public override void SetValues(int value)
        {
            foreach (GateComposite node in connected_nodes)
            {
                if (node.input1 == -1)
                {
                    node.input1 = value;
                }
                else if (node.input2 == -1)
                {
                    node.input2 = value;
                }

                node.Run();
            }
        }

        public override void CheckInputs()
        {
            if (input1 == -1 || input2 == -1)
            {
                throw new ValuesNotSetException();
            }
            return;
        }

    }
}