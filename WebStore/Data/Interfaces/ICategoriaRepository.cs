using System.Collections.Generic;
using WebStore.Data.Models;

namespace WebStore.Data.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}