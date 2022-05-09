using System;

class Pessoa
{
    // Atriuto
    private string nome = "Barbara";

    // Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine("Olá "+nome);
        Console.WriteLine("Olá "+this.nome);
    }
}