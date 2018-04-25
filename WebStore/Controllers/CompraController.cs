using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;

namespace WebStore.Controllers
{
    public class CompraController : Controller
    {
        private readonly ICompraRepository _compraRepository;
        private readonly CarrinhoDeCompras _carrinhoDeCompras;

        public CompraController(ICompraRepository compraRepository, CarrinhoDeCompras carrinhoDeCompras)
        {
            this._carrinhoDeCompras = carrinhoDeCompras;
            this._compraRepository = compraRepository;
        }

        [Authorize]
        public IActionResult FinalizarCompra()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult FinalizarCompra(Compra compra)
        {
            var itens = _carrinhoDeCompras.GetItensDoCarrinho();
            _carrinhoDeCompras.ItensDoCarrinho = itens;

            if (_carrinhoDeCompras.ItensDoCarrinho.Count == 0)
            {
                ModelState.AddModelError("", "Seu carrinho está vazio. Compre algo antes.");
            }

            if (ModelState.IsValid)
            {
                _compraRepository.CriarCompra(compra);
                _carrinhoDeCompras.ClearCarrinho();
                return RedirectToAction("CompraCompleta");
            }

            return View(compra);
        }

        public IActionResult CompraCompleta()
        {
            ViewBag.CompraCompletaMenssagem = "Obrigado pela sua compra! :D";
            return View();
        }
    }
}