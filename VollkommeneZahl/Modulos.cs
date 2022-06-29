using System;
using System.Collections.Generic;
using System.Text;

namespace VollkommeneZahl
{
    class Modulos
    {

        public int Modu(int num)
        {
            int sum = 0;
            int ergebnis;

            for(int i = 1; i < num - 1; i++)
            {
                ergebnis = num % i;

                if (ergebnis == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

    }
}
