using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome = "Erick";
            a.nota1 = 9;
            a.nota2 = 10;
            a.Mensagem();

            Aluno b = new Aluno();
            b.nome = "Alex";
            b.nota1 = 6;
            b.nota2 = 8;
            b.Mensagem();

            Aluno c = new Aluno();
            c.nome = "Barbara";
            c.nota1 = 5;
            c.nota2 = 3;
            c.Mensagem();
        }
    }
}