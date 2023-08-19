using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadoFuturo
{
    // A classe funciónário implementa a interface ICalcularSalario
     abstract class Funcionario : ICalcularSalario
    {
        // propriedade 
        public string NomeFunc { get; set; }
        public double SalarioBase { get; set; }
        public double Adicional { get; set; }
        public Cargo Cargo { get; set; }

        // Construtor 
        public Funcionario()
        {
            NomeFunc = null;
            SalarioBase = 0.0;
            Adicional = 0.0;
            // O atributo cargo (propriedade Cargo) é um objeto. Portanto necessita ser instanciado.
            Cargo = new Cargo();
        }
        
        // Métodos 
        public virtual void LerDados()
        {
            try
            {
                Console.Write("Nome do Funcionario: ");
                NomeFunc = Console.ReadLine();
                Console.Write("Salário Base R$: ");
                SalarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adicional R$: ");
                Adicional = Convert.ToDouble(Console.ReadLine());
                // Chamar a leitura dos dados do cargo do funcionario
                Cargo.LerCargo();
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n Ocorreu um erro: " + ex);
            }
        }

        public virtual string MostrarDados()
        {
            return "\n --------- DADOS DO FUNCIONARIO ---------" +
                "\n Nome Funcionario: " + NomeFunc +
                "\n Salario Base R$: " + SalarioBase +
                "\n Adicional R$: " + Adicional +
                Cargo.MostrarCargo();
        }
        
         //Métodos abstratos. Serão implementados nas classes horista e mensalista
        public abstract double CalcularSalarioBruto();
        public abstract double CalcularSalarioLiquido();
    }   
}
