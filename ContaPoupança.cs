using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ContaPoupanca
    {
        static double taxaDeJurosAnual = 0;
        private double saldoPoupanca = 0;

        public ContaPoupanca(double saldoPoupanca) 
        {
            this.saldoPoupanca = saldoPoupanca;
        }

        public static void AlterarTaxaDeJuros(double novaTaxaDeJurosAnual)
        {
            taxaDeJurosAnual = novaTaxaDeJurosAnual;
        }

        public double CalcularJuroMensal()
        {
            saldoPoupanca += (saldoPoupanca * taxaDeJurosAnual) / 12;
            return saldoPoupanca;
        }
    }
}
