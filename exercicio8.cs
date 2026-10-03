
Console.Write("Digite o primeiro número: ");
if (!int.TryParse(Console.ReadLine(), out int num1))
{
    Console.WriteLine($"O número é {num1}");
}
  int tabuada = 1;
    while (tabuada <= 10)
    {
        int resultado = num1 * tabuada;
        Console.WriteLine($"{num1} x {tabuada} = {resultado}");
        tabuada++;
    }
