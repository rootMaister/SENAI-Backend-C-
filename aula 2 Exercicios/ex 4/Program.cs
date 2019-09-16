using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;
            double desco;

            Console.WriteLine("Digite o total a ser pago: ");
            preco = double.Parse(Console.ReadLine());

            if(preco>=100 && preco<=1000){
                desco = preco - (preco/100);
                Console.Write($"Seu desconto foi aplicado e o seu valor a pagar é: {desco}");
            }
        }
    }
}
