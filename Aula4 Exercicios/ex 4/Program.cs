using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor1 = new string[15];
            string[] vetor2 = new string[15];
            string[] vetor3 = new string[30];

            for(int i = 0; i <=14; i++){
                Console.Write("Digite os valores :");
                vetor1[i] = Console.ReadLine();
            }

            for(int i = 0; i <=14; i++){
                Console.Write("Digite os valores do 2º vetor: ");
                vetor2[i] = Console.ReadLine(); 
            }

            for(int i = 0; i <= 14; i++){
                vetor3[i] = vetor1[i];
            }

            for(int i = 15; i <= 29; i++){
                vetor3[i] = vetor2[i - 15];
            }

            for(int i = 0; i <= 29; i++){
                Console.WriteLine(vetor3[i]);
            }
        }
    }
}
