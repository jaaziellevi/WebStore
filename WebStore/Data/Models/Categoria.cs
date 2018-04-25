using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string CategoriaNome { get; set; }

        public string Descricao { get; set; }

        public List<Roupa> Roupas { get; set; }
    }
}
