using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    class Gate: Node
    {
        public Gate()
        {
            connected_nodes = new List<Node>();
        }

        public override Node Clone() {

            throw new NotImplementedException();
        }
        virtual public int Calculate() {
            throw new NotImplementedException();
        }
        public void Add(Node n) {
            this.connected_nodes.Add(n);
        }
        public void Remove(Node n) {
            this.connected_nodes.Remove(n);
        }

        public override List<Node> GetConnectedNodes()
        {
            return this.connected_nodes;
        }

        public  override void toString()
        {
        }

        public override void Run()
        {
            
                throw new NotImplementedException();
        }
    }
}
