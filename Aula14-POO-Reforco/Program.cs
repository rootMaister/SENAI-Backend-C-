using System;
using Aula14_POO_Reforco.Controllers;

namespace Aula14_POO_Reforco
{
    class Program
    {
        static void Main(string[] args)
        {
            string personagem;

            Console.WriteLine("Digite: \n 1  Homem de Ferro \n 2-Capitão América: ");
            personagem = Console.ReadLine();

            HFController hfController = new HFController();
            CapController capController = new CapController();

            if(personagem == "1"){
                Console.ForegroundColor = hfController.MudaCor();

                System.Console.WriteLine( hfController.MostraInfo() );
                System.Console.WriteLine("Você está jogando com o Homem de Ferro");
                System.Console.WriteLine( hfController.Atirar() );
                System.Console.WriteLine( hfController.Pular() );
                System.Console.WriteLine( hfController.Voar() );
            }else if(personagem == "2"){
                Console.ForegroundColor = capController.MudaCor();
                System.Console.WriteLine( capController.MostraInfo() );
                System.Console.WriteLine( "Você está jogando com o Capitão América");
                System.Console.WriteLine( capController.LancarEscudo() );
                System.Console.WriteLine( capController.Pular() );
                System.Console.WriteLine( capController.DefenderComEscudo());
            }else{
                System.Console.WriteLine("Personagem inválido! :C");
            }

            Console.ResetColor();
            
        }
    }
}
