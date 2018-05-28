using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class InputHigh: Gate
    {
        int value = -1;
        public override void toString()
        {
            Console.WriteLine("INPUT");
        }
        public override Node Clone()
        {

            return new InputHigh() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }
        public override void Run()
        {
     
            int x;
            bool g = false;
            while (!g)
            {
                Console.WriteLine("give input to the input node");
                string v = Console.ReadLine();
                if (Int32.TryParse(v, out x))
                {
                    if (x > -1 && x < 2)
                    {
                        value = x;
                        g = true;
                    }
                    else {
                        Console.WriteLine("use a number between 0 and 1");

                    }
                }
                else {
                    Console.WriteLine("use a number between 0 and 1");

                }
            }

            foreach (Node node in connected_nodes) {
                if (node.input1 == -1) {
                    node.input1 = value;
                    node.Run();
                }
                else if (node.input2 == -1)
                {
                    node.input2 = value;
                    node.Run();
                }
            }
        }

    }
}
