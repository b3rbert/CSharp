using System;
using System.Globalization;
using System.Xml;

namespace primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você usará 1 ou 2 números?");
            int num = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            if (num == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Entre com o primeiro valor");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entre com o segundo valor");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite 1 para soma, 2 para subtração, 3 para divisão, 4 para multiplicação, 5 para potênciação");
               int operacao = Convert.ToInt32(Console.ReadLine());



                if (operacao == 1)
                {
                    total = n1 + n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"A soma dos valores é {total}");
                }

                else if (operacao == 2)
                {
                    total = n1 - n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"A subtração dos valores é {total}");
                }

                else if (operacao == 3)
                {
                    total = n1 / n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"A divisão dos valores é {total}");
                }

                else if (operacao == 4)
                {
                    total = n1 * n2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"A multiplicação dos valores é de {total}");
                }



                else if (operacao == 5)
                {

                    double total2 = Math.Pow(n1, n2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"A elevação de {n1} por {n2} é {total2}");
                }
            }


            if (num == 1)
            {
                Console.WriteLine("Você escolheu radiciação");
                Console.WriteLine("Entre com o valor");
                int n1 = Convert.ToInt32(Console.ReadLine());
                double total3 = Math.Sqrt(n1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"A raiz quadrada do número é {total3}");
            }

        }

    }
}