using System;

class Program
{
    static void Main()
    {
        string cliente;
        string equipamento;
        int codigo;
        int dias;
        double valor;
        bool disponivel;

        Console.Write("Cliente: ");
        cliente = Console.ReadLine();
        Console.Write("Equipamento: ");
        equipamento = Console.ReadLine();
        Console.Write("CÃ³digo: ");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de dias: ");
        dias = int.Parse(Console.ReadLine());
        Console.Write("Valor da locaÃ§Ã£o: ");
        valor = double.Parse(Console.ReadLine());
        Console.Write("Equipamento disponÃ­vel? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          REGISTRO DE LOCAÃ‡ÃƒO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Cliente: {cliente}");
        Console.WriteLine($"Equipamento: {equipamento}");
        Console.WriteLine($"CÃ³digo: {codigo}");
        Console.WriteLine($"Dias: {dias}");
        Console.WriteLine($"Valor: R$ {valor:F2}");
        Console.WriteLine($"DisponÃ­vel: {disponivel}");
        Console.WriteLine("========================================");
    }
}
