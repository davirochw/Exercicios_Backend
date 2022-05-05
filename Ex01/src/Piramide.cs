using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    internal class Piramide
    {
        public int n;

        public Piramide(int num)
        {
            n = num;
        }
        public void Desenha()
        {

            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (count = 1; count <= i; count++)
                {
                    Console.Write(count);
                }
                for (count = i - 1; count >= 1; count--)
                {
                    Console.Write(count);
                }
                Console.WriteLine();
            }
        }
    }
}
