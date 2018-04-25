using System.Collections.Generic;
using WebStore.Data.Models;

namespace WebStore.Data.Interfaces
{
    public interface IRoupaRepository
    {
        IEnumerable<Roupa> Roupas { get;}

        IEnumerable<Roupa> RoupasPreferidas { get;}

        Roupa GetRoupaById(int roupaId);
    }
}