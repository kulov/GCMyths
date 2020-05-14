using System;

namespace GCMyths
{
    static class MythDisposeCall
    {
        static void Main(string[] args)
        {
            CreateMyClass();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Console.ReadLine();
        }

        private static void CreateMyClass()
        {
            var myClass = new MyClass();
            myClass.DoSomething();

            myClass.Dispose();
        }
    }
}
