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
        public override void Run()
        {

            if (input1 != -1 || input2 != -1) {
               int value =  Calculate();
                foreach (Node node in connected_nodes)
                {
                    if (node.input1 == -1)
                    {
                        node.input1 = value;
                        node.Run();
                    }
                    else if  (node.input2 == -1)
                    {
                        node.input2 = value;
                        node.Run();
                    }
                }
            }
            else {
                return;
            }
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
    }
}
