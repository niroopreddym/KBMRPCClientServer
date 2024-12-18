using KBMGrpcService.Grpc.Organization;
using KBMGrpcService.OrganizationServiceClient;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new OrgServiceClient("https://localhost:5001");  // Adjust the URL to match your server

        // Example: Create a new Org
        var createOrgRequest = new CreateOrgRequest
        {
            Name = "Tech Company",
            Address = "123 Tech Lane"
        };

        var createOrgResponse = await client.CreateOrgAsync(createOrgRequest);
        Console.WriteLine($"Created Org ID: {createOrgResponse.OrganizationId}");
    }
}
