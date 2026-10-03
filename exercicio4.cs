using System.Globalization;

decimal valor = 0;
Console.Write("Digite um valor: ");
if(decimal.TryParse(Console.ReadLine(), out decimal v))
{
    valor = v;
}

string valoremReais = valor.ToString("C", new CultureInfo("pt-BR"));
Console.WriteLine($"O valor em reais é: {valoremReais}");

string valorFormatado = valor.ToString("C", new CultureInfo("En-US"));
Console.WriteLine($"O valor formatado é: {valorFormatado}");
