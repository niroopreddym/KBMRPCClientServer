using KBMGrpcService.Businesslayer.models;

namespace KBMGrpcService.Businesslayer.Interfaces;

public interface IOrganizationService
{
    Task<OrganizationModel> CreateOrganizationAsync(string name, string address);
    Task<OrganizationModel?> GetOrganizationByIdAsync(Guid id);
    Task<IEnumerable<OrganizationModel>> QueryOrganizationsAsync(
        int page,
        int pageSize,
        string orderBy,
        string direction,
        string queryString
    );
    Task<bool> UpdateOrganizationAsync(Guid id, string name, string address);
    Task<bool> DeleteOrganizationAsync(Guid id);
}
