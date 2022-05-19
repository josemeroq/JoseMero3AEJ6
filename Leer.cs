using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ6
{

    public class Leer
    {
        private int num { set; get; }
        private int[] numv { set; get; }
        private int suma { get; set; }
        public Leer()
        {
            this.num = 51;
        }

        public void numerohasta()
        {
            /* do
             {

                 Console.WriteLine(--num);

             } while (num != 0); */

            if (num < 1)
            {
                do
                {

                    Console.WriteLine(++num);

                } while (num != 0);

                numv = new int[num];
                for (int i = 0; i <= num; i++)
                {

                    Console.WriteLine("Numeros " + numv[i]);
                    suma = suma + numv[i];
                }
                Console.WriteLine("Suma total: " + suma);
            }
            else
            {
                do
                {

                    Console.WriteLine(--num);

                } while (num != 0);
            }
            Console.ReadKey();
        }
    }
}
