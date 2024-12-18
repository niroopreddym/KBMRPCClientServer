
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Net.Client;
    using KBMGrpcService.Grpc.User;
    using System;
    using System.Threading.Tasks;
    namespace KBMGrpcService.UserServiceClient;
    public class UserServiceClient
    {
        private readonly UserService.UserServiceClient _userServiceClient;

        public UserServiceClient(string serverUrl)
        {
            var channel = GrpcChannel.ForAddress(serverUrl);  // Server URL (e.g., "https://localhost:5001")
            _userServiceClient = new UserService.UserServiceClient(channel);
        }

        // Method to create a user
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            try
            {
                var response = await _userServiceClient.CreateUserAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Method to get a user by ID
        public async Task<GetUserByIdResponse> GetUserByIdAsync(GetUserByIdRequest request)
        {
            try
            {
                var response = await _userServiceClient.GetUserByIdAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Method to update a user
        public async Task<Empty> UpdateUserAsync(UpdateUserRequest request)
        {
            try
            {
                var response = await _userServiceClient.UpdateUserAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Method to delete a user
        public async Task<Empty> DeleteUserAsync(DeleteUserRequest request)
        {
            try
            {
                var response = await _userServiceClient.DeleteUserAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Method to associate a user with an organization
        public async Task<Empty> AssociateUserToOrganizationAsync(AssociateUserToOrganizationRequest request)
        {
            try
            {
                var response = await _userServiceClient.AssociateUserToOrganizationAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Method to disassociate a user from an organization
        public async Task<Empty> DisassociateUserFromOrganizationAsync(DisassociateUserFromOrganizationRequest request)
        {
            try
            {
                var response = await _userServiceClient.DisassociateUserFromOrganizationAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Method to query users for an organization
        public async Task<QueryUsersForOrganizationResponse> QueryUsersForOrganizationAsync(QueryUsersForOrganizationRequest request)
        {
            try
            {
                var response = await _userServiceClient.QueryUsersForOrganizationAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
