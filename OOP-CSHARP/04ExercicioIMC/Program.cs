using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto a
            Pessoa a = new Pessoa();
            a.nome = "Erick";
            a.peso = 80;
            a.altura = 1.68;
            a.mensagem();

            // Instanciar objeto b
            Pessoa b = new Pessoa();
            b.nome = "Barbara";
            b.peso = 64;
            b.altura = 1.64;
            b.mensagem();

            // Instanciar objeto c
            Pessoa c = new Pessoa();
            c.nome = "Tais";
            c.peso = 60;
            c.altura = 1.55;
            c.mensagem();

            // Instanciar objeto d
            Pessoa d = new Pessoa();
            d.nome = "Alex";
            d.peso = 150;
            d.altura = 1.98;
            d.mensagem();
        }
    }
}
