using System;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, resultado, planeta;
            
            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Em qual planeta você quer ser pesado ? ");
            planeta = float.Parse(Console.ReadLine());

            switch(planeta){
                case 1:
                resultado = (peso/10)*0.37f;
                Console.WriteLine("Seu peso em Mercúrio seria " + resultado);
                break;

                case 2:
                resultado = (peso/10)*0.88f/1;
                Console.WriteLine("Seu peso em Vênus seria " + resultado);
                break;

                case 3:
                resultado = (peso/10)*0.38f/1;
                Console.WriteLine("Seu peso em Marte seria " + resultado);
                break;

                case 4:
                resultado = (peso/10)*2.64f/1;
                Console.WriteLine("Seu peso em Júpiter seria " + resultado);
                break;

                case 5:
                resultado = (peso/10)*1.15f/1;
                Console.WriteLine("Seu peso em Saturno seria " + resultado);
                break;

                case 6:
                resultado = (peso/10)*1.17f/1;
                Console.WriteLine("Seu peso em Urano seria " + resultado);
                break;

                default:
                Console.WriteLine("Nunca vi peso escrito assim....");
                break;
             
                
            }

            

        }
    }
}
