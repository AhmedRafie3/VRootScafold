using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApplication1.Models.Mongo
{
    public class EmployeeShiftM
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!; // MongoDB document ID
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Status { get; set; }
        public string? EmployeeId { get; set; } // Reference Employee as ID
        public string? BranchId { get; set; } // Reference Branch as ID
        public int Flag { get; set; }
        public List<string>? TransactionflowIds { get; set; } // Reference Transactionflows as IDs
    }
}
