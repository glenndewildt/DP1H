using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
   abstract public class GateComposite : NodeInterface
    {
        public int input1 = -1;
        public int input2  = -1;
        public int value = -1;
        public string type;

        public List<GateComposite> connected_nodes;
        public Dictionary<string, GateComposite> circuit;
        abstract public string getType();

        abstract public void Run();
        abstract  public GateComposite Clone();
        abstract public List<GateComposite> GetConnectedNodes();
        abstract public  void toString();


    }
}
