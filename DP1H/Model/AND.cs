﻿using DP1H.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1H.Model
{
    public class AND : Gate
    {
        int runCounter = 0;
        public override void toString()
        {
            Console.WriteLine("AND");
        }
        public AND() {
            this.type = "AND";
        }
        public override GateComposite Clone()
        {

            return new AND() { connected_nodes = this.connected_nodes, input1 = this.input1, input2 = this.input2 };
        }
        public override void Run()
        {
            TemplateRun();
        }
        public override int Calculate()
        {
            int result = -1;
            if (input1 == 1 && input2 == 1)
            {
                result = 1;

            }
            else
            {
                result = 0;
            }

            return result;

        }

        public override void PrintResult()
        {
        }

        public override void SetValues(int value)
        {
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

        public override void SetOutput()
        {
            value = self.Calculate();
        }
        public override void CheckInputs()
        {
            if (input1 == -1 || input2 == -1)
            {
                throw new ValuesNotSetException();
            }
            return;
        }

        public override void RunInitial()
        {
           
        }

    }

}
