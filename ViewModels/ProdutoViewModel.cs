namespace ArtigoSerilogSql.API.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(int id, string descricao, decimal preco, string categoria)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            Categoria = categoria;
        }
        
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
}