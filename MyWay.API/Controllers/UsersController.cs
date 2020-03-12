using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay.API.Data;

namespace MyWay.API.Controllers
{
    //POST http://localhost:5000/api/users/1
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] 
        public async Task<ActionResult> GetUsers()
        {
            var values = await _context.Users.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task <ActionResult> GetUser(int id)
        {
            var value = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }
    }
}