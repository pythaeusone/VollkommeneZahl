using System;

namespace VollkommeneZahl
{
    class Program
    {
        static void Main(string[] args)
        {
            VollkommeneZahl vK = new VollkommeneZahl();

            vK.VZ(33550336);

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
