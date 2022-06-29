using System;
using System.Diagnostics;

namespace VollkommeneZahl
{
    class VollkommeneZahl
    {
        public void VZ(int i)
        {
            Modulos mod = new Modulos();
            Stopwatch sw = new Stopwatch();

            int count = 0;

            for(int j = 1; j <= i; j++)
            {
                sw.Start();
                if (j == mod.Modu(j))
                {
                    sw.Stop();
                    TimeSpan ts = sw.Elapsed;
                    count++;
                    Console.WriteLine(" " + count + ". " + j);
                    Console.WriteLine("   Brauchte: " + ts.TotalMilliseconds + " ms\n");
                }
                sw.Stop();
            }
            
        }

    }
}
