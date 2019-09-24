using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[4];
            produtos[0] = "Nome";
            produtos[1] = "Cor";
            produtos[2] = "Tamanho";
            produtos[3]   = "Preço";
        
            for(int i = 0; i<=1; i++){
                Console.Write("Digite o nome do produto: ");
                produtos[0] = Console.ReadLine();

                Console.Write("Qual a cor do produto ? ");
                produtos[1] = Console.ReadLine();

                Console.Write("Qual o tamanho do produto ? ");
                produtos[2] = Console.ReadLine();

                Console.Write("Digite o preço do produto: ");
                produtos[3] = Console.ReadLine();

                Console.Write(produtos[i]);
            }
        }
    }
}
