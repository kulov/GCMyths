using System;
using System.Threading;

namespace GCMyths
{
    static class AntiPatternNullSetting
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);

            for (int i = 0; i < 10_000; i++)
            {
                var dbl = new double[900];
                dbl = null;
                
                if (i % 100 == 0)
                {
                    Console.WriteLine($"Array {i} created.");
                }

                Thread.Sleep(10);
            }
        }
    }
}

// step1: observe Gen1 heap size increase even with no rooted objects
// step2: compile in Release to observe eager root collection
