using ArtigoSerilogSql.API.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ArtigoSerilogSql.API.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ICatalogoService _catalogoService;
        public CatalogosController(ICatalogoService catalogoService)
        {
            _catalogoService = catalogoService;
        }

        [HttpGet]
        public IActionResult Get() {
            var usuario = "utilize aqui uma maneira de obter o usuário";

            // Utilize ForContext com quaisquer colunas extras que você queira guardar. Pode ser o nome do usuário, IP, ou outra informação.
            Log.ForContext("Action", "Catalogos.Get").Information($"API chamada por {usuario}.");

            var catalogo =  _catalogoService.ObterCatalogo();

            return Ok(catalogo);
        }
    }
}