using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBMGrpcService.Businesslayer.models
{
    public class OrganizationModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Conversion from gRPC Org message to this model
        //public static OrganizationModel FromGrpcMessage(Org org)
        //{
        //    return new OrganizationModel
        //    {
        //        Id = org.Id,
        //        Name = org.Name,
        //        Address = org.Address,
        //        CreatedAt = DateTime.Parse(org.CreatedAt),
        //        UpdatedAt = DateTime.Parse(org.UpdatedAt)
        //    };
        //}

        //// Conversion from this model to gRPC Org message
        //public Org ToGrpcMessage()
        //{
        //    return new Org
        //    {
        //        Id = this.Id,
        //        Name = this.Name,
        //        Address = this.Address,
        //        CreatedAt = this.CreatedAt.ToString("o"), // ISO 8601 format
        //        UpdatedAt = this.UpdatedAt.ToString("o")  // ISO 8601 format
        //    };
        //}
    }
}
