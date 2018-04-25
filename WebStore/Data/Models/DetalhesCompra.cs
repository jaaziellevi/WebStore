using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data.Models
{
    public class DetalhesCompra
    {
        public int DetalhesCompraId { get; set; }

        public int CompraId { get; set; }

        public int RoupaId { get; set; }

        public int Quantidade { get; set; }

        public decimal Preco { get; set; }

        public virtual Roupa Roupa { get; set; }

        public virtual Compra Compra { get; set; }
    }
}