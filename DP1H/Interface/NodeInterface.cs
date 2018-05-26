using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    interface NodeInterface
    {
          List<Node> GetConnectedNodes();
          void toString();

    }
}
