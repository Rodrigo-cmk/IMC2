using System;

namespace IMC2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            string sair = "";

            BoasVindas();

            while (sair == "N" || sair != "S")
            {
                comanda("- Digite peso (kg): ");
                a = pesoAltura(Console.ReadLine());

                comanda("- Digite a altura (kg): ");
                b = pesoAltura(Console.ReadLine());

                Console.WriteLine($"IMC: {resul(a, b):N3} kg/m²", "/n");


                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Sair? ('S' para SIM, 'qualquer tecla' para não.): ");
                Console.ResetColor();
                sair = Console.ReadLine().ToUpper();
                comanda("--------------");

            }

            Console.WriteLine();
            Console.WriteLine("Obrigado!");
        }

        static void BoasVindas()
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine();

            Console.WriteLine($"Olá!!            {agora}");
            Console.WriteLine();

            Console.WriteLine("-- Calculadora IMC --");
            Console.WriteLine("Cálculo de Índice de Massa Corporal (IMC) do usuário.");
            Console.WriteLine();
        }

        static void comanda(string comanda)
        {
            Console.WriteLine();
            Console.Write(comanda, "/n");
        }

        static double pesoAltura(string pesoAltura)
        {
            double a;

            return a = Convert.ToDouble(pesoAltura);
        }

        static double resul(double a, double b)
        {
            Console.WriteLine();
            double c;

            c = a / (b * b);

            if (c < 17)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Muito abaixo do peso.");
                Console.ResetColor();
            }

            else if (c == 17 || c < 18.49)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Abaixo do peso.");
                Console.ResetColor();
            }

            else if (c == 18.05 || c < 24.29)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Peso normal.");
                Console.ResetColor();
            }

            else if (c == 25 || c < 29.99)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Acima do peso.");
                Console.ResetColor();
            }

            else if (c == 30 || c < 34.99)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Obesidade nível 1.");
                Console.ResetColor();
            }

            else if (c == 35 || c < 39.99)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Obesidade nível 2 (severa).");
                Console.ResetColor();
            }

            else if (c > 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Obesidade nível 3 (mórbida).");
                Console.ResetColor();
            }

            return c;
        }
    }
}
