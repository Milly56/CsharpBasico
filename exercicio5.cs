Console.Write("Digite o primeiro número: ");
if (!int.TryParse(Console.ReadLine(), out int num1))
{
    Console.WriteLine($"O número é {num1}");
}
Console.Write("Digite o segundo número: ");
if (!int.TryParse(Console.ReadLine(), out int num2))
{
    Console.WriteLine($"O número é {num2}");
}

int soma = num1 + num2;
Console.WriteLine($"A soma dos números é: {soma}");

int subtracao = num1 - num2;
Console.WriteLine($"A subtração dos números é: {subtracao}");

int multiplicacao = num1 * num2;
Console.WriteLine($"A multiplicação dos números é: {multiplicacao}");

double divisao = (double)num1 / num2;
Console.WriteLine($"A divisão dos números é: {divisao}");

