using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria
{
    internal class ContaEspecial : ContaBancaria
    {
        // declarar os atributos
        private double limite;

        // construtor da classe ContaEspecial
        // ContaEspecial é filha de ContaBancaria precisamos chamar a execução do construtor da classe PAI(mae)
        public ContaEspecial() : base()
        {
            limite = 0.0;
        }

        // propriedade 
        public double Limite
        {
            get { return limite; }
            set { limite = value; }

        }

        // métodos
        // Vamos adaptar o metodo Abertura da classe 
        //ContaBancaria para ficar especializado para a classe Conta Especial. Portanto, vamos sobrescrever (override) o método
        public override void Abertura(double depositoInicial)
        {
            // declarar uma váriavel do tipo string
            string msg = null;
            base.Abertura(depositoInicial);
            // vamos fazer uso do tratamento de erro
            try
            {
                Console.Write("Digite o Limite da Conta: ");
                Limite = Convert.ToDouble(Console.ReadLine());
                msg = "Limite cadastrado com sucesso";
            }
            catch (Exception erro)
            {
                msg = "Erro de cadastro. Limite é número \n" + "Erro:" + erro;
            }
            finally
            {
                Console.WriteLine(msg);
            }
        }
        public override void Sacar(double valor)
        {

            if ((base.Saldo + Limite) >= valor)
            {
                base.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }
    }
}
