using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            if(n1>n2 && n1> n3){
                Console.WriteLine($"{n1} é maior que {n2} e {n3}");
            }else if(n3>n2){
                Console.WriteLine($"{n3} é maiors que {n1} e {n2}");
            } else{
                Console.WriteLine($"{n2} é maior que {n1} e {n3}");
            }


        }
    }
}
