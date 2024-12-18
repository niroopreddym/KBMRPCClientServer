using Grpc.Core;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using KBMGrpcService.Grpc.User;

namespace KBMGrpcService.Services;

public class UserServiceImpl : UserService.UserServiceBase
{
    public override Task<CreateUserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
    {

        var response = new CreateUserResponse
        {
            UserId = "new-user-id" 
        };

        return Task.FromResult(response);
    }

    public override Task<GetUserByIdResponse> GetUserById(GetUserByIdRequest request, ServerCallContext context)
    {
        var response = new GetUserByIdResponse
        {
            Name = "John Doe",
            Email = "johndoe@example.com",
            CreatedAt = "2024-12-18T00:00:00Z",
            UpdatedAt = "2024-12-18T00:00:00Z"
        };

        return Task.FromResult(response);
    }

    public override Task<QueryUsersResponse> QueryUsers(QueryUsersRequest request, ServerCallContext context)
    {
        var response = new QueryUsersResponse
        {
            Page = request.Page,
            PageSize = request.PageSize,
            Users = {
                new User { Name = "John Doe", Email = "johndoe@example.com" },
                new User { Name = "Jane Smith", Email = "janesmith@example.com" }
            }
        };

        return Task.FromResult(response);
    }

    public override Task<Empty> UpdateUser(UpdateUserRequest request, ServerCallContext context)
    {
        return Task.FromResult(new Empty());
    }

    public override Task<Empty> DeleteUser(DeleteUserRequest request, ServerCallContext context)
    {
        return Task.FromResult(new Empty());
    }

    public override Task<Empty> AssociateUserToOrganization(AssociateUserToOrganizationRequest request, ServerCallContext context)
    {
        return Task.FromResult(new Empty());
    }

    public override Task<Empty> DisassociateUserFromOrganization(DisassociateUserFromOrganizationRequest request, ServerCallContext context)
    {
        return Task.FromResult(new Empty());
    }

    public override Task<QueryUsersForOrganizationResponse> QueryUsersForOrganization(QueryUsersForOrganizationRequest request, ServerCallContext context)
    {
        var response = new QueryUsersForOrganizationResponse
        {
            Page = request.Page,
            PageSize = request.PageSize,
            Total = 50,
            Users = {
                new User { Name = "John Doe", Email = "johndoe@example.com" },
                new User { Name = "Alice Johnson", Email = "alicejohnson@example.com" }
            }
        };

        return Task.FromResult(response);
    }
}
