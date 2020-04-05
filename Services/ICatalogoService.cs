using ArtigoSerilogSql.API.ViewModels;

namespace ArtigoSerilogSql.API.Services
{
    public interface ICatalogoService
    {
        CatalogoViewModel ObterCatalogo();
    }
}