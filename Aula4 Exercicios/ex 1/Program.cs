using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userN = new int[10];
            int[] exibN = new int[10];

            for(int i = 0; i <= 9; i++){
                Console.Write("Atribua os valores: ");
                userN[i]= int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <=9; i++){
                Console.WriteLine(userN[i]);
            }

            Console.WriteLine(userN[9]*5);
        }
    }
}
