using System;

namespace CPCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora de Idade ---");

            Pessoa p = new Pessoa();

            // Pega o nome da pessoa
            Console.Write("Informe seu nome completo: ");
            p.Nome = Console.ReadLine();

            // Valida a data de nascimento
            DateTime dataNasc = DateTime.MinValue; 
            bool dataValida = false;

            while (!dataValida)
            {
                Console.Write("Digite sua data de nascimento (formato: dd/mm/aaaa): ");
                string inputData = Console.ReadLine();

                if (DateTime.TryParse(inputData, out dataNasc))
                {
                    // Verifica se o ano digitado não é maior que o ano atual
                    if (dataNasc.Year > DateTime.Now.Year)
                    {
                        Console.WriteLine("O ano de nascimento não pode ser superior ao ano atual. Tente novamente.");
                    }
                    else
                    {
                        // Verifica se a data de nascimento existe
                        if (dataNasc > DateTime.Now)
                        {
                            Console.WriteLine("A data de nascimento não pode ser no futuro. Tente novamente.");
                        }
                        else
                        {
                            dataValida = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Data inválida! Por favor, digite novamente no formato dd/mm/aaaa.");
                }
            }

            p.DataNascimento = dataNasc;

            p.ExibirDados();

            Console.WriteLine("\nObrigado por usar a calculadora de idade!");
            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
