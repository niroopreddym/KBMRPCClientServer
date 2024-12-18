
using Grpc.Net.Client;
using KBMGrpcService.Grpc.Organization;
namespace KBMGrpcService.OrganizationServiceClient;
public class OrgServiceClient
{
    private readonly OrgService.OrgServiceClient _OrgServiceClient;

    public OrgServiceClient(string serverUrl)
    {
        var channel = GrpcChannel.ForAddress(serverUrl);  // Server URL (e.g., "https://localhost:5001")
        _OrgServiceClient = new OrgService.OrgServiceClient(channel);
    }

    // Method to create an Org
    public async Task<CreateOrgResponse> CreateOrgAsync(CreateOrgRequest request)
    {
        try
        {
            var response = await _OrgServiceClient.CreateOrgAsync(request);
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    // Method to get an Org by ID
    public async Task<GetOrgByIdResponse> GetOrgByIdAsync(GetOrgByIdRequest request)
    {
        try
        {
            var response = await _OrgServiceClient.GetOrgByIdAsync(request);
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    // Method to query Orgs
    public async Task<QueryOrgsResponse> QueryOrgsAsync(QueryOrgsRequest request)
    {
        try
        {
            var response = await _OrgServiceClient.QueryOrgsAsync(request);
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    // Method to update an Org
    public async Task<Google.Protobuf.WellKnownTypes.Empty> UpdateOrgAsync(UpdateOrgRequest request)
    {
        try
        {
            var response = await _OrgServiceClient.UpdateOrgAsync(request);
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    // Method to delete an Org
    public async Task<Google.Protobuf.WellKnownTypes.Empty> DeleteOrgAsync(DeleteOrgRequest request)
    {
        try
        {
            var response = await _OrgServiceClient.DeleteOrgAsync(request);
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }
}
