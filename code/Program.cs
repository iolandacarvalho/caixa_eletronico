// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
return1:
Console.Write("Informe seu nome: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal nome))
{
    Console.Clear();
    Console.WriteLine("=".PadLeft(20, '='));
    Console.WriteLine($"Olá, {nome}! Seja bem-vindo ao CaliBank.");
    Console.WriteLine("=".PadLeft(20, '='));
    Console.WriteLine("\nClique no número correspondente à função que você deseja realizar: ");
    Console.WriteLine("\n1 - Informações da conta");
    Console.WriteLine("2 - Sacar ou depositar");
    Console.WriteLine("3 - Ver extrato");
    Console.WriteLine("4 - Transferência");
}
else
{
    Console.WriteLine("\n- Valor inválido, tente novamente -");
    Thread.Sleep(1700);
    Console.Clear();
    goto return1;
}
