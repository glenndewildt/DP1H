using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
   abstract public class Node : NodeInterface
    {
       public int input1;
       public int input2;
       public List<Node> connected_nodes;
        abstract  public Node Clone();
        abstract public List<Node> GetConnectedNodes();
        abstract public  void toString();

    }
}
