using System;

class Produto
{
    /*
    modificadores de acesso são as maneiras de você visualizar um atributo ou metodo

        public      -> Atributos e métodos visíveis em qualquer classe

        private     -> Atributos e métodos visíveis apenas na  classe onde são criados

        protected   -> Atributos e métodos visíveis em classes onde são criados ou herdados
    */

    public string nome;
    private string valor;
    protected string quant;
}