using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual número vocÊ quer saber os multiplos? ");
            numero = double.Parse(Console.ReadLine());

            for(int cont = 1; cont <= numero; cont++){
                if(cont % 5 == 0){
                    Console.WriteLine(cont);
                }
            }
        }
    }
}
