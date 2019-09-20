using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[20];
            
            for(int i = 0; i <=9; i++){
                Console.Write("Atibua os valores: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <=9; i++){
                Console.Write("Atribua os segundos valores: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <=9; i++){
                vetor3[i] = vetor1[i];
            }

            for(int i = 10; i <=19; i++){
                vetor3[i] = vetor2[i - 10];
   
            }

            for(int i = 0; i <=19; i++){
                Console.WriteLine(vetor3[i]);
            }
            
        }
    }
}
