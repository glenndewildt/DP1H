using DP1H.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{

    public class OR:Gate
    {

        int runCounter = 0;
        public override void toString()
        {
            Console.WriteLine("OR");
        }
        public OR()
        {
            this.type = "OR";
        }
        public override GateComposite Clone()
        {

            return new OR() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }

        public override int Calculate()
        {
            int result = -1;
            if (input1 == 0 && input2 == 0)
            {
                result = 0;

            }
            else {
                result = 1;
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
