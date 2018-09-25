using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca poupador1 = new ContaPoupanca(2000);
            ContaPoupanca poupador2 = new ContaPoupanca(3000);

            ContaPoupanca.AlterarTaxaDeJuros(0.04);

            Console.Write("*Juros de 4%\n\n");

            Console.Write("Novo Saldo do poupador1: R$ " + poupador1.CalcularJuroMensal());

            Console.Write("\nNovo Saldo do poupador2: R$ " + poupador2.CalcularJuroMensal());

            ContaPoupanca.AlterarTaxaDeJuros(0.05);

            Console.Write("\n\n\n*Juros de 5%\n\n");

            Console.Write("Novo Saldo do poupador1: R$ " + poupador1.CalcularJuroMensal());

            Console.Write("\nNovo Saldo do poupador2: R$ " + poupador2.CalcularJuroMensal());

            Console.ReadKey();
        }
    }
}
