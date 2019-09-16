using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double despesa;
            double calc;

            Console.Write("Digite quanto recebeu esse mês: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Quanto vai gastar esse mês? ");
            despesa = double.Parse(Console.ReadLine());

            calc = salario - despesa;

            if(calc<0){
                Console.Write($"Seu saldo esse mês foi negativo {calc}");
            } else{
                Console.Write($"Seu saldo esse mês foi positivo {calc}");
            }            
        }
    }
}
