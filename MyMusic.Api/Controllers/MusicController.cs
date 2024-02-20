using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyMusic.Api.Resources;
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
        private readonly IMapper _mapper;
        public MusicController(IMusicService musicService, IMapper mapper)
{
  this._musicService = musicService;
    this._mapper = mapper;
}
        // GET: api/music
[HttpGet("")]
public async Task<ActionResult<IEnumerable<Music>>> GetAllMusics()
        {
            // TODO: Implement logic to retrieve music data
  var musics = await _musicService.GetAllWithArtist();
  var musicResources = _mapper.Map<IEnumerable<Music>, IEnumerable<MusicResource>>(musics);

  return Ok(musicResources);
        }

        // GET: api/music/{id}
[HttpGet("{id}")]
public async Task<ActionResult<MusicResource>> GetMusicById(int id)
{
    var music = await _musicService.GetMusicById(id);
    var musicResource = _mapper.Map<Music, MusicResource>(music);

    return Ok(musicResource);
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
