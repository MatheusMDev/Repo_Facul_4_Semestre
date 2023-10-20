using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Produto
    {
        // atributos = propriedades
        public int idProduto { get; set; }
        public string NomeProd { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string urlImagem { get; set; }
        public Categoria Categoria { get; set; }
    }
}