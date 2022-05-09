using System;

    public class Pessoa
    {
        // Atributos
        public string nome;
        public double peso, altura;

        // Calculo IMC
        public double imc()
        {
            return peso / (altura*altura);
        }

        // Situação
        public string situacao(double imc)
        {
            // Variavel
            string retorno;

            // Condicional
            if (imc < 18.5)
            {
                retorno = "abaixo do peso!";
            }
            else if (imc < 25)
            {
                retorno = "com peso normal!";
            }
            else if (imc < 30)
            {
                retorno = "acima do peso!";
            }
            else if (imc < 35)
            {
                retorno = "com obesidade I!";
            }
            else if (imc < 40)
            {
                retorno = "com obesidade II!";
            }
            else
            {
                retorno = "com obesidade III!";
            }

            // Retorno
            return retorno;
        }

        // Mensagem
        public void mensagem()
        {
            // Obter IMC
            double obterImc = imc();

            // Obter Situação
            string obterSituacao = situacao(obterImc);
            
            // Apresentar IMC
            Console.WriteLine($"\n{nome} \nVocê pesa {peso}Kg \nTem {altura} de altura \nSeu IMC é {obterImc.ToString("F")} \nVocê esta {obterSituacao}\n_________________________");
        }
    }