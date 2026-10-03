
List<int> numerosInteiros = new List<int>();



Console.WriteLine("Digite 10 números inteiros:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Número {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        numerosInteiros.Add(numero);
    }
}

for (int i = 0; i < numerosInteiros.Count; i++)
{
  Console.WriteLine(numerosInteiros[i]);
  if(numerosInteiros[i] == 0)
  {
    Console.WriteLine("Encerado o programa, pois o número digitado é 0.");
    break;
  }
 
  if(numerosInteiros.Count > 0)
  {
    int soma = numerosInteiros.Sum();
    Console.WriteLine($"A soma de todos os nuneros digitados é {soma}");
  }

}

