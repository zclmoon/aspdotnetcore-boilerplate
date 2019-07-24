using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNetCoreBoilerplate.Domain.Note;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspDotNetCoreBoilerplate.Controllers
{
    [Route("api/v1/note")]
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("notes")]
        [ProducesResponseType(typeof(IEnumerable<Note>), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Get()
        {
            var result = await _noteService.GetNotes();

            return Ok(result);
        }

        [HttpPost("note")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] Note note)
        {
            await _noteService.CreateNote(note);

            return Ok();
        }

    }
}
