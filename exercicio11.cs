int soma = 0;
int numero;

do
{
  Console.WriteLine("Digite um número inteiro positivo: ");
 if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
 {
  Console.WriteLine("Número inválido. Digite um número inteiro positivo.");
 }
 else
 {
  soma += numero;
 }
} while (numero != 0);

Console.WriteLine($"A soma dos números digitados é: {soma}");

