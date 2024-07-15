using Microsoft.AspNetCore.Mvc;
using WebApplication1.data;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Organisations : Controller
    {
        public readonly SabelDbContext _context;

        public Organisations(SabelDbContext context ) 
        {
            _context = context;
        
        }
        public String Index()
        {
            return "Wellllcooome..................";
        }

        public async Task<ActionResult<Organisation>> Details (Guid Id)
        {
            var data  = await _context.Organisations.FindAsync( Id );
            if (data == null)
            {
                return NotFound($"Organusation with Id {Id} not found.");            
            }

            return data;
        }

        public async Task<ActionResult<IEnumerable<Organisation>>> BySystem()
        {
            IEnumerable<Organisation> organisations = await _context.Organisations
                                                        .Where(o => o.CreatedBy == "System")
                                                        .OrderByDescending(o => o.CreatedDate)
                                                        .ToListAsync();
            return Ok(organisations);
        }
    }
}
