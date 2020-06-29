using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIJWT.Service;

namespace WebAPIJWT.Controllers
{


    [Route("api/Login")]
    [ApiController]
    public class AuthController : ControllerBase
    {

       
        [HttpPost]
        public async Task<IActionResult> Post (Usuario user)
        {
            var token = TokenService.GenerateToken(user);
         
            return Ok( new { token = token }) ;
        }


    }
}