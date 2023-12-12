using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_022_Test2_Task2
{
    public class MyEventArgs:EventArgs
    {
        public string argument { get; set; }

        public MyEventArgs(string arg)
        {
            argument = arg;
        }

    }
}
