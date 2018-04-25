using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;

namespace WebStore.Data.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoDeCompras _carrinhoDeCompras;

        public CompraRepository(AppDbContext appDbContext, CarrinhoDeCompras carrinhoDeCompras)
        {
            this._appDbContext = appDbContext;
            this._carrinhoDeCompras = carrinhoDeCompras;
        }

        public void CriarCompra(Compra compra)
        {
            compra.DataCompra = DateTime.Now;
            _appDbContext.Compras.Add(compra);

            var itensDoCarrinho = _carrinhoDeCompras.ItensDoCarrinho;

            foreach (var item in itensDoCarrinho)
            {
                var detalheCompra = new DetalhesCompra()
                {
                    Quantidade = item.Quantidade,
                    RoupaId = item.Roupa.RoupaId,
                    Preco = item.Roupa.Preco,
                    CompraId = compra.CompraId
                };
                _appDbContext.DetalhesCompras.Add(detalheCompra);
            }

            _appDbContext.SaveChanges();
        }
    }
}
