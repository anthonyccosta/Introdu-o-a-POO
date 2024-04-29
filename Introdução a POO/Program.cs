// using Introdução_a_POO; //tenho que puxar aonde eu instanciei minha classe
string telefone, celular, email;
Pessoa pessoa = new Pessoa();

pessoa.Nome = pessoa.DefinirNome(); // assim que aciona o metodo
pessoa.Sobrenome = pessoa.DefinirSobrenome();
pessoa.Idade = pessoa.DefinirIdade();


Console.WriteLine("Informe o Telefone:");
telefone = Console.ReadLine();
pessoa.DefinirTelefone(telefone);

Console.WriteLine("Informe o Celular:");
celular = Console.ReadLine();
pessoa.DefinirCelular(celular);

Console.WriteLine("Informe o Email:");
email = Console.ReadLine();
pessoa.DefinirEmail(email);


pessoa.MostrarDados();
//Console.WriteLine(pessoa.ToString());

//Console.WriteLine(pessoa.Nome);
//Console.WriteLine(pessoa.Sobrenome);
//Console.WriteLine(pessoa.Idade);
//Console.WriteLine(pessoa.Telefone);
//Console.WriteLine(pessoa.Celular);
//Console.WriteLine(pessoa.Email);