

using System.Security.Cryptography.X509Certificates;
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


        public Conta()
        {

        }

        public Conta (int Id, string Agencia, int NuConta, string NomeProprietario, double Saldo)
        {
            this.Id = Id;
            this.Agencia = Agencia;
            this.NuConta = NuConta;
            this.NomeProprietario = NomeProprietario;
            this.Saldo = Saldo;
        }


        public void Deposito(double valor)
        {

            if (valor > 0)
            {

                Saldo += valor;

            }else
               throw new Exception("Valor invalido");


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
