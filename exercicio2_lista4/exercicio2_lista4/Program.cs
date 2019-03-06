using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_lista4
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo, experiencia;
            int idade, masc = 0, fem = 0, soma_idade = 0, soma_idade_exp_fem = 0, homens_35_45 = 0, menor_idade = 0, i = 0, masc_exp = 0, fem_exp=0;
            double perc_h_intervalo, perc_exp, media_fem_exp;

            for(i=0; i<30; i++)
            {
                do
                {
                    Console.WriteLine("Digite o sexo do candidato:(M - Masculino F - Feminino)");
                    sexo = char.Parse(Console.ReadLine().ToUpper());

                    if (sexo != 'M' && sexo != 'F')
                    {
                        Console.WriteLine("Opção Inválida! Digite uma opção válida para continuar.");
                    }
                } while (sexo != 'M' && sexo != 'F');

                do
                {
                    Console.WriteLine("Digite a idade do candidato:");
                    idade = int.Parse(Console.ReadLine());

                    if (idade <= 0)
                    {
                        Console.WriteLine("Idade inválida! Digite uma idade válida para continuar");
                    }

                } while (idade <= 0);

                do
                {
                    Console.WriteLine("O candidato possui experiência no serviço?(S - Sim N - Não)");
                    experiencia = char.Parse(Console.ReadLine().ToUpper());

                    if (experiencia != 'S' && experiencia != 'N')
                    {
                        Console.WriteLine("Opção Inválida! Digite uma opção válida para continuar.");
                    }
                } while (experiencia != 'S' && experiencia != 'N');

                if(sexo == 'M')
                {
                    ++masc;
                    soma_idade += idade;

                    if(idade >= 35 && idade<=45)
                    {
                        ++homens_35_45;
                    }

                    if (experiencia == 'S')
                    {
                        ++masc_exp;
                    }
                }
                else
                {
                    ++fem;
                    if(experiencia == 'S')
                    {
                        soma_idade_exp_fem += idade;
                        ++fem_exp;
                    }

                    if(i == 0)
                    {
                        menor_idade = idade;
                    }
                    else
                    {
                        if (idade < menor_idade)
                        {
                            menor_idade = idade;
                        }
                    }
                }

            }

            Console.WriteLine("Quantidade de candidatos do sexo masculino: " + masc + " candidatos");
            Console.WriteLine("Quantidade de candidatos do sexo feminino: " + fem + " candidatos");
            Console.WriteLine("Idade média dos homens: " + ((double)soma_idade / (double)masc) + " anos");
            media_fem_exp = (double)soma_idade_exp_fem / (double)fem_exp;
            Console.WriteLine("Idade média das mulheres com experiência: " + media_fem_exp + " anos");
            perc_h_intervalo = ((double)homens_35_45 / (double)masc) * 100.0;
            Console.WriteLine("Porcentagem de homens entre 35 e 45 anos entre o total de homens: " + perc_h_intervalo + "%");
            perc_exp = ((double)(masc_exp + fem_exp) / 30.0) * 100.0;
            Console.WriteLine("Porcentagem total (homens e mulheres) com experiência no serviço: " + perc_exp + "%");

            Console.ReadLine();

        }
    }
}
