using Mi_API.Controllers.Connection;

namespace Mi_API.DataBase
{
    public class Consultas(IConfiguration config) : NpgsqlConecction(config)
    {
        
    }
}
