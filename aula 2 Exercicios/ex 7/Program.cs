using System;

namespace ex_7
{
    class Program
    {
        static void Main(string[] args)
        {   

            string pedido, nump;

            Console.WriteLine("Digite seu pedido: ");
            nump = Console.ReadLine();

            switch(nump){
                
                case "1":
                pedido = "Seu pedido é um Hamburguer.";
                break;

                case  "2":
                pedido = "Seu pedido é um X - Salada.";
                break;

                case  "3":
                pedido = "Seu pedido é um X - burguer.";
                break;

                case  "4":
                pedido = "Seu pedido é um X - Bacon.";
                break;

                default:
                pedido = "Número inválido, digite apenas NÚMEROS";
                break;                
            }

            Console.WriteLine(pedido);
        }
    }
}
