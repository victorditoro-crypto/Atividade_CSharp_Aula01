using System;

class Program
{
    static void Main()
    {
        string equipamento;
        string marca;
        string modelo;
        int ano;
        double valor;
        string patrimonio;
        bool funcionando;

        Console.Write("Equipamento: ");
        equipamento = Console.ReadLine();
        Console.Write("Marca: ");
        marca = Console.ReadLine();
        Console.Write("Modelo: ");
        modelo = Console.ReadLine();
        Console.Write("Ano de aquisiÃ§Ã£o: ");
        ano = int.Parse(Console.ReadLine());
        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());
        Console.Write("NÃºmero de patrimÃ´nio: ");
        patrimonio = Console.ReadLine();
        Console.Write("Funcionando? (true/false): ");
        funcionando = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("       ETIQUETA DE PATRIMÃ”NIO");
        Console.WriteLine("========================================");
        Console.WriteLine($"PatrimÃ´nio: {patrimonio}");
        Console.WriteLine($"Equipamento: {equipamento}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Valor: R$ {valor:F2}");
        Console.WriteLine($"Funcionando: {funcionando}");
        Console.WriteLine("========================================");
    }
}
