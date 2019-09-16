using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            int idade;

            Console.WriteLine("Quantos anos você tem ?");
            idade=int.Parse(Console.ReadLine());

            if(idade>=10 && idade<=13){
                Console.Write($"EVERYONE 10+");
            } else if(idade<=13 && idade<=17){
                Console.Write($"TEEN, EVERYONE 10+");
            } else if(idade<=17 && idade<=18){
                Console.Write($"MATURE, TEEN, 10+");
            } else{
                Console.Write("EARLY CHILDHOOD");
            }
        }
    }
}
