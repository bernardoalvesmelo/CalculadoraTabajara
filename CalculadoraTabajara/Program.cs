namespace CalculadoraTabajara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> historico = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculdora Tabajara");
                Console.WriteLine("Digite 1 para Adição");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para visualizar o histórico");
                Console.WriteLine("Digite S para sair");
                
                string operacao;
                string operador;
                string opcao = Console.ReadLine();
                if (opcao == "S" || opcao == "s")
                {
                    break;
                }
                switch (opcao)
                {
                    case "1": operacao = "Adição"; operador = "+"; break;
                    case "2": operacao = "Subtrair"; operador = "-"; break;
                    case "3": operacao = "Multiplicar"; operador = "*"; break;
                    case "4": operacao = "Dividir"; operador = "/"; break;
                    case "5": foreach(string op in historico)
                        {
                            Console.WriteLine(op);
                        }
                        Console.ReadLine();
                        continue;

                }
                
            }
          
        }
    }
}