List<int> notas =  new List<int>{100,50,20,10,5,2};
int numero = 0;

Console.WriteLine("Qual vai ser o valor do seu saque:");
 if (int.TryParse(Console.ReadLine(), out numero))
{
    int restante = numero;

    for(int i = 0; i < notas.Count; i++)
    {
        int nota = notas[i];
        int quantidade = restante / nota;
        restante = restante % nota;
        if(quantidade > 0)
        {
            Console.WriteLine($"{quantidade} nota(s) de R${nota}");
        } 
    }
        if(restante > 0)
        {
            Console.WriteLine($"sobrou R${restante} que não dá para sacar");
        }
        
    
}
