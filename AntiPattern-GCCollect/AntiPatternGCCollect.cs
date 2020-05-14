using System;
using System.Collections.Generic;
using System.Threading;

namespace GCMyths
{
    static class AntiPatternGCCollect
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);

            for (int j = 0; j < 3; j++)
            {
                var data = new List<double[]>();

                for (int i = 0; i < 500; i++)
                {
                    var dbl = new double[900];
                    data.Add(dbl);

                    if (i % 100 == 0)
                    {
                        Console.WriteLine($"Array {i} created.");
                    }

                    Thread.Sleep(50);
                }
            }
        }
    }
}

//step1: call GC.Collect()
//GC.Collect();
//GC.WaitForPendingFinalizers();
//GC.Collect();
//step3: watch Gen1 and Gen2 collections
//step2: watch %time in GC