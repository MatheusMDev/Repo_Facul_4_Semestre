using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadoFuturo
{
    class Program
    {
        static void Main(string[] args)
        {
            Horista horista = new Horista();
            horista.LerDados();
            Console.WriteLine(horista.MostrarDados());
            Console.ReadKey();
        }
    }
}
