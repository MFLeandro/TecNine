﻿using TecNine.Models;
using TecNine.Repositories.Interfaces;
using System.Collections.Generic;

namespace TecNine.Repositories.Mocks
{
    public class MockCategoriaRepository : ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias
        {
            get
            {
                return new List<Categoria>
                     {
                         new Categoria { CategoriaNome = "Normal", Descricao = "Lanches com ingredientes normais" },
                         new Categoria { CategoriaNome = "Natural", Descricao = "Lanches com ingredientes naturais" },
                         new Categoria { CategoriaNome = "Bebidas", Descricao = "Bebidas para acompanhar os lanches" }
                     };
            }
        }
    }
}
