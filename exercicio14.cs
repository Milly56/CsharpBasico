
    List<int> numeros = new List<int>();
    int numero;
    int maior = 0;
    int posicaoMaior = 0;

    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine("Digite um numero inteiro positivo: ");
        if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Número inválido. Digite um número inteiro positivo.");
            i--;
        }
        else
        {
            numeros.Add(numero);
        }
    }

    maior = numeros.Max();
    posicaoMaior = numeros.IndexOf(maior);

    Console.WriteLine($"O maior número digitado é: {maior}");
    Console.WriteLine($"A posição do maior número digitado é: {posicaoMaior}");