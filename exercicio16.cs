List<int> numeros = new List<int>();
int contadorNumeros = 0;

for(int i =  0; i < 20; i ++)
{
    Console.WriteLine("Digite um número: ");
    if (!int.TryParse(Console.ReadLine(), out int numero))
    {
       Console.WriteLine("Número inválido");
       i--;
    } else
    {
        if(numero % 2 == 0 )
        {
            numeros.Add(numero);
        }
    }
}

  contadorNumeros = numeros.Count();

  Console.WriteLine($"Quantidade de números pares: {contadorNumeros}");
   