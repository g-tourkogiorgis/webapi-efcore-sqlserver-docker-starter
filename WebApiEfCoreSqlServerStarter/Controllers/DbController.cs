using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApiEfCoreSqlServerStarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DbController : ControllerBase
    {
        private readonly Context _context;

        public DbController(Context context)
        {
            _context = context;
        }

        // Test GET method.
        [HttpGet]
        public async Task<IEnumerable<Entity>> GetAllDbEntries()
        {
            return await _context.Entities.Take(1000).ToListAsync();
        }

        // Test POST method.
        [HttpPost]
        public async Task AddEntryToDb()
        {
            _context.Entities.Add(new Entity() { Id = Guid.NewGuid(), Value = new Random().Next().ToString() });
            await _context.SaveChangesAsync();
        }
    }
}