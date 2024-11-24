using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MongoDB.Driver;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebApplication1.Models.Mongo;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductvarintMController : ControllerBase
    {
        private readonly IMongoCollection<ProductvarintM> _branchesCollection;

        public ProductvarintMController(IMongoDatabase database)
        {
            _branchesCollection = database.GetCollection<ProductvarintM>("ProductvarintM");
        }

        // 1. Get All Branches
        [HttpGet]
        public async Task<IActionResult> GetAllBranches()
        {
            var branches = await _branchesCollection.Find(_ => true).ToListAsync();
            return Ok(branches);
        }

        // 2. Get Branch by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBranchById(string id)
        {
            var branch = await _branchesCollection.Find(b => b.Id == id).FirstOrDefaultAsync();
            if (branch == null)
            {
                return NotFound("Branch not found.");
            }
            return Ok(branch);
        }

        // 3. Create a New Branch
        [HttpPost]
        public async Task<IActionResult> CreateBranch([FromBody] ProductvarintM branch)
        {
            if (branch == null)
            {
                return BadRequest("Branch data is required.");
            }
            branch.CreateDate = DateTime.UtcNow;
            branch.IsActive = true;
            branch.IsDeleted = false;

            await _branchesCollection.InsertOneAsync(branch);
            return CreatedAtAction(nameof(GetBranchById), new { id = branch.Id }, branch);
        }

        // 4. Update a Branch
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBranch(string id, [FromBody] ProductvarintM updatedBranch)
        {
            var branch = await _branchesCollection.Find(b => b.Id == id).FirstOrDefaultAsync();
            if (branch == null)
            {
                return NotFound("Branch not found.");
            }

            updatedBranch.Id = id; // تأكد من استخدام نفس الـ ID
            updatedBranch.UpdateDate = DateTime.UtcNow;

            await _branchesCollection.ReplaceOneAsync(b => b.Id == id, updatedBranch);
            return Ok("Branch updated successfully.");
        }

        // 5. Delete a Branch (Soft Delete)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(string id)
        {
            var branch = await _branchesCollection.Find(b => b.Id == id).FirstOrDefaultAsync();
            if (branch == null)
            {
                return NotFound("Branch not found.");
            }

            branch.IsDeleted = true; // تعيين الحذف الناعم
            branch.UpdateDate = DateTime.UtcNow;

            await _branchesCollection.ReplaceOneAsync(b => b.Id == id, branch);
            return Ok("Branch marked as deleted.");
        }
    }

}
