using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_lista4
{
    class Program
    {
        static void Main(string[] args)
        {
            string municipio;
            int qtd_eleitores, i, voto, cont1 = 0, cont2=0, cont3 = 0, candidato;
            double perc1, perc2, perc3, maior;

            Console.WriteLine("Digite o nome do município:");
            municipio = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite a quantidade de eleitores aptos:");
                qtd_eleitores = int.Parse(Console.ReadLine());

                if(qtd_eleitores <= 0)
                {
                    Console.WriteLine("Valor Inválido! Digite um valor válido para continuar");
                }

            } while (qtd_eleitores <= 0);

            for (i = 0; i<qtd_eleitores; i++)
            {
                do
                {
                    Console.WriteLine("Digite o o número do candidato votado: \n 1 - Candidato 1\n2- Candidato 2\n3- Candidato 3\n"); //Como não foi informado pelo problema, considerei a existência de 3 candidatos na eleição
                    voto = int.Parse(Console.ReadLine());

                    switch (voto)
                    {
                        case 1:
                            ++cont1;
                            break;

                        case 2:
                            ++cont2;
                            break;

                        case 3:
                            ++cont3;
                            break;

                        default:
                            Console.WriteLine("Opção Inválida! Digite uma opção válida para continuar");
                            break;



                    }
                } while (voto != 1 && voto != 2 && voto != 3);


            }

            
                perc1 = ((double)cont1 / (double)qtd_eleitores) * 100.0;
                perc2 = ((double)cont2 / (double)qtd_eleitores) * 100.0;
                perc3 = ((double)cont3 / (double)qtd_eleitores) * 100.0;

                if(perc1 > perc2)
                {
                    if(perc1 > perc3)
                    {
                        maior = perc1;
                        candidato = 2;
                    }
                    else
                    {
                        maior = perc3;
                    candidato = 3;
                    }
                }
                else
                {
                    if(perc2 > perc3){
                        maior = perc2;
                        candidato = 2;
                    }
                    else{
                        maior = perc3;
                        candidato = 3;
                    }
                }

            Console.WriteLine("Cadidato 1: " + perc1 + "%");
            Console.WriteLine("Cadidato 2: " + perc2 + "%");
            Console.WriteLine("Cadidato 3: " + perc3 + "%");

            Console.WriteLine("Cadidato mais votado: Candidato " + candidato + " com " + maior +" dos votos");

            if(qtd_eleitores > 20000)
            {
                if (maior > 50)
                {
                    Console.WriteLine("Não haverá segundo turno");
                }
                else
                {
                    Console.WriteLine("Haverá segundo turno");
                }
            }
            else
            {
                Console.WriteLine("Haverá segundo turno");
            }







            Console.ReadKey();

        }
    }
}
