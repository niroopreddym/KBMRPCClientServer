using KBMGrpcService.Grpc.Organization;
namespace Models;

public class OrganizationModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public static OrganizationModel FromGRPCMessage(Org org)
    {
        return new OrganizationModel
        {
            Id = org.Id,
            Name = org.Name,
            Address = org.Address,
            CreatedAt = DateTime.Parse(org.CreatedAt),
            UpdatedAt = DateTime.Parse(org.UpdatedAt)
        };
    }

    public Org ToGRPCMessage()
    {
        return new Org
        {
            Id = this.Id,
            Name = this.Name,
            Address = this.Address,
            CreatedAt = this.CreatedAt.ToString("o"), 
            UpdatedAt = this.UpdatedAt.ToString("o") 
        };
    }
}
