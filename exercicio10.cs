Console.WriteLine("Digite um nome de usuário: ");
 string usuario = Console.ReadLine();
 
 Console.WriteLine("Digite a senha correta: ");
 string senha = Console.ReadLine();

  while(!senha.Equals("1234"))
  {
   Console.WriteLine("Digite a senha correta: ");
   senha = Console.ReadLine();
  }
  Console.WriteLine("Senha correta! Acesso permitido.");
