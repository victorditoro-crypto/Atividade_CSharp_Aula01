using System;

class Program
{
    static void Main()
    {
        string identificacao;
        string nome;
        int idade;
        string cidade;
        string motivo;
        int codigo;
        bool concluido;

        Console.Write("IdentificaÃ§Ã£o: ");
        identificacao = Console.ReadLine();
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Cidade: ");
        cidade = Console.ReadLine();
        Console.Write("Motivo do atendimento: ");
        motivo = Console.ReadLine();
        Console.Write("CÃ³digo: ");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("ConcluÃ­do? (true/false): ");
        concluido = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("        REGISTRO DE ATENDIMENTO");
        Console.WriteLine("========================================");
        Console.WriteLine($"CÃ³digo: {codigo}");
        Console.WriteLine($"IdentificaÃ§Ã£o: {identificacao}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Motivo: {motivo}");
        Console.WriteLine($"ConcluÃ­do: {concluido}");
        Console.WriteLine("========================================");
    }
}
