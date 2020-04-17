using System;

namespace AulaC
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2, Resultado = 0;
            char Operacao;

            Console.WriteLine(" Entre com operação");
            Console.WriteLine(" + Adição...>");
            Console.WriteLine(" - Subtração");
            Console.WriteLine(" * Multiplicação");
            Console.WriteLine("/ Divisão -----> ");
            Console.WriteLine("------------------->");

            Console.WriteLine();

            Console.Write(" Operação:");

            char.TryParse(Console.ReadLine(), out Operacao);

            Console.WriteLine();
            Console.Write("Informe o primeiro valor:");
            double.TryParse(Console.ReadLine(), out Num1);

            Console.Write("Informe o segundo valor:");
            double.TryParse(Console.ReadLine(), out Num2);
            lakoakaokfosfkoafaof
            Console.WriteLine();
            Console.WriteLine();

            switch (Operacao)
            {
                case '+':
                    Resultado = Adicao(Num1, Num2);
                    break;
                case '-':
                    Resultado = Subtracao(Num1, Num2);
                    break;
                case '*':
                    Resultado = Multiplicacao(Num1, Num2);
                    break;
                case '/':
                    Resultado = Divisao(Num1, Num2);
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Resultado: {0}", Resultado));

            Console.ReadKey();

        }

        // Metodos 
        private static Double Adicao(double Num1, double Num2)
        {
            return (Num1 + Num2);
        }


        }
    }
}

