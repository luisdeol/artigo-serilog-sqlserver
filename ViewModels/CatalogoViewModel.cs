using System.Collections.Generic;

namespace ArtigoSerilogSql.API.ViewModels
{
    public class CatalogoViewModel
    {
        public CatalogoViewModel(string atualizadoEm, List<ProdutoViewModel> produtos)
        {
            AtualizadoEm = atualizadoEm;
            Produtos = produtos;
        }
        
        public string AtualizadoEm { get; set; }
        public List<ProdutoViewModel> Produtos { get; set; }
    }
}