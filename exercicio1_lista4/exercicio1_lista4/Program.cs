using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_lista4
{
    class Program
    {
        static void Main(string[] args)
        {
            //O intuito deste programa conssite em basicamente realizar o somatório entre 5 números inteiros digitados pelo usuário e retorna ovalor desse somatório em conjunto com o maior número entre todos os digitados.
            int num, i, soma = 0, maior = 0;//Nesta linha são declaradas as variáveis que serão utilizadar no programa, sendo elas, "maior","soma", "num" e "i" todas elas do tipo inteiro
            for (i = 0; i <= 5; i++)//Nesta linha é montada a estrutura de repetição FOR, para tal se utiliza a variável "i" como variável auxiliar para controlar a repetição. Na primeira parte do bloco da estrutura FOR definiu-se que "i=0" logo este é o valor inicial da estrutura de repetição. No bloco do meio define-se a condição de parada da estrutura de repetição, no caso esspecífico deste código, enquanto a condição "i<5" for verdadeira, todos os comandos presentes na estrutura de repetição serão executados. A estrutura só irá ser interrompida no momento em que esta condição for falsa, logo os comando ali presentes não serão mais executados e o programa irá seguir na linha logo após o fechamento de chave da estrutura FOR. Por fim, o último bloco da estrutura de repetição FOR consiste no incremento que a variável de controle "i" terá ao fim de cada repetição, caso o incremento será de uma unidade a cada repetição. Com todos esses elementos, a estrutura irá se repetir 5 vezes já que irá se iniciar no valor 0 e repetirá até o valor para "i=4" já que após esta repetição, o valor de i será de "i=5" e a condição de repetição irá ser falsa e a estrutura FOR será encerrada. 
            {
                Console.WriteLine("\n Entre um valor inteiro: ");//Comando de saída que pede ao usuário que digite um valor inteiro
                num = int.Parse(Console.ReadLine());//Comando de entrada que que lê o valor digitado pelo usuário, o converte de string para inteiro e por fim armazena na variável "num".
                soma = soma + num;//Processamento que soma o valor armazenado na variável "num" com o valor armazenado na variável "soma" e armazena essa soma na variável "soma". 
                if (num > maior)//Estrutura condicional que verifica se o valor de "num" digitado pelo usuário é maior que o valor armazenado na variável "maior". Caso essa condição seja verdadedeira, os comando presentes na estruturã condição serão executados. Caso seja falso, o programa não irá executar os comando dentro da estrutura condicional e continurá logo após o fechamento de chave.
                {
                    maior = num;//Processamento que armazena o valor presenta na variável "num" na variável "maior"
                }
            }
            Console.Write("\n O maior valor " + maior);//Comando de saída que imprime na tela o maior valor digitado durante a execução do programa.
            Console.Write("\n A soma dos numeros digitados e: " + soma);//Comando de saída que imprime na tela o valor do somatório de todos os números digitados durante a execução do programa.
            Console.ReadKey();//Comando que congela a tela do programa para que os seus resultados sejam vizualizados.
        }
    }
}
