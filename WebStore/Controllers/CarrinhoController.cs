using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly IRoupaRepository _roupaRepository;
        private readonly CarrinhoDeCompras _carrinhoDeCompras;

        public CarrinhoController(IRoupaRepository roupaRepository, CarrinhoDeCompras carrinhoDeCompras)
        {
            this._carrinhoDeCompras = carrinhoDeCompras;
            this._roupaRepository = roupaRepository;
        }

        [Authorize]
        public ViewResult Index()
        {
            var itens = _carrinhoDeCompras.GetItensDoCarrinho();
            _carrinhoDeCompras.ItensDoCarrinho = itens;

            var carrinhoVM = new CarrinhoViewModel
            {
                CarrinhoDeCompras = _carrinhoDeCompras,
                TotalDoCarrinho = _carrinhoDeCompras.GetTotalDoCarrinho()
            };

            return View(carrinhoVM);
        }

        [Authorize]
        public RedirectToActionResult AddToCarrinho(int roupaId)
        {
            var roupaSelecionada = _roupaRepository.Roupas.FirstOrDefault(p => p.RoupaId == roupaId);

            if (roupaSelecionada != null)
            {
                _carrinhoDeCompras.AddToCarrinho(roupaSelecionada, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveDoCarrinho(int roupaId)
        {
            var roupaSelecionada = _roupaRepository.Roupas.FirstOrDefault(p => p.RoupaId == roupaId);

            if (roupaSelecionada != null)
            {
                _carrinhoDeCompras.RemoveFromCarrinho(roupaSelecionada);
            }

            return RedirectToAction("Index");
        }
    }
}