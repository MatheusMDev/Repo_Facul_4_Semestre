using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresadoFuturo
{
    interface ICalcularSalario
    {
        // só temos a assinatura dos métodos, porque eles são publicos e abstratos por definição
        // Esses métodos serão  implementados nas classes que implementam a interface
        double CalcularSalarioBruto();
        double CalcularSalarioLiquido();
    }
}
