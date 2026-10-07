using System;

class Program
{
    static void Main()
    {
        string titulo;
        string autor;
        int ano;
        int codigo;
        double preco;
        string categoria;
        bool disponivel;

        Console.Write("TÃ­tulo: ");
        titulo = Console.ReadLine();
        Console.Write("Autor: ");
        autor = Console.ReadLine();
        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());
        Console.Write("CÃ³digo: ");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("PreÃ§o: ");
        preco = double.Parse(Console.ReadLine());
        Console.Write("Categoria: ");
        categoria = Console.ReadLine();
        Console.Write("DisponÃ­vel? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("           LIVRO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"TÃ­tulo: {titulo}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"CÃ³digo: {codigo}");
        Console.WriteLine($"PreÃ§o: R$ {preco:F2}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"DisponÃ­vel: {disponivel}");
        Console.WriteLine("========================================");
    }
}
