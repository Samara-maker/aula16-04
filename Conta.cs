

using System.Xml;

namespace aula16_04
{
    public class Conta
    {

        public int Id;
        public string Agencia;
        public int NuConta;
        public string NomeProprietario;
        public double Saldo;


        public void Deposito(double valor)
        {

            if (valor > 0)
            {

                Saldo += valor;

            }else
                Console.WriteLine("Valor invalido");
        }


        public void Saque(double valor2)
        {

           if (valor2 > 0 && valor2 < Saldo)
           {
                Saldo -= valor2;
           }
           else
                Console.WriteLine("Valor inválido... tente novamente");
            
        }


    }

}
