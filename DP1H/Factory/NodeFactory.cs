using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Factory
{
    class NodeFactory
    {
        private Dictionary<string, Node> _nodes;
       public NodeFactory() {
            _nodes = new Dictionary<string, Node>();
        }
        public void RegisterNode(string name, Node node) {
            _nodes.Add(name, node);
        }
        public Node createNode(string type) {
            Node node = _nodes[type];
            return node.Clone();
        }
    }
}
