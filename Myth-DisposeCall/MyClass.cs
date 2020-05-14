using System;
using System.Diagnostics;

namespace GCMyths
{
    public class MyClass : IDisposable
    {
        private bool _disposed = false;

        public MyClass()
        {
        }

        public int DoSomething()
        {
            return 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.
            _disposed = true;
        }

        public void Dispose()
        {
            Console.WriteLine($"Explicit dispose of object type {this.GetType()}");

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~MyClass()
        {
            //Debugger.Launch();
            Console.WriteLine($"Implicit dispose of object type {this.GetType()}");

            Dispose(false);
        }
    }
}
