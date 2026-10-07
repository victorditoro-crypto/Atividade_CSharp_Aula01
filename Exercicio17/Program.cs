using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string cargo;
        double salario;
        int matricula;
        string departamento;
        bool ativo;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Cidade: ");
        cidade = Console.ReadLine();
        Console.Write("Cargo: ");
        cargo = Console.ReadLine();
        Console.Write("SalÃ¡rio: ");
        salario = double.Parse(Console.ReadLine());
        Console.Write("MatrÃ­cula: ");
        matricula = int.Parse(Console.ReadLine());
        Console.Write("Departamento: ");
        departamento = Console.ReadLine();
        Console.Write("Ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("       CADASTRO DE FUNCIONÃRIO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"SalÃ¡rio: R$ {salario:F2}");
        Console.WriteLine($"MatrÃ­cula: {matricula}");
        Console.WriteLine($"Departamento: {departamento}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("========================================");
    }
}
