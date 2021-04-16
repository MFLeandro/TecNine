using TecNine.Context;
using TecNine.Models;
using TecNine.Repositories.Interfaces;
using System.Collections.Generic;

namespace TecNine.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
