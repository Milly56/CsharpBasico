
List<int> numerosPares = new List<int>();

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        numerosPares.Add(i);
    }
}
Console.WriteLine("Números pares de 1 a 100:");
Console.WriteLine(string.Join(", ", numerosPares));

if (numerosPares.Count > 0)
{
    int soma = numerosPares.Sum();
    Console.WriteLine($"A soma dos números pares é: {soma}");
}