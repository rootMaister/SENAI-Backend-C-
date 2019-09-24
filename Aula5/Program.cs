using System;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string  [] nome       = new string  [5];
            string  [] origem     = new string  [5];
            string  [] destino    = new string  [5];
            DateTime[] data_ida   = new DateTime[5];
            DateTime[] data_volta = new DateTime[5];

            string sair = "";

            while(sair != "0"){
                
                Console.WriteLine("Bem vindo ao nosso sistema de Passagens!");
                Console.WriteLine(
                @"
                Menu: 
                1 - Cadastrar
                2 - Listar passagens
                0 - Sair");

                sair = Console.ReadLine();

                switch(sair){

                    case "1":
                        for(int batata = 0; batata <= 4; batata++){

                        Console.Write("Entre com o seu nome: ");
                        nome[batata] = Console.ReadLine();

                        Console.Write("Digite a UF do origem: ");
                        origem[batata] = Console.ReadLine();

                        Console.Write("Digite a UF de destino: ");
                        destino[batata] = Console.ReadLine();

                        Console.Write("Digite a data de IDA: ");
                        data_ida[batata] = DateTime.Parse(Console.ReadLine() );

                        Console.Write("Digite a data de VOLTA: ");
                        data_volta[batata] = DateTime.Parse(Console.ReadLine() );

                        Console.WriteLine("Obrigado por voar conosco! Boa viagem :) ");
                        
                        }
                    break;

                    case "2":
                        for(int batata = 0; batata <= 4; batata++){
                            if(nome[batata] != "" && origem[batata] != "" && destino[batata] != "" && data_ida[batata] !=null && data_volta[batata] !=null); 
                            Console.WriteLine("Passagem nº " + batata+1);

                            Console.WriteLine(nome[batata]);
                            Console.WriteLine(origem[batata]);
                            Console.WriteLine(destino[batata]);
                            Console.WriteLine(data_ida[batata]);
                            Console.WriteLine(data_volta[batata]);
                            Console.WriteLine(data_volta[batata]);
                        }
                    break;

                    case "0":
                        Console.WriteLine("Obrigado por utilizar nossa sistema ;) ");
                    break;

                    default:
                        Console.WriteLine("Entrada inválida! ");
                    break; 
                }  
            }
        }
    }
}