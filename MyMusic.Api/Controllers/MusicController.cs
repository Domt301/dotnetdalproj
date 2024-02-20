using Microsoft.AspNetCore.Mvc;
using MyMusic.Core.Models;
using MyMusic.Core.Services;
using System.Collections.Generic;

namespace MyMusic.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {
        private readonly IMusicService _musicService;
        public MusicController(IMusicService musicService)
{
  this._musicService = musicService;
}
        // GET: api/music
[HttpGet("")]
public async Task<ActionResult<IEnumerable<Music>>> GetAllMusics()
        {
            // TODO: Implement logic to retrieve music data
            var musics = await _musicService.GetAllWithArtist();
            return Ok(musics);
        }

        // GET: api/music/{id}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            // TODO: Implement logic to retrieve a specific song by ID
            return "Song " + id;
        }

        // POST: api/music
        [HttpPost]
        public IActionResult Post([FromBody] string song)
        {
            // TODO: Implement logic to add a new song
            return CreatedAtAction(nameof(Get), new { id = 4 }, song);
        }

        // PUT: api/music/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string song)
        {
            // TODO: Implement logic to update a specific song by ID
            return NoContent();
        }

        // DELETE: api/music/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO: Implement logic to delete a specific song by ID
            return NoContent();
        }
    }
}
