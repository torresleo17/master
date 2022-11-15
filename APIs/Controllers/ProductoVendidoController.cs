using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIs.Repository;
using APIs.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : ControllerBase
    {

        private readonly ILogger<ProductoVendidoController> _logger;

        public ProductoVendidoController(ILogger<ProductoVendidoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{idUsuario}")]
        public IEnumerable<ProductoVendido> GetAllProductosVendidos(int idUsuario)
        {
            return ADOProductoVendido.GetProductosVendidos(idUsuario);
        }
    }
}
