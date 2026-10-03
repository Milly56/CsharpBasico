
Console.Write("Digite nome do usuário: ");
string usuario = Console.ReadLine();

Console.Write("Digite sua senha: ");
string senha = Console.ReadLine();

if(senha == "123456")
{
    Console.WriteLine("Senha correta!");
     Console.WriteLine($"Seja bem-vindo(a), {usuario}!");
}
else
{
    Console.WriteLine("Senha incorreta!");
}

