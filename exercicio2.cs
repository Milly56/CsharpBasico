
Console.Write("Digite o primeiro número: ");
if (!int.TryParse(Console.ReadLine(), out int num1))
{
    Console.WriteLine($"O número é {num1}");
}
 Console.WriteLine($"O numero é:{num1}");

 int antecessor = num1 - 1;
    Console.WriteLine($"O antecessor do número é: {antecessor}");

 int sucessor = num1 + 1;
    Console.WriteLine($"O sucessor do número é: {sucessor}");
    