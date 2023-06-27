using System;

namespace Calculadora
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");

            int operacao;

            // Loop até que uma operação válida seja digitada
            while (true)
            {
                string operacaoInput = Console.ReadLine();

                // Tenta converter a entrada para um número inteiro
                if (int.TryParse(operacaoInput, out operacao))
                {
                    break; // Sai do loop se a conversão for bem-sucedida
                }

                Console.WriteLine("Entrada inválida para a operação. Certifique-se de digitar um número válido.");
            }

            Console.WriteLine("Digite o primeiro número: ");
            int num1;

            // Loop até que um primeiro número válido seja digitado
            while (true)
            {
                string num1Input = Console.ReadLine();

                // Tenta converter a entrada para um número inteiro
                if (int.TryParse(num1Input, out num1))
                {
                    break; // Sai do loop se a conversão for bem-sucedida
                }

                Console.WriteLine("Entrada inválida para o primeiro número. Certifique-se de digitar um número válido.");
            }

            Console.WriteLine("Digite o segundo número: ");
            int num2;

            // Loop até que um segundo número válido seja digitado
            while (true)
            {
                string num2Input = Console.ReadLine();

                // Tenta converter a entrada para um número inteiro
                if (int.TryParse(num2Input, out num2))
                {
                    break; // Sai do loop se a conversão for bem-sucedida
                }

                Console.WriteLine("Entrada inválida para o segundo número. Certifique-se de digitar um número válido.");
            }

            int resultado = 0;

            // Executa a operação selecionada com os números fornecidos
            switch (operacao)
            {
                case 1:
                    resultado = Adicao(num1, num2);
                    break;
                case 2:
                    resultado = Subtracao(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicacao(num1, num2);
                    break;
                case 4:
                    resultado = Divisao(num1, num2);
                    break;
                default:
                    Console.WriteLine("Número inválido, digite outro número.");
                    return;
            }

            Console.WriteLine("O resultado da operação é: {0}", resultado);
        }

        // Função para realizar a adição
        public static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        // Função para realizar a subtração
        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        // Função para realizar a multiplicação
        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        // Função para realizar a divisão
        public static int Divisao(int num1, int num2)
        {
            // Verifica se o divisor é zero para evitar uma exceção de divisão por zero
            if (num2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return 0;
            }

            int resultado = num1 / num2;
            return resultado;
        }
    }
}