using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Itens_Pedido
    {
        public int IdPedido { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public Produto Produto { get; set; }

        public decimal ValorTotal
        {
            get
            {
                return Quantidade * Valor;
            }
        }
    }
}