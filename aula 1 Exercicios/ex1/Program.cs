using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numUser;
            int Resultado;

            Console.WriteLine("Digite o numero:");
            numUser = int.Parse(Console.ReadLine());

            Resultado =  numUser*3;

            Console.WriteLine(numUser+" vezes três é igual à "+Resultado);
        }
    }
}
