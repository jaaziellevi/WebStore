using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Models;

namespace WebStore.ViewModels
{
    public class CarrinhoViewModel
    {
        public CarrinhoDeCompras CarrinhoDeCompras { get; set; }

        public decimal TotalDoCarrinho { get; set; }
    }
}
