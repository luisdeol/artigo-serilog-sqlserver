using System;
using System.Collections.Generic;
using ArtigoSerilogSql.API.ViewModels;

namespace ArtigoSerilogSql.API.Services
{
    public class CatalogoService : ICatalogoService
    {
        private readonly CatalogoViewModel _catalogo;

        public CatalogoService()
        {
            var produtosViewModel = new List<ProdutoViewModel> {
                    new ProdutoViewModel(1, "mouse", 100, "Tecnologia"),
                    new ProdutoViewModel(2, "álcool em gel", 500, "Farmácia"),
                    new ProdutoViewModel(3, "máscara", 700, "Moda")
                };

            _catalogo = new CatalogoViewModel(DateTime.Now.ToString("d"), produtosViewModel);
        }

        public CatalogoViewModel ObterCatalogo()
        {
            return _catalogo;
        }
    }
}