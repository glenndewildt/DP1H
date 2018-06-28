using DP1H.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    public class AND : Gate
    {
        public override void toString()
        {
            Console.WriteLine("AND");
        }
        public AND() {
            this.type = "AND";
        }
        public override GateComposite Clone()
        {

            return new AND() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }

        public override int Calculate()
        {
            int result = -1;
            if (input1 == 1 && input2 == 1)
            {
                result = 1;

            }
            else
            {
                result = 0;
            }

            return result;

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
