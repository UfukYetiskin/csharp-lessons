using Microsoft.AspNetCore.Mvc;
using WebApiService.Data;
using WebApiService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebApiService.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase{
        private readonly AppDbContext _context;

        public UserController(AppDbContext context){
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(){
            return await _context.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user){
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsers), new {id = user.UserId}, user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id){
            var user = await _context.Users.FindAsync(id);
            if(user == null) return NotFound();
            return user;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> PutUserById(int id, User user){
            if(id != user.UserId) return BadRequest();

            _context.Entry(user).State = EntityState.Modified;

            try{
                await _context.SaveChangesAsync();
            }catch(DbUpdateConcurrencyException){
                if(!UserExists(id)){
                    return NotFound();
                }else{
                    throw;
                }
            }
            return user;
        }

        private bool UserExists(int id){
            return _context.Users.Any(e => e.UserId == id);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id){
            var user =  await _context.Users.FindAsync(id);

            if(user == null) return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            

            return NoContent();
        }

    }
}
