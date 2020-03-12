using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myProjectApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class ToyotaController : Controller
    {

 

        //[HttpPost]
        //public async Task<Data.PokemonResponce> SearchPokemon([FromBody]Data.SearchPokemon request)
        //{
        //    var responce = new Data.PokemonResponce();

        //    var apiProcess = new PokemonBusiness(_pokemonRepository);
        //    responce.Pokemons = await apiProcess.SearchOnCreateria(request.Сriterion, request.Value);
        //    return responce;
        //}

       

        public IActionResult Index()
        {
            return View();
        }
    }
}