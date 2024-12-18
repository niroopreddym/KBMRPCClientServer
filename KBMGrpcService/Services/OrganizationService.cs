using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using KBMGrpcService.Grpc.Organization;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace KBMGrpcService.Services;
public class OrgServiceImpl : OrgService.OrgServiceBase
{
    public override Task<CreateOrgResponse> CreateOrg(CreateOrgRequest request, ServerCallContext context)
    {

        var response = new CreateOrgResponse
        {
            OrganizationId = "new-org-id"
        };

        return Task.FromResult(response);
    }

    public override Task<GetOrgByIdResponse> GetOrgById(GetOrgByIdRequest request, ServerCallContext context)
    {

        var response = new GetOrgByIdResponse
        {
            Name = "Example Org", 
            Address = "123 Example St",
            CreatedAt = "2024-12-18T00:00:00Z",
            UpdatedAt = "2024-12-18T00:00:00Z"
        };

        return Task.FromResult(response);
    }

    public override Task<QueryOrgsResponse> QueryOrgs(QueryOrgsRequest request, ServerCallContext context)
    {
        var response = new QueryOrgsResponse
        {
            Page = request.Page,
            PageSize = request.PageSize,
            Total = 100, 
            Organizations = {
                new Org { Name = "Example Org 1", Address = "123 Example St" },
                new Org { Name = "Example Org 2", Address = "456 Another St" }
            }
        };

        return Task.FromResult(response);
    }

    // Override the UpdateOrg method
    public override Task<Empty> UpdateOrg(UpdateOrgRequest request, ServerCallContext context)
    {
        return Task.FromResult(new Empty());
    }

    public override Task<Empty> DeleteOrg(DeleteOrgRequest request, ServerCallContext context)
    {
        return Task.FromResult(new Empty());
    }
}
