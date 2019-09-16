using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;
            double precot;

            Console.Write("Quanto custa esse produto ? ");
            preco = double.Parse(Console.ReadLine());

            if(preco<100){
                precot = preco - 25;
                Console.WriteLine($"O total a ser pago é: {precot}");
            } else{
                Console.WriteLine($"O total a ser pago é: {preco}");
            }
        }
    }
}
