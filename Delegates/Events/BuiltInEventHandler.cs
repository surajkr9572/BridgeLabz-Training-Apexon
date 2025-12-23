using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Events
{
    public class BuiltInEventHandler
    {
        public event EventHandler TaskCompleted;
        public void Runtask()
        {
            Console.WriteLine("Task Runing..");
            OnTaskCompleted();
        }
        public virtual void OnTaskCompleted()
        {
            TaskCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
