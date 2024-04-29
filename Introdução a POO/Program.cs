// using Introdução_a_POO; //tenho que puxar aonde eu instanciei minha classe
string telefone, celular, email;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();
Pessoa pessoa3 = new Pessoa();

Pessoa CriarPessoa()
{
Pessoa p = new Pessoa();

#region pessoa1
p.Nome = p.DefinirNome(); // assim que aciona o metodo
p.Sobrenome = p.DefinirSobrenome();
p.Idade = p.DefinirIdade();

Console.WriteLine("Informe o Telefone:");
telefone = Console.ReadLine();
p.DefinirTelefone(telefone);

Console.WriteLine("Informe o Celular:");
celular = Console.ReadLine();
p.DefinirCelular(celular);

Console.WriteLine("Informe o Email:");
email = Console.ReadLine();
p.DefinirEmail(email);

return p;
#endregion
}
pessoa1 = CriarPessoa();
pessoa2 = CriarPessoa();
pessoa3 = CriarPessoa();

#region comentarios
//pessoa2.Nome = pessoa2.DefinirNome(); // assim que aciona o metodo
//pessoa2.Sobrenome = pessoa2.DefinirSobrenome();
//pessoa2.Idade = pessoa2.DefinirIdade();

//Console.WriteLine("Informe o Telefone:");
//telefone = Console.ReadLine();
//pessoa2.DefinirTelefone(telefone);

//Console.WriteLine("Informe o Celular:");
//celular = Console.ReadLine();
//pessoa2.DefinirCelular(celular);

//Console.WriteLine("Informe o Email:");
//email = Console.ReadLine();
//pessoa2.DefinirEmail(email);
//pessoa2.MostrarDados();
//#endregion

//#region pessoa3
//pessoa3.Nome = pessoa3.DefinirNome(); // assim que aciona o metodo
//pessoa3.Sobrenome = pessoa3.DefinirSobrenome();
//pessoa3.Idade = pessoa3.DefinirIdade();

//Console.WriteLine("Informe o Telefone:");
//telefone = Console.ReadLine();
//pessoa3.DefinirTelefone(telefone);

//Console.WriteLine("Informe o Celular:");
//celular = Console.ReadLine();
//pessoa3.DefinirCelular(celular);

//Console.WriteLine("Informe o Email:");
//email = Console.ReadLine();
//pessoa3.DefinirEmail(email);
#endregion

Console.WriteLine("Primeiro Cadastro");
pessoa1.MostrarDados();

Console.WriteLine("Segundo Cadastro");
pessoa2.MostrarDados();

Console.WriteLine("Terceiro Cadastro");
pessoa3.MostrarDados();

#region comentarios
//Console.WriteLine(pessoa.ToString());

//Console.WriteLine(pessoa.Nome);
//Console.WriteLine(pessoa.Sobrenome);
//Console.WriteLine(pessoa.Idade);
//Console.WriteLine(pessoa.Telefone);
//Console.WriteLine(pessoa.Celular);
//Console.WriteLine(pessoa.Email);
#endregion