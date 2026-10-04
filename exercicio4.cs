decimal reais = 0;
Console.Write("Digite um reais: ");
if(decimal.TryParse(Console.ReadLine(), out decimal r))
{
    reais = r;
}
decimal cotacao = 0;
Console.Write("Digite a cotação em euro:");
if(decimal.TryParse(Console.ReadLine(),out decimal c))
{
    cotacao = c;
}
     decimal dolar = r/c;

     Console.WriteLine($"Esse valor representa {dolar:F2} em euros");