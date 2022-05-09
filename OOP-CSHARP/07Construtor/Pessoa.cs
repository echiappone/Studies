using System;

class Pessoa
{
    // Construtor
    // Todo construtor é publico

    public Pessoa()
    {
        Console.WriteLine("Olá");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
}