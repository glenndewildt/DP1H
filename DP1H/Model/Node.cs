using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
   abstract public class Node : NodeInterface
    {
       public int input1 = -1;
       public int input2  = -1;
       public List<Node> connected_nodes;
        abstract public void Run();
        abstract  public Node Clone();
        abstract public List<Node> GetConnectedNodes();
        abstract public  void toString();

    }
}
