using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8_livro
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, idade, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, soma2 = 0;
            double peso, altura, perc3, media2;
            char olhos, cabelos;

            for (i = 0; i < 6; i++)
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

                do
                {
                    Console.WriteLine("Digite a cor dos olhas da pessoa " + (i + 1) + ": (A - Azul, P - Preto, V - Verde, C - Castanho)");
                    olhos = char.Parse(Console.ReadLine().ToUpper());

                    if (olhos != 'A' && olhos != 'P' && olhos != 'V' && olhos != 'C')
                    {
                        Console.WriteLine("Opção Inválida! Digite uma opção válida para continuar.");
                    }
                } while (olhos != 'A' && olhos != 'P' && olhos != 'V' && olhos != 'C');

                do
                {
                    Console.WriteLine("Digite a cor dos cabelos da pessoa " + (i + 1) + ": (P - Preto, C - Castanho, L - Loiro, R - Ruivo)");
                    cabelos = char.Parse(Console.ReadLine().ToUpper());

                    if (cabelos != 'P' && cabelos != 'C' && cabelos != 'L' && cabelos != 'R')
                    {
                        Console.WriteLine("Opção Inválida! Digite uma opção válida para continuar.");
                    }
                } while (cabelos != 'P' && cabelos != 'C' && cabelos != 'L' && cabelos != 'R');


                if (idade > 50 && peso < 60)
                {
                    ++cont1;
                }

                if (altura < 1.5)
                {
                    soma2 += idade;
                    ++cont2;
                }

                if (olhos == 'A')
                {
                    ++cont3;
                }

                if (cabelos == 'R' && olhos != 'A')
                {
                    ++cont4;
                }


            }

            Console.WriteLine("Quantidade de Pessoas com mais de 50 anos e menos de 60 kg: " + cont1 + " pessoas");
            media2 = (double)soma2 / (double)cont2;
            Console.WriteLine("Media das idades das pessoas que possuem menos de 1,5 m: " + media2 + " anos");
            perc3 = ((double)cont3 / 6.0) * 100.0;
            Console.WriteLine("Percentual de pessoas de olhos azuis: " + perc3 + "%");
            Console.WriteLine("Quantidade de pessoas ruivas que não possuem olhos azuis: " + cont4 + " pessoas");

            Console.ReadKey();

        }
    }
}
