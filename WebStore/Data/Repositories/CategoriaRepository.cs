using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;

namespace WebStore.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoriaRepository(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }

        public IEnumerable<Categoria> Categorias => _appDbContext.Categorias;
    }
}
