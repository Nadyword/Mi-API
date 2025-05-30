using System.Data;
using Npgsql;

namespace Mi_API.Controllers.Connection;

public class NpgsqlConecction(IConfiguration config)
{
    private readonly IConfiguration _config = config;

    public async Task<IDbConnection> GetConnection(string clientId)
    {
        string connectionString = _config[$"ConnectionStrings:{clientId}"]!;
        NpgsqlConnection connection = new(connectionString);
        await connection.OpenAsync();
        return connection;
    }
}