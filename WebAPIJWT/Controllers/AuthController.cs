using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIJWT.Service;

namespace WebAPIJWT.Controllers
{

    ///<Summary>
    /// Controller Login
    ///</Summary>
    [Route("api/Login")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        /// <summary>
        /// Metodo Utilizado para realizar Login do Usuario
        /// </summary>
        /// <remarks>Realize a requisicao para gerar o token de acesso</remarks>
        /// <param name="user"></param>
        /// <returns>Token de Acesso</returns>
        /// <response code="200">Login bem sucedido</response>
        [HttpPost]
        public IActionResult Post ( Usuario user)
        {
            var token = TokenService.GenerateToken(user);
         
            return Ok( new { token = token }) ;
        }





    }
}