using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadoFuturo
{
    class Horista : Funcionario
    {
        // propriedades
        public int QdeHoras { get; set; }

       
        ///contrutor 
        public Horista() : base()
        {
            QdeHoras = 0;
        }

        //Sobrescrever os Métodos, adaptando-os para a classe Horista
        public override void LerDados()
        {
            base.LerDados();
            try
            {
                Console.Write("\n Qde de Horas trabalhada: ");
                QdeHoras = Convert.ToInt32(Console.Read());
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n Erro: " + ex);
            }
        }
        public override string MostrarDados()
        {
            return base.MostrarDados() +
                "\n Qde de Horas trabalhadas : " + QdeHoras +
                "\n Salário Bruto R% " + CalcularSalarioBruto() +
                "\n Salário Liquido R% " + CalcularSalarioLiquido();
        }
        public override double CalcularSalarioBruto()
        {
            return base.SalarioBase * QdeHoras + base.Adicional;
        }

        public override double CalcularSalarioLiquido()
        {
            return CalcularSalarioBruto() - (CalcularSalarioBruto () * 0.18);
        }
    }
}
