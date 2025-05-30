using Microsoft.AspNetCore.Mvc;
//using Mi_API.DataBase;
using System.Text.Json;
//using Mi_API.Models;

namespace Mi_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Testing(IConfiguration config) : ControllerBase
    {
        private readonly IConfiguration _config = config;

        //[HttpPost("SaveValue/")]
        //public async Task<IActionResult> Pruebas([FromBody] RequestBot<JsonElement> requestBot)
        //{

        //    Inserts inserts = new(_config);
        //    string clientId = requestBot.ClientId;
        //    string texto = requestBot.Model.ToString();

        //    int result = await inserts.InsertPruebaAsync(clientId, texto);

        //    return Ok(result);
        //}

        [HttpGet]
        public IActionResult Tas()
        {
            return Ok("Si toy");
        }
    }
}