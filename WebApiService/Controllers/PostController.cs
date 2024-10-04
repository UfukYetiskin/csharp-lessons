using Microsoft.AspNetCore.Mvc;
using WebApiService.Data;
using WebApiService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiService.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase{
        private readonly AppDbContext _context;

        public PostController(AppDbContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts(){
            return await _context.Posts.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Post>> CreatePost(Post post){
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPosts), new {id = post.PostId}, post);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPostById(int id){
            var post = await _context.Posts.FindAsync(id);
            if(post == null){
                return NotFound();
            }
            return post;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Post>> UpdatePost(int id, Post post){
            if(id != post.PostId){
                return BadRequest();
            }
            _context.Entry(post).State = EntityState.Modified;
            try{
                await _context.SaveChangesAsync();
            }catch(DbUpdateConcurrencyException){
                if(!PostExists(id)){
                    return NotFound();
                }else{
                    throw;
                }

            }
            return NoContent();
        }
        private bool PostExists(int id){
            return _context.Posts.Any(e => e.PostId == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id){
            var post = await _context.Posts.FindAsync(id);
            if(post == null) return NotFound();

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}