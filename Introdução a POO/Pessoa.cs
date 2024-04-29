using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string Nome;
    public string Sobrenome;
    public int Idade;
    public string Telefone;
    public string Celular;
    public string Email;

    public Pessoa() //ctor abreviação para criar um construtor
    {

    }

    public string DefinirNome()
    {
        Console.WriteLine("Informe o Nome: ");

        //string nome;
        //nome = Console.ReadLine();
        //return nome; 

        return Console.ReadLine();  // este meio é o mesmo do acima, mas encurtado

    }

    public string DefinirSobrenome()
    {
        Console.WriteLine("Informe o Sobrenome: ");

        //string nome;
        //nome = Console.ReadLine();
        //return nome; 

        return Console.ReadLine();  // este meio é o mesmo do acima, mas encurtado

    }

    public int DefinirIdade()
    {
        Console.WriteLine("Informe a idade: ");

        //    int idade;
        //    idade = int.Parse(Console.ReadLine());
        //    return idade;

        return int.Parse(Console.ReadLine()); // este meio é o mesmo do acima, mas encurtado 
    }

    public void DefinirCelular(string celular)
    {
        this.Celular = celular;
        //Console.WriteLine("Informe o numero de Telefone desejado: ");

        ////string nome;
        ////nome = Console.ReadLine();
        ////return nome; 

        //return Console.ReadLine();  // este meio é o mesmo do acima, mas encurtado

    }

    public void DefinirTelefone(string telefone)
    {
        this.Telefone = telefone; //
        //Console.WriteLine("Informe o numero de Telefone fixo desejado: ");

        ////string nome;
        ////nome = Console.ReadLine();
        ////return nome; 

        //return Console.ReadLine();  // este meio é o mesmo do acima, mas encurtado

    }
    public void DefinirEmail(string email)
    {
        this.Email = email;
        //Console.WriteLine("Informe o E-mail desejado: ");

        ////string nome;
        ////nome = Console.ReadLine();
        ////return nome; 

        //return Console.ReadLine();  // este meio é o mesmo do acima, mas encurtado
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}", this.Nome);
        Console.WriteLine($"Sobrenome: {Sobrenome}", this.Sobrenome);
        Console.WriteLine($"Idade: "+this.Idade);
        Console.WriteLine($"Telefone: "+this.Telefone);
        Console.WriteLine($"Celular: {Celular}", this.Celular);
        Console.WriteLine($"Email: {Email}", this.Email);
    }

}