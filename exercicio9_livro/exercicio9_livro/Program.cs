using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9_livro
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, idade, cont2 =0, cont3 =0, cont_190 = 0 ;
            double peso, altura, perc3, soma1 =0, media1;

            for(i = 0; i<10; i++)
            {
                do
                {
                    Console.WriteLine("Digite a idade da pessoa " + (i + 1));
                    idade = int.Parse(Console.ReadLine());

                    if (idade < 0)
                    {
                        Console.WriteLine("Idade Inválida! Digite uma idade válida para continuar");
                    }
                } while (idade < 0);

                do
                {
                    Console.WriteLine("Digite o peso(em kg) da pessoa " + (i + 1));
                    peso = double.Parse(Console.ReadLine());

                    if (peso < 0)
                    {
                        Console.WriteLine("Peso Inválido! Digite um peso válido para continuar");
                    }
                } while (peso < 0);

                do
                {
                    Console.WriteLine("Digite a altura(em metros) da pessoa " + (i + 1));
                    altura = double.Parse(Console.ReadLine());

                    if (altura < 0)
                    {
                        Console.WriteLine("Altura Inválida! Digite uma altura válida para continuar");
                    }
                } while (altura < 0);

                soma1 += idade;

                if(peso > 90 && altura < 1.5)
                {
                    ++cont2;
                }

                if(altura > 1.9)
                {
                    if(idade >= 10 && idade <= 30)
                    {
                        ++cont3;
                    }
                    ++cont_190;
                }









            }

            media1 = (double)soma1 / 10.0;
            Console.WriteLine("Media das Idades: " + media1);
            Console.WriteLine("Quantidade de pessoas com peso superior a 90kg e altura inferior a 1,5 m:" + cont2);
            perc3 = ((double)cont3 / (double)cont_190) * 100.0;
            Console.WriteLine("Percentual de pessoal com idade entre 10 e 30 anos entre as pessoas que medem mais de 1,90m: " + perc3);

            Console.ReadKey();


        }
    }
}
