using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_livro
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, faixa1 = 0, faixa2 = 0, faixa3 = 0, faixa4 = 0, faixa5 = 0,idade;
            double perc_faixa1, perc_faixa5;

            for(i=0; i < 8; i++)
            {
                do
                {
                    Console.WriteLine("Digite a idade:");
                    idade = int.Parse(Console.ReadLine());

                    if (idade < 0)
                    {
                        Console.WriteLine("Idade Inválida! Digite uma idade válida para continuar");
                    }
                } while (idade < 0);

                if (idade <= 15)
                {
                    ++faixa1;
                }
                else if (idade <= 30)
                {
                    ++faixa2;
                }
                else if (idade <= 45)
                {
                    ++faixa3;
                }
                else if (idade <= 60)
                {
                    ++faixa4;
                }
                else
                {
                    ++faixa5;
                }



            }

            perc_faixa1 = ((double)faixa1 / 8.0) * 100.0;
            perc_faixa5 = ((double)faixa5 / 8.0) * 100.0;

            Console.WriteLine("1ª Faixa: " + faixa1 + " pessoas");
            Console.WriteLine("2ª Faixa: " + faixa2 + " pessoas");
            Console.WriteLine("3ª Faixa: " + faixa3 + " pessoas");
            Console.WriteLine("4ª Faixa: " + faixa4 + " pessoas");
            Console.WriteLine("5ª Faixa: " + faixa5 + " pessoas");
            Console.WriteLine("Percentual de pessoas na primeira faixa etária: " + perc_faixa1 + "%");
            Console.WriteLine("Percentual de pessoas na última faixa etária: " + perc_faixa5 + "%");

            Console.ReadKey();

        }
    }
}
