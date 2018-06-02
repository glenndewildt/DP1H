using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP1H.Model;

namespace DP1H.View
{
    class ViewController
    {

        List<GateGraphic> graphiclist = new List<GateGraphic>();
        public void CreateGraphic(Circuit c)
        {
            List<GateComposite> list = c.GetConnectedNodes();

            foreach(GateComposite g in list)
            {
                graphiclist.Add(new GateGraphic(g));
            }


            Dictionary<int,int> xy = new Dictionary<int, int>();

            int hix = -1;
            foreach(GateGraphic gg in graphiclist)
            {
                foreach (GateComposite ggn in gg.GetGate().GetConnectedNodes())
                {
                    foreach(GateGraphic connected_graphic in graphiclist.Where(s => s.GetGate() == ggn))
                    {
                       
                        connected_graphic.x = gg.x + 1;
                        if (connected_graphic.x > hix)
                        {
                            hix = connected_graphic.x;
                        }
                    }
                }
            }

            for(int i = 0; i < hix; i++)
            {
                List<GateGraphic> ggs = graphiclist.Where(s => s.x == i).ToList();
                for(int j = 0; j < ggs.Count(); j++)
                {
                    graphiclist.First(s => s == ggs.ElementAt(j)).y = j;
                }
            }
        }
    }
}
