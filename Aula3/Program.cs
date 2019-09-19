using System;

namespace Aula3 {
    class Program {
        static void Main (string[] args) {
            /* // LAÇO CONTADO - 'FOR' - INCREMENTO (+)
            for (int cont = 1; cont <= 100; cont++) {

                // Verificamos se o número é diferente de par
                if (cont % 2 != 0) {
                    Console.WriteLine ("FOR 100-0 - " + cont);
                }
            }

            //LAÇO CONTADO - 'FOR' - DECREMENTO (-)
            for (int cont = 100; cont >= 0; cont--) {

                //Verificamos se o número é diferente de 
                if (cont % 2 != 0) {
                    Console.WriteLine ("FOR 100-0 - " + cont);
                }
            } */

            // int cont;

            // for (cont = 100; cont >= 0; cont--) {

            //     //Verificamos se o número é diferente de 
            //     if (cont % 2 != 0){
            //         Console.WriteLine("FOR 100-0 - " + cont);
            //     }
            // }

            // LAÇO CONDICIONAL - WHILE

            double acumuladora =  0;
            double nota        =  0;
            int    cont        =  0;
            string sair        = "";

            while (sair != "sim"){

                Console.Write ("Digite a nota de um aluno:");
                nota = double.Parse (Console.ReadLine ());

                acumuladora += nota;
                cont++;

                Console.Write("Deseja sair da aplicação? sim/nao");
                sair = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Média das notas: " + (acumuladora / cont) );
        }
    }
}