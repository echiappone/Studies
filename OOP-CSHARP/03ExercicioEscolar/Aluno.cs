using System;

class Aluno
{
    // Atributos
    public string nome;
    public double nota1, nota2;

    // Métodos
    // Média
    public double media()
    {
        return (nota1+nota2)/2;
    }

    // Situação
    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    // Mensagem
    public void Mensagem()
    {
        // Obter a média
        double obterMedia = media();

        // Obter a situação
        string obterSituacao = situacao(obterMedia);

        //Mensagem
        Console.WriteLine($"\n{nome} está {obterSituacao} com média {obterMedia}\n");
    }
}