using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_022_Test2_Task2
{
    public class Subscriber
    {
        public void SubscriberOnEvent(object? sender, MyEventArgs? args)
        {
          Console.WriteLine("Event fired");
          Console.WriteLine($"It got {args.argument ?? "" }");

        }
    }
}
