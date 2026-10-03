Console.Write("Digite uma senha: ");
string senha = Console.ReadLine();

if(senha.Length < 8)
{
    Console.WriteLine("Senha inválida. A senha deve ter pelo menos 8 caracteres.");
}
else
{
    Console.WriteLine("Senha válida.");
}
