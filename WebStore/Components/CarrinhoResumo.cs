using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data.Models;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class CarrinhoResumo : ViewComponent
    {
        private readonly CarrinhoDeCompras _carrinho;

        public CarrinhoResumo(CarrinhoDeCompras carrinho)
        {
            this._carrinho = carrinho;
        }

        public IViewComponentResult Invoke()
        {
            var itens = _carrinho.GetItensDoCarrinho();
            _carrinho.ItensDoCarrinho = itens;

            var carrinhoVM = new CarrinhoViewModel
            {
                CarrinhoDeCompras = _carrinho,
                TotalDoCarrinho = _carrinho.GetTotalDoCarrinho()
            };

            return View(carrinhoVM);
        }
    }
}
