using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Models;

namespace WebStore.ViewModels
{
    public class RoupaListViewModel
    {
        public IEnumerable<Roupa> Roupas { get; set; }

        public string CurrentCategory { get; set; }
    }
}
