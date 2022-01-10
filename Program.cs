using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string control;
            bool looping = false;

            do
            {
                Console.WriteLine("Calculadora Aritmética");
                Console.WriteLine("Para calcular, aperte c, para sair aperte s ");
                control = Console.ReadLine().ToLower();

                switch (control)
                {
                    case "c":
                        Menu();
                        break;
                    case "s":
                        looping = true;
                        Console.WriteLine("Encerrando o programa ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente \n");
                        break;
                }
            } while (looping != true);
        }

        static void Menu()
        {
            string operation;
            double value1;
            double value2;
            double result;

            Console.WriteLine("Primeiro valor: ");
            value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Operação: ");
            Console.WriteLine("Soma: + , Subtracao: - , Multiplicacao: * , Divisao: / ");
            operation = Console.ReadLine();

            Console.WriteLine("Segundo valor: ");
            value2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            result = Operation(value1, value2, operation);
            Console.WriteLine("Resultado: " + result + "\n");
        }

        static double Operation(double value1, double value2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return (value1 + value2);
                case "-":
                    return (value1 - value2);
                case "*":
                    return (value1 * value2);
                case "/":
                    return (value1 / value2);
                default:
                    Console.WriteLine("Erro, reinicie o programa e tente novamente");
                    return (-1);
            }
        }
    }
}