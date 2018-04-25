using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebStore.Data.Models
{
    public class CarrinhoDeCompras
    {
        private readonly AppDbContext _appDbContext;

        private CarrinhoDeCompras(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public string CarrinhoDeComprasId { get; set; }

        public List<ItemDoCarrinho> ItensDoCarrinho { get; set; }

        public static CarrinhoDeCompras GetCarrinho(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            session.SetString("CarrinhoId", carrinhoId);

            return new CarrinhoDeCompras(context){CarrinhoDeComprasId = carrinhoId};
        }

        public void AddToCarrinho(Roupa roupa, int quantidade)
        {
            var carrinhoItem = _appDbContext.ItensDoCarrinho.SingleOrDefault(s =>
                s.Roupa.RoupaId == roupa.RoupaId && s.CarrinhoDeComprasId == CarrinhoDeComprasId);

            if (carrinhoItem == null)
            {
                carrinhoItem = new ItemDoCarrinho
                {
                    CarrinhoDeComprasId = CarrinhoDeComprasId,
                    Roupa = roupa,
                    //Quantidade = 1
                    Quantidade = quantidade
                };
                _appDbContext.ItensDoCarrinho.Add(carrinhoItem);
            }
            else
            {
                //carrinhoItem.Quantidade++;
                carrinhoItem.Quantidade += quantidade;
            }

            _appDbContext.SaveChanges();
        }

        public int RemoveFromCarrinho(Roupa roupa)
        {
            var carrinhoItem = _appDbContext.ItensDoCarrinho.SingleOrDefault(s =>
                s.Roupa.RoupaId == roupa.RoupaId && s.CarrinhoDeComprasId == CarrinhoDeComprasId);
            var quantidadeLocal = 0;

            if (carrinhoItem != null)
            {
                if (carrinhoItem.Quantidade > 1)
                {
                    carrinhoItem.Quantidade--;
                    quantidadeLocal = carrinhoItem.Quantidade;
                }
                else
                {
                    _appDbContext.ItensDoCarrinho.Remove(carrinhoItem);
                }
            }

            _appDbContext.SaveChanges();

            return quantidadeLocal;
        }

        public List<ItemDoCarrinho> GetItensDoCarrinho()
        {
            return ItensDoCarrinho ?? _appDbContext.ItensDoCarrinho
                       .Where(c => c.CarrinhoDeComprasId == CarrinhoDeComprasId).Include(s => s.Roupa).ToList();
        }

        public void ClearCarrinho()
        {
            var carrinhoItens = _appDbContext.ItensDoCarrinho.Where(c => c.CarrinhoDeComprasId == CarrinhoDeComprasId);

            _appDbContext.ItensDoCarrinho.RemoveRange(carrinhoItens);

            _appDbContext.SaveChanges();
        }

        public decimal GetTotalDoCarrinho()
        {
            var total = _appDbContext.ItensDoCarrinho.Where(c => c.CarrinhoDeComprasId == CarrinhoDeComprasId)
                .Select(c => c.Roupa.Preco * c.Quantidade).Sum();

            return total;
        }
    }
}
