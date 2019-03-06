using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercio2_livro
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, lucro, receita;
            int qtd = 94;

            Console.WriteLine("Legenda: PI - Preço do Ingresso, LE - Lucro Esperado, QIV - Quantidade de Ingressos Vendidos");
            Console.WriteLine("PI | LE | QIV");

            for(preco = 5; preco >= 1; preco -= 0.5)
            {
                qtd += 26;
                receita = preco * qtd;
                lucro = receita - 200;
                Console.Write("R$" + preco + " | R$" + lucro + " | " + qtd + "\n");
            }
            Console.ReadKey();
        }
    }
}
