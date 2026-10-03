
   int numero1 = 0;
   int numero2 = 0;

Console.Write("Digite um número: ");
if(int.TryParse(Console.ReadLine(), out int n1))
{
  numero1 = n1;
}

Console.Write("Digite um número: ");
if(int.TryParse(Console.ReadLine(), out int n2))
{
  numero2 = n2;
}

   int resultado = numero1 + numero2;
   Console.WriteLine($"soma é: {resultado}");
