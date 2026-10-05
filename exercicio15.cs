
List<double> numeros = new List<double>();
double media = 0;

for(int i = 0; i < 8; i++)
{
    Console.WriteLine("Digite um numero real: ");
    if (!double.TryParse(Console.ReadLine(), out double numero))
    {
        Console.WriteLine("Número inválido. Digite um número real.");
        i--;
    }
    else
    {
        numeros.Add(numero);
    }
}

media = numeros.Average();

Console.WriteLine($"A média dos números digitados é: {media:F2}");