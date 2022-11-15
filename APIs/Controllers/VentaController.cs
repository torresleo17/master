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
    public class VentaController : ControllerBase
    {
        private readonly ILogger<ProductoVendido> _logger;

        public VentaController(ILogger<ProductoVendido> logger)
        {
            _logger = logger;
        }

        [HttpGet("{idUsuario}")]
        public IEnumerable<Venta> GetVentas(int idUsuario)
        {
            return ADOVenta.GetVentas(idUsuario);
        }

        [HttpPost("{idUsuario}")]
        public void PostVenta(List<Producto> productos, int idUsuario)
        {
            ADOVenta.InsertVenta(productos, idUsuario);
        }
    }
}
