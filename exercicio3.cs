
    double Base = 0;
    double Altura = 0;

    Console.Write("Digite a base do triângulo: ");
    if(double.TryParse(Console.ReadLine(), out double b))
{
        Base = b;
    }

    Console.Write("Digite a altura do triângulo: ");
    if(double.TryParse(Console.ReadLine(), out double a))
    {
        Altura = a;
    }

    double area = (Base * Altura);
    Console.WriteLine($"A área do Retângulo é: {area}");
    
    double perimetro = 2 * (Base + Altura);
    Console.WriteLine($"O perímetro do Retângulo é: {perimetro}");  


