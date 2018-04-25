using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data.Models
{
    public class Roupa
    {
        public int RoupaId { get; set; }

        public string Name { get; set; }

        public string DescricaoPequena { get; set; }

        public string DescricaoLonga { get; set; }

        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool RoupaPrefirada { get; set; }

        public bool InStock { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
