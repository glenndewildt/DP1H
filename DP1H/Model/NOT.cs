using DP1H.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    public class NOT : Gate
    {

        public NOT()
        {
            this.type = "NOT";
        }
        public override void toString()
        {
            Console.WriteLine("NOT");
        }
        public override GateComposite Clone()
        {

            return new NOT() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }

        public override int Calculate()
        {
            int result = -1;
            if (input1 != -1) {
                if (input1 == 0)
                {
                    result = 1;
                }
                else {
                    result = 0;
                }
               
            }
            return result;           
        }

        public override void CheckInputs()
        {
            if (input1 == -1)
            {
                throw new ValuesNotSetException();
            }
            return;
        }

    }
}
