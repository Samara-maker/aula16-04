

using System;
using System.Security.Cryptography;
using aula16_04;
using static System.Net.Mime.MediaTypeNames;



//Console.WriteLine("Digite o Id da conta:");
//conta.Id = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite a agência:");
//conta.Agencia = Console.ReadLine();

//Console.WriteLine("Digite o número da conta:");
//conta.NuConta = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("Digite o nome do proprietário:");
//conta.NomeProprietario = Console.ReadLine();

//Console.WriteLine("Digite o saldo:");
//conta.Saldo = Convert.ToDouble(Console.ReadLine());

//bool teste = true;

//while (teste)
//{
//    Console.WriteLine("Digite 1 para depositar e 2 para sacar");
//    int opcao = Convert.ToInt32(Console.ReadLine());

//    if(opcao == 1)
//    {
//        Console.WriteLine("Digite um valor para depositar:");
//        double valor = Convert.ToDouble(Console.ReadLine());
//        double res = conta.Saldo + valor;
//        conta.Deposito(valor);
//        Console.WriteLine("O valor final é:" + res);

//    }
//    else if(opcao == 2)
//    {
//        Console.WriteLine("Digite um valor paa sacar:");
//        double valor2 = Convert.ToDouble(Console.ReadLine());
//        double res = conta.Saldo - valor2;
//        conta.Saque(valor2);
//        Console.WriteLine("O valor final é:");
//    }else
//        teste = false;
//}



List<Conta> lconta = new List<Conta>();

bool teste = true;

while (teste)
{
    Conta conta = new Conta();

    Console.WriteLine("Deseja cadastrar uma nova conta? Digite 1 para cadastrar e 2 para listar");
    int op = Convert.ToInt32(Console.ReadLine());

    if (op == 1)
    {

        Console.WriteLine("Digite o Id da conta:");
        conta.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a agência:");
        conta.Agencia = Console.ReadLine();

        Console.WriteLine("Digite o número da conta:");
        conta.NuConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o nome do proprietário:");
        conta.NomeProprietario = Console.ReadLine();
        conta.Saldo = 0;
        lconta.Add(conta);
    
    }else if(op == 2) {

        foreach (Conta c in lconta)
        {
            Console.WriteLine("ID: " +c.Id +" agencia: "+c.Agencia+" Numero da conta: "+c.NuConta+" Nome do proprietario: "+c.NomeProprietario);
        }
    }
    else
    {
        break;
    }
}


