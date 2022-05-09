using System;

namespace _05Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p =new Produto();
            p.nome = "Erick";
            //p.valor não aparece porque é um modificador de acesso private
        }
    }
}
