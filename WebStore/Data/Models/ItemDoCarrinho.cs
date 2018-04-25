using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data.Models
{
    public class ItemDoCarrinho
    {
        public int ItemDoCarrinhoId { get; set; }

        public Roupa Roupa { get; set; }

        public int Quantidade { get; set; }

        public string CarrinhoDeComprasId { get; set; }
    }
}
