List<int> numeros = new List<int>();

for(int i = 0; i < 10; i ++)
{
    Console.WriteLine("Digite um número:");
    if (!int.TryParse(Console.ReadLine(), out int numero))
    {
         Console.WriteLine("Número inválido");
         i --;
    }
    else
    {
        numeros.Add(numero);
    }
    }

for(int i = numeros.Count() - 1; i>=0; i--)
{
    Console.WriteLine($"número inversos:{numeros[i]}");
}


