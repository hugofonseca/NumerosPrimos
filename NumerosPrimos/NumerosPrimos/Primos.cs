using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Primos
    {
        public static void primos(int range)
        {
            List<int> numeros = new List<int>();
            List<int> primos = new List<int>();
            for(int i = 2; i <= range; i++)
            {
                numeros.Add(i);
                primos.Add(i);
            }

            foreach (int i in numeros)
            {
                foreach (int j in numeros)
                {
                    if(j % i == 0 && i != j)
                    {
                        primos.Remove(j);
                    }
                }
            }
            foreach (int j in primos)
            {
                Console.WriteLine(j);
            }
        }
    }
}
