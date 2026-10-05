
Random random = new Random();
int sorteado = random.Next(1,101);
int numero = 0;

do{
Console.WriteLine("insira um número(0 até 100):");
 if (int.TryParse(Console.ReadLine(), out numero))
    {
     if(numero > sorteado)
    {
        Console.WriteLine("o número digitado foi maior que o sorteado");

    } if(sorteado > numero)
    {
        Console.WriteLine("o número sorteado é maior que o digitado");
    } if(numero == sorteado)
        {
            Console.WriteLine("os números são iguais");
        }
    }
} while(sorteado != numero);