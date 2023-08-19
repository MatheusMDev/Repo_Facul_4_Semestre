using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadoFuturo
{
    class Cargo
    {
        // Definir as propriedades
        public string Nome { get; set;}
        public string Competencia { get; set; }

        //  Construtor
        public Cargo()
        {
            Nome = null;
            Competencia = null;
        }

        //método
        public void LerCargo()
        {
            Console.Write("\n Digite o Cargo: ");
            Nome = Console.ReadLine();
            Console.Write("\n Digite o Competência: ");
            Competencia = Console.ReadLine();
        }

        public string MostrarCargo()
        {
            return "\n Cargo: " + Nome +
                "\n Competência: " + Competencia; 
        }


    }
}
