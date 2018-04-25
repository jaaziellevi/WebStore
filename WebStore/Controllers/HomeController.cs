using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRoupaRepository _roupaRepository;

        public HomeController(IRoupaRepository roupaRepository)
        {
            this._roupaRepository = roupaRepository;
        }

        public ViewResult Index()
        {
            var homeVM = new HomeViewModel
            {
                RoupasPreferidas = _roupaRepository.RoupasPreferidas
            };

            return View(homeVM);
        }
    }
}