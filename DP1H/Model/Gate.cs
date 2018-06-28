using DP1H.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{

    abstract public class Gate: GateComposite
    {
        public Gate self;
        public int timesReached = 0;
        public Gate()
        {
            connected_nodes = new List<GateComposite>();
            self = this;
        }
        public override string getType() { return type; }

        public override GateComposite Clone() {

            throw new NotImplementedException();
        }
        virtual public int Calculate() {
            throw new NotImplementedException();
        }
        public void Add(GateComposite n) {
            this.connected_nodes.Add(n);
        }
        public void Remove(GateComposite n) {
            this.connected_nodes.Remove(n);
        }

        public override List<GateComposite> GetConnectedNodes()
        {
            return this.connected_nodes;
        }

        public  override void toString()
        {
        }


        public override void Run()
        {
            //using an exception to check wether any error's occur.
            //If there's an input equal to -1, then it should stop running.
            try
            {
                    CheckInputs();
                    SetOutput();
                    SetValues(value);
                    PrintResult();


            }
            catch (ValuesNotSetException e)
            {
                
            }

        }

        public virtual void PrintResult() { }

        public virtual void SetValues(int value) {
            foreach (GateComposite node in connected_nodes)
            {
                if (node.input1 == -1)
                {
                    node.input1 = value;
                }
                else if (node.input2 == -1)
                {
                    node.input2 = value;
                }

                node.Run();
            }
        }

        public virtual void SetOutput() { self.value = self.Calculate(); }
        public virtual void CheckInputs() { }


        public void CheckConnected()
        {
            timesReached++;
            if(timesReached > 100)
            {
                throw new InfiniteLoopException();
            }
            foreach(Gate node in connected_nodes)
            {
                node.CheckConnected();
            }
        }


    }
}
