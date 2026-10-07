using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string evento;
        string email;
        int inscricao;
        bool confirmado;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Cidade: ");
        cidade = Console.ReadLine();
        Console.Write("Evento: ");
        evento = Console.ReadLine();
        Console.Write("E-mail: ");
        email = Console.ReadLine();
        Console.Write("NÃºmero da inscriÃ§Ã£o: ");
        inscricao = int.Parse(Console.ReadLine());
        Console.Write("Confirmado? (true/false): ");
        confirmado = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("        PARTICIPANTE DO EVENTO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Evento: {evento}");
        Console.WriteLine($"E-mail: {email}");
        Console.WriteLine($"InscriÃ§Ã£o: {inscricao}");
        Console.WriteLine($"Confirmada: {confirmado}");
        Console.WriteLine("========================================");
    }
}
