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
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{idUsuario}")]
        public IEnumerable<Producto> GetAllProductos(int idUsuario)
        {
            return ADOProducto.GetProductos(idUsuario);
        }

        [HttpPut]
        public void PutProductos(Producto producto)
        {
            
             ADOProducto.ModificarProductos(producto);
        }

        [HttpPost]
        public void PostProducto(Producto producto)
        {
            ADOProducto.InsertProducto(producto);
        }

        [HttpDelete("{idProducto}")]
        public void DeleteProductos(int idProducto)
        {
            ADOProducto.EliminarProducto(idProducto);
        }
    }
}
