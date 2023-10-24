using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Pedido
    {
        // atributos = propriedades
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public int Status { get; set; }
        // todo pedido tem pelo menos um item ( produto) 
        public List<Itens_Pedido> Itens { get; set; } = new List<Itens_Pedido>();
        public decimal TotalPedido
        {
            get
            {
                //for(i=0; i < ItensCount; i++)
                //{ 
                //   soma = soma + Itens[i].ValorTotal;
                //}
                // return soma;   
                return Itens.Sum(i => i.ValorTotal); // Forma de LAMBDA

            }
        }

    }
}