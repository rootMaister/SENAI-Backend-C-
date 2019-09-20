using System;

namespace ex_1_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum = 0;
            int cont = 1;
            int numero;

            do{ 
                Console.Write("Vai digitando uns numero ai pls <3: ");
                numero = int.Parse(Console.ReadLine());
                
                if(numero % 3 == 0){
                    acum +=  numero;
                }

                cont++;
            }while(cont <=20);
        }
    }
}
