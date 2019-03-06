using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_lista4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_imposto, multa, imposto, multa_total = 0, imposto_total = 0;
            int meses_atrasados, i;

            for(i =0; i < 10; i++)
            {

                do
                {
                    Console.WriteLine("\nDigite o valor do imposto a ser pago pelo proprietário " + (i + 1));
                    valor_imposto = double.Parse(Console.ReadLine());

                    if (valor_imposto <= 0)
                    {
                        Console.WriteLine("Valor inválido! Digite um valor válido para continuar");
                    }
                } while (valor_imposto <= 0);

                do
                {
                    Console.WriteLine("Digite a quantidade de meses atrasados pelo proprietário " + (i + 1));
                    meses_atrasados = int.Parse(Console.ReadLine());

                    if (meses_atrasados <= 0)
                    {
                        Console.WriteLine("Valor inválido! Digite um valor válido para continuar");
                    }
                } while (meses_atrasados <= 0);

                if(valor_imposto <= 50)
                {
                    multa = (valor_imposto * 0.01) * meses_atrasados;
                }
                else if(valor_imposto <= 180)
                {
                    multa = (valor_imposto * 0.02) * meses_atrasados;
                }
                else if(valor_imposto <= 500)
                {
                    multa = (valor_imposto * 0.04) * meses_atrasados;
                }
                else if(valor_imposto <= 1200)
                {
                    multa = (valor_imposto * 0.07) * meses_atrasados;
                }
                else
                {
                    multa = (valor_imposto * 0.1) * meses_atrasados;
                }

                imposto = valor_imposto + multa;
                multa_total += multa;
                imposto_total += imposto;

                Console.WriteLine("O proprietário " + (i + 1) + " deverá pagar R$" + multa + " de multa"); //Multa a ser paga individualmente
                Console.WriteLine("O proprietário " + (i + 1) + " deverá pagar R$" + imposto + " de multa");//Valor do imposto + multa a ser pago individualmente


            }

            Console.WriteLine("Valor total de multa a serem pagos ao município: R$" + multa_total);
            Console.WriteLine("Valor total de imposto a serem pagos ao município: R$" + imposto_total);
            Console.ReadKey();
        }
    }
}
