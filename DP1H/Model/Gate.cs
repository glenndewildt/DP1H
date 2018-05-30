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
        public Gate()
        {
            connected_nodes = new List<GateComposite>();
            self = this;
        }

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
            
                throw new NotImplementedException();
        }

        public void TemplateRun()
        {
            //using an exception to check wether any error's occur.
            //If there's an input equal to -1, then it should stop running.
            try
            {
                    CheckInputs();
                    SetOutput();
                    SetValues(value);
                    RunInitial();
                    PrintResult();
            }
             catch(ValuesNotSetException e)
            {
                
            }

        }

        public abstract void PrintResult();

        public abstract void SetValues(int value);

        public abstract void SetOutput();
        public abstract void CheckInputs();

        public abstract void RunInitial();




    }
}
