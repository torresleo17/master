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
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<ProductoVendido> _logger;

        public UsuarioController(ILogger<ProductoVendido> logger)
        {
            _logger = logger;
        }

        [HttpGet("{nombreUsuario}/{contraseña}")]
        public Usuario GetUsuarioByContraseña(string nombreUsuario, string contraseña)
        {
            var usuario = ADOUsuario.GetUsuarioByPassword(nombreUsuario, contraseña);

            return usuario == null ? new Usuario() : usuario;
        }

        [HttpGet("{nombreUsuario}")]
        public Usuario GetUsuarioByNombre(string nombreUsuario)
        {
            var usuario = ADOUsuario.GetUsuarioByUserName(nombreUsuario);

            return usuario == null ? new Usuario() : usuario;
        }

        [HttpPost]
        public void PostUsuario(Usuario usuario)
        {
            ADOUsuario.InsertUsuario(usuario);
        }

        [HttpPut]
        public bool PutUsuario(Usuario usuario)
        {
            return ADOUsuario.UpdateUsuario(usuario);
        }
    }
}
