using System;

namespace ex_2 {
    class Program {
        static void Main (string[] args) {
            
            /* double tabuada = 0;

            Console.WriteLine ("Qual tabuada você quer ?");
            tabuada = double.Parse (Console.ReadLine ());
            for (int cont = 0; cont <= 10; cont++) {
                double multi = tabuada * cont;
                Console.WriteLine (multi);
            } */
            
            
           /*  int cont = 0;
            double multi;
            double tabuada;

            Console.Write("Qual tabuada você quer? ");
            tabuada = double.Parse (Console.ReadLine());
            while(cont <= 10){
                multi = tabuada*cont;
                Console.WriteLine(multi);
                cont++;
            } */

            int cont = 0;
            double multi;
            double tabuada;

            Console.Write("Qual tabuada você quer? ");
            tabuada = double.Parse(Console.ReadLine());
            do{
                multi = tabuada*cont;
                Console.WriteLine(multi);
                cont++;

            }while(cont<=10);

        }
    }
}