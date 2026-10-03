Console.Write("Digite um numero: ");
if (!int.TryParse(Console.ReadLine(), out int num1))
{} 
   String contadorCaractere = num1.ToString();
   contadorCaractere = contadorCaractere.Length.ToString();
   Console.WriteLine($"O número de caracteres é {contadorCaractere}");