using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;

namespace WebStore.Data.Repositories
{
    public class RoupaRepository : IRoupaRepository
    {
        private readonly AppDbContext _appDbContext;

        public RoupaRepository(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }

        public IEnumerable<Roupa> Roupas => _appDbContext.Roupas.Include(c => c.Categoria);

        public IEnumerable<Roupa> RoupasPreferidas =>
            _appDbContext.Roupas.Where(p => p.RoupaPrefirada).Include(c => c.Categoria);

        public Roupa GetRoupaById(int roupaId) => _appDbContext.Roupas.FirstOrDefault(p => p.RoupaId == roupaId);
    }
}
