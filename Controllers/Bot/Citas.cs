using Microsoft.AspNetCore.Mvc;
using Mi_API.DataBase;
using Mi_API.Models;

namespace Mi_API.Controllers.Bot
{
    [ApiController]
    [Route("apiBot/[controller]")]
    public class Citas(IConfiguration config) : ControllerBase
    {
        readonly IConfiguration _config = config;

        [HttpPost("CreateCita/")]
        public async Task<IActionResult> CreateCita([FromBody] RequestBot<Cita> requestBot)
        {
            Inserts inserts = new(_config);
            int result = await inserts.InsertCitaAsync(requestBot);
            return Ok(result);
        }
    }
}
