using System;

namespace Exercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 20     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int numero1;
            int numero2;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números digitados são iguais.");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine($"Conforme os números digitados, segue sequência: {numero2}, {numero1}.");
            }
            else
            {
                Console.WriteLine($"Conforme os números digitados, segue sequência: {numero1}, {numero2}. ");
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
