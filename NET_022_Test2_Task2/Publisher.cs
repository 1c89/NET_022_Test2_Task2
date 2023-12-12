using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_022_Test2_Task2
{
    public class Publisher
    {

        public event EventHandler<MyEventArgs>? someEvent;

        private string _evArgsDescr;
        public Publisher(string arg)
        {
            _evArgsDescr = arg;
            
        }

        public void DoSmth()
        {
            MyEventArgs evArgs = new MyEventArgs(_evArgsDescr);
            
            RaiseEvent(evArgs);
        }


        protected virtual void RaiseEvent(MyEventArgs args)
        {
            someEvent?.Invoke(this, args);
        }
    }
}
