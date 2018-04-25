using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;

namespace WebStore.Data.Mocks
{
    public class MockCategoryRepository : ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias
        {
            get
            {
                return new List<Categoria>
                {
                    new Categoria {CategoriaNome = "Blusas", Descricao = "Todas as blusas"},
                    new Categoria {CategoriaNome = "Calças", Descricao = "Todas as calças"}
                };
            }
        }
    }
}
