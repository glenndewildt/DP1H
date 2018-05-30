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
        private Dictionary<string, GateComposite> _nodes;
       public NodeFactory() {
            _nodes = new Dictionary<string, GateComposite>();
        }
        public void RegisterNode(string name, GateComposite node) {
            _nodes.Add(name, node);
        }
        public GateComposite createNode(string type) {
            GateComposite node = _nodes[type];
            return node.Clone();
        }
    }
}
