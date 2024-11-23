using MongoDB.Driver;

namespace WebApplication1.Models.Mongo
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        // Constructor to initialize the database connection
        public MongoDbContext()
        {
            var client = new MongoClient("mongodb+srv://ahmedrafie6:Db9Ny2GleVx46Udn@cluster0.7rdgs.mongodb.net/");
            _database = client.GetDatabase("VRoot"); // Replace "VRoot" with your database name
        }
        public IMongoCollection<BranchM> Branches => _database.GetCollection<BranchM>("Branches");
        public IMongoCollection<EmployeeM> Employees => _database.GetCollection<EmployeeM>("Employees");
    }
}
