﻿namespace CalculadoraTabajara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> historico = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculdora Tabajara\n");
                Console.WriteLine("Digite 1 para Adição");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para Visualizar o histórico");
                Console.WriteLine("Digite S para Sair");

                string operacao = "";
                string operador = "";
                string opcao = Console.ReadLine();
                if (opcao == "S" || opcao == "s")
                {
                    break;
                }

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite uma opção válida!");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                switch (opcao)
                {
                    case "1": operacao = "Adição"; operador = "+"; break;
                    case "2": operacao = "Subtração"; operador = "-"; break;
                    case "3": operacao = "Multiplicação"; operador = "*"; break;
                    case "4": operacao = "Divisão"; operador = "/"; break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Visualizando histórico");
                        foreach (string op in historico)
                        {
                            Console.WriteLine(op);
                        }
                        Console.ReadLine();
                        continue;

                }
                Console.Clear();
                double numero1 = 0;
                while (true)
                {
                    Console.Write("Digite o primeiro número: ");
                    if (!Double.TryParse(Console.ReadLine(), out numero1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um número!");
                        Console.ReadLine();
                        Console.ResetColor();
                        continue;
                    }
                    break;
                }
                Console.WriteLine();
                double numero2 = 0;
                while (true)
                {
                    Console.Write("Digite o segundo número: ");
                    if (!Double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um número!");
                        Console.ReadLine();
                        Console.ResetColor();
                        continue;
                    }
                    break;
                }

                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = numero1 + numero2; break;
                    case "2": resultado = numero1 - numero2; break;
                    case "3": resultado = numero1 * numero2; break;
                    case "4":
                        if (numero2 > 0)
                            resultado = numero1 / numero2;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Não pode dividir por zero");
                            Console.ReadLine();
                            Console.ResetColor();
                        }
                        continue;

                }
                Console.Clear();
                string mensagemHistorico = $"{numero1} {operador} {numero2} = {resultado}";
                historico.Add(mensagemHistorico);
                string mensagem = $"O resultado da {operacao} é de {resultado}";
                Console.WriteLine(mensagem);
                Console.ReadLine();
            }
        }
    }
}