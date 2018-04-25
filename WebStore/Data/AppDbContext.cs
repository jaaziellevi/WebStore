using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Data.Models;

namespace WebStore.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Roupa> Roupas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<ItemDoCarrinho> ItensDoCarrinho { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<DetalhesCompra> DetalhesCompras { get; set; }
    }
}
