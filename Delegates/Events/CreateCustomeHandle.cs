using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Events
{
    public class CreateCustomeHandle
    {
        public delegate void Notify(); 
        public event Notify ProcessCompleted;
        public void Start()
        {
            Console.WriteLine("Process Started...");
            OnProcessCompleted();

        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
