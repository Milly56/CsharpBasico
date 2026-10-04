Console.Write("Digite um nome: ");
  string nome = Console.ReadLine();
   // contador de caracteres 
   string contadorCaractere = nome.ToString();
   contadorCaractere = contadorCaractere.Length.ToString();
   Console.WriteLine($"O número de caracteres é {contadorCaractere}");