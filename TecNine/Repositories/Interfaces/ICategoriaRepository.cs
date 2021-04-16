using TecNine.Models;
using System.Collections.Generic;

namespace TecNine.Repositories.Interfaces
{
    public interface ICategoriaRepository 
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
