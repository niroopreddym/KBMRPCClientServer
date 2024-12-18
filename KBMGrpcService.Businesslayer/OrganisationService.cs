using KBMGrpcService.Businesslayer.Interfaces;
using KBMGrpcService.Businesslayer.models;
using KBMGrpcService.Database;

namespace KBMGrpcService.Businesslayer;

public class OrganisationService : IOrganizationService
{
    private readonly PostgresDatabase _database;

    public OrganisationService(PostgresDatabase database)
    {
        _database = database;
    }

    public async Task<OrganizationModel> CreateOrganizationAsync(string name, string address)
    {
        var id = Guid.NewGuid();
        var query = @"
                INSERT INTO Organizations (Id, Name, Address, CreatedAt, UpdatedAt)
                VALUES (@Id, @Name, @Address, NOW(), NOW())
                RETURNING Id;
            ";
        var parameters = new { Id = id, Name = name, Address = address };

        await _database.ExecuteAsync(query, parameters);
        return new OrganizationModel
        {
            Id = id.ToString(),
            Name = name,
            Address = address,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }

    public async Task<bool> DeleteOrganizationAsync(Guid id)
    {
        var query = "UPDATE Organizations SET DeletedAt = NOW() WHERE Id = @Id AND DeletedAt IS NULL;";
        var rowsAffected = await _database.ExecuteAsync(query, new { Id = id });
        return rowsAffected > 0;
    }

    public async Task<OrganizationModel?> GetOrganizationByIdAsync(Guid id)
    {
        var query = @"
                SELECT Id, Name, Address, CreatedAt, UpdatedAt 
                FROM Organizations 
                WHERE Id = @Id AND DeletedAt IS NULL;
            ";
        return await _database.QuerySingleOrDefaultAsync<OrganizationModel>(query, new { Id = id });
    }

    public async Task<IEnumerable<OrganizationModel>> QueryOrganizationsAsync(int page, int pageSize, string orderBy, string direction, string queryString)
    {
        var offset = (page - 1) * pageSize;
        var query = $@"
                SELECT Id, Name, Address, CreatedAt, UpdatedAt 
                FROM Organizations 
                WHERE (Name ILIKE @Query OR Address ILIKE @Query) AND DeletedAt IS NULL
                ORDER BY {orderBy} {direction} 
                LIMIT @PageSize OFFSET @Offset;
            ";
        return await _database.QueryAsync<OrganizationModel>(query, new { Query = $"%{queryString}%", PageSize = pageSize, Offset = offset });
    }

    public async Task<bool> UpdateOrganizationAsync(Guid id, string name, string address)
    {
        var query = @"
                UPDATE Organizations 
                SET Name = @Name, Address = @Address, UpdatedAt = NOW() 
                WHERE Id = @Id AND DeletedAt IS NULL;
            ";
        var parameters = new { Id = id, Name = name, Address = address };
        var rowsAffected = await _database.ExecuteAsync(query, parameters);
        return rowsAffected > 0;
    }
}
