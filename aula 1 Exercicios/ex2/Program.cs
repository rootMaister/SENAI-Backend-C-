using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {   
            float Preco;
            double Resultado;

            float Porcentagem;
            double ResultadoFinal;

            Console.Write("Valor do produto:");
            Preco = float.Parse(Console.ReadLine());

            Console.Write("Porcentagem: ");
            Porcentagem = float.Parse(Console.ReadLine());

            Resultado = (Porcentagem/100)*Preco+ Preco;

            Console.WriteLine("O valor total é  "+Resultado);
        }
    }
}
