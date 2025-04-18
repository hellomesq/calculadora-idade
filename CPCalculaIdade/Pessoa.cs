using System;

namespace CPCalculaIdade
{
    struct Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - DataNascimento.Year;

            // Ajusta a idade se a pessoa ainda não fez aniversário este ano
            if (DataNascimento > hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }

        public bool MaiorDeIdade()
        {
            return CalcularIdade() >= 18;
        }

        public bool Habilitacao()
        {
            return CalcularIdade() >= 18;
        }

        public void ExibirDados()
        {
            int idade = CalcularIdade();

            Console.WriteLine("\n------ DADOS DA PESSOA ------");
            Console.WriteLine("Nome: " + Nome.ToUpper());
            Console.WriteLine("Data de Nascimento: " + DataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine("Idade: " + CalcularIdade() + " anos");

            // Para verificar se é maior de idade
            Console.WriteLine();

            if(MaiorDeIdade())
            {
                Console.WriteLine("É maior de idade.");
            }
            else
            {
                Console.WriteLine("É menor de idade.");
            }

            // Para verificar se pode tirar a carteira de motorista
            if(Habilitacao())
            {
                Console.WriteLine("Já pode tirar a CNH (Carteira de Habilitação).");
            }
            else
            {
                Console.WriteLine("Ainda NÃO pode tirar a CNH (Carteira de Habilitação).");
            }

            Console.WriteLine("------------------------------");
        }
    }
}
