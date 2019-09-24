using System;

namespace MESA_6_CodeDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome_produto = new string[10];
            double[] preco        = new double[10];
            string menu = "";
            double soma = 0;

            while(menu != "0"){

                Console.WriteLine("Sistema CFV");
                Console.WriteLine(
                @"
                Menu: 
                1 - Cadastrar
                2 - Listar Produtos
                3 - Somar");

                menu = Console.ReadLine();


                switch(menu){

                    case "1":
                        for(int bat = 0; bat <= 2; bat++){

                            Console.Write("Escreva o nome do produto: ");
                            nome_produto[bat] = Console.ReadLine();

                            Console.Write("Escreva o preco do produto: ");
                            preco[bat] = double.Parse(Console.ReadLine()); 
                        }
                    break;

                    case "2":
                        for(int bat = 0; bat <=2; bat++){
                            Console.WriteLine(nome_produto[bat]);
                        }
                    break;

                    case "3":
                        for(int bat = 0; bat <=2; bat++){
                            soma = soma + preco[bat];
        
                        }

                        Console.WriteLine("A soma dos valores é igual á " + soma);
                    break;
                }
            }    
        }
    }
}
