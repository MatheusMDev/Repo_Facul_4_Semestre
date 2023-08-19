using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria
{
    internal class ContaBancaria
    {
        // declaração dos atributos
        private string nomeCliente;
        private string nroConta;
        private double saldo;

        // construtor da classe
        public ContaBancaria()
        {
            nomeCliente = null;
            nroConta = null;
            saldo = 0.0;
        }

        // propriedades
        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public string NroConta
        {
            get { return nroConta; }
            set { nroConta = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        // metodos
        public virtual void Abertura(double depositoInicial)
        {
            Saldo = depositoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public double VerificaSaldo()
        {
            return saldo;
        }

    }
}
