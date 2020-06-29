using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPIJWT.Controllers
{


    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {

        [HttpGet]
        [Authorize(Roles ="Administrador,Mestre")]
        [Route("Lista1")]
        public List<Usuario> listausuarios()
        {

            var retorno = new List<Usuario>();

            for (int i = 0; i < 30; i++)
            {
                retorno.Add(new Usuario { Id = i, Nome = "Flavio", Email = "Flavio_marteletto@hotmail.com", Role = "Adminitrador" });
            }

            return retorno;


        }


        [HttpGet]
        [Route("Lista2")]
        public List<Usuario> listausuarioss()
        {

            var retorno = new List<Usuario>();

            for (int i = 0; i < 30; i++)
            {
                retorno.Add(new Usuario { Id = i, Nome = "Flavio", Email = "Flavio_marteletto@hotmail.com" , Role = "Adminitrador"});
            }

            return retorno;


        }



        [HttpGet]
        [AllowAnonymous]
        [Route("Lista3")]
        public List<Usuario> listausuariosss()
        {

            var retorno = new List<Usuario>();

            for (int i = 0; i < 30; i++)
            {
                retorno.Add(new Usuario { Id = i, Nome = "Flavio", Email = "Flavio_marteletto@hotmail.com", Role = "Adminitrador" });
            }

            return retorno;


        }




        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var retorno = listausuarios();

            return Ok(retorno);
        }





        [HttpPost]
        public async Task<IActionResult> Post (Usuario user )
        {
            
            return Ok(user);
        }





    }





}


