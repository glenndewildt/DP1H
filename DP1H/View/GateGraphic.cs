using DP1H.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.View
{
    class GateGraphic
    {
        GateComposite gate;
        public int x;
        public int y;

        public string Name { get; internal set; }

        public GateGraphic(GateComposite gate)
        {
            this.gate = gate;
            x = 0;
            y = 0;
        }

        public GateComposite GetGate()
        {
            return this.gate;
        }

    }
}
