using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Somente declaramos, sem atribuir valor
            int num1;

            //Declaramos atribuindo um valor
            int num2 = 5;

            //Declaramos diversas variáveis de mesmo tipo
            int num3, num4, num5;

            //Variável do tipo decimal (real)
            float media;
            
            //Variável do tipo lógico (booleana)
            bool resultado = false;
            
            //Variavel do tipo texto(caracter)
            string nomeAluno;

            Console.WriteLine("Bem vindos à nossa primeira aplicação!");
            
            //Quebra a Linha
            Console.WriteLine("");

            //Escreve em uma linha quebrand-a
            Console.WriteLine("Digite seu nome");

            //Continua escrevendo na mesma linha
            Console.Write("Digite");
            Console.Write(" seu nome:");

            //Captura o dado digitado pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();

            //Concatenação
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota:" );

            //Converto o text capturado para o tipo inteiro
            num3 = int.Parse(Console.ReadLine());

            //Interporlação
            Console.WriteLine( $"Sua primeira nota {num3} ");
            
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine( $"Digite sua segunda nota{num4} ");
            
            num5 = int.Parse(Console.ReadLine());
            Console.WriteLine( $"Digite sua terceira nota{num5} ");
            

            media = (num3 + num4 + num5) / 3;

            Console.WriteLine("Sua média é: " + media);   
        }
    }
}
