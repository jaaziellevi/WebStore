using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;
using WebStore.ViewModels;

namespace WebStore.Data.Controllers
{
    public class RoupaController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IRoupaRepository _roupaRepository;

        public RoupaController(ICategoriaRepository _categoriaRepository, IRoupaRepository _roupaRepository)
        {
            this._categoriaRepository = _categoriaRepository;
            this._roupaRepository = _roupaRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Roupa> roupas;
            string categoriaAtual;

            if (string.IsNullOrEmpty(category))
            {
                roupas = _roupaRepository.Roupas.OrderBy(n => n.RoupaId);
                categoriaAtual = "Todas as Roupas";
            }
            else
            {
                if (string.Equals("Blusas", category, StringComparison.OrdinalIgnoreCase))
                {
                    roupas = _roupaRepository.Roupas.Where(p => p.Categoria.CategoriaNome.Equals("Blusas"));
                }
                else
                {
                    roupas = _roupaRepository.Roupas.Where(p => p.Categoria.CategoriaNome.Equals("Calças"));
                }

                categoriaAtual = _category;
            }

            var roupaListViewModel = new RoupaListViewModel
            {
                Roupas = roupas,
                CurrentCategory = categoriaAtual
            };

            return View(roupaListViewModel);
        }

        public ViewResult Busca(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Roupa> roupas;

            if (string.IsNullOrEmpty(_searchString))
            {
                roupas = _roupaRepository.Roupas.OrderBy(p => p.RoupaId);
            }
            else
            {
                roupas = _roupaRepository.Roupas.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Roupa/List.cshtml", new RoupaListViewModel() { Roupas = roupas, CurrentCategory = "Todas as roupas" });
        }
    }
}