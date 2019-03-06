using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercio3_lista4
{
    class Program
    {
        static void Main(string[] args)
        {
            int termo, ant = 1, prox = 1, prox2, i =0;

            Console.WriteLine("Digite o termo até que termo da sequência de Fibonacci deseja-se vizualizar:");
            termo = int.Parse(Console.ReadLine());

            for (i=0; i < termo; i++)
            {
                if(i == 0)
                {
                    Console.Write(ant);
                }
                else if(i == 1)
                {
                    Console.Write("," + prox);
                }
                else
                {
                    prox2 = ant + prox;
                    ant = prox;
                    prox = prox2;
                    Console.Write("," + prox2);
                }

                
            }
            Console.ReadKey();
        }
    }
}
