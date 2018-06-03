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

        public void DrawGraphics() {
            int x = 0;
            int y = 0;

            Console.WriteLine(graphiclist.Count());
            foreach (GateGraphic gg in graphiclist) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition((gg.x)*15, (gg.y)*5);
                var myObjRef = gg.GetGate() as Gate;
                if (myObjRef != null)
                {
                    Console.Write(string.Format(gg.GetGate().getType() + ": " + myObjRef.Calculate() + " --- " , 0, 0, "s"));
                    
                    

                }
                else {
                    Console.Write(string.Format(gg.GetGate().getType(), 0, 0, "s"));

                }

                int tempy = Console.CursorTop;
                int calcY = tempy;
                foreach(Gate gc in gg.GetGate().connected_nodes)
                {
                    calcY++;
                    Console.SetCursorPosition((gg.x) * 15, calcY);
                    
                    Console.Write(string.Format(gc.getType() + ": " + gc.Calculate() + " --- ", 0, 0, "s"));
                }
                Console.SetCursorPosition((gg.x), tempy);


                Console.ResetColor();
                if (y < (gg.y) * 5) {
                    y = (gg.y) * 5;
                }

            }

            
            Console.SetCursorPosition(0, y+5);

        }
        public void CreateGraphic(Circuit c)
        {   
            Dictionary<String, GateComposite> dic = c.circuit;
            
            List<GateComposite> list = dic.Values.ToList();

       

            foreach (KeyValuePair<string, GateComposite> entry in dic)
            {
                GateGraphic gr = new GateGraphic(entry.Value);
                gr.Name = entry.Key;
                graphiclist.Add(gr);
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
