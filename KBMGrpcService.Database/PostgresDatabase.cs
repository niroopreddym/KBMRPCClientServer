using Dapper;
using KBMGrpcService.Database.Interfaces;
using Npgsql;

namespace KBMGrpcService.Database;

public class PostgresDatabase : IDatabase
{
    private readonly string _connectionString;

    public PostgresDatabase(string connectionString)
    {
        _connectionString = connectionString;
    }

    private NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }

    public async Task<int> ExecuteAsync(string query, object parameters = null)
    {
        using var connection = GetConnection();
        await connection.OpenAsync();
        return await connection.ExecuteAsync(query, parameters);
    }

    public async Task<T> QuerySingleOrDefaultAsync<T>(string query, object parameters = null)
    {
        using var connection = GetConnection();
        await connection.OpenAsync();
        return await connection.QuerySingleOrDefaultAsync<T>(query, parameters);
    }

    public async Task<IEnumerable<T>> QueryAsync<T>(string query, object parameters = null)
    {
        using var connection = GetConnection();
        await connection.OpenAsync();
        return await connection.QueryAsync<T>(query, parameters);
    }
}
