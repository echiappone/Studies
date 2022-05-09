using System;

class Pessoa
{
    // Atributos
    protected string nome;
    protected int idade;

    // Método

    protected void mensagemPessoaIdade()
    {
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("Idade: "+idade);
    }
}