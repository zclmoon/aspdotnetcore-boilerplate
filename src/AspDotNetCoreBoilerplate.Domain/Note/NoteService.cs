using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspDotNetCoreBoilerplate.DataAccess.Repositories;

namespace AspDotNetCoreBoilerplate.Domain.Note
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task CreateNote(Note note)
        {
            var noteEntity = note.ToNoteEntity();

            await _noteRepository.CreateNoteAsync(noteEntity);
        }

        public async Task<IEnumerable<Note>> GetNotes()
        {
            var noteEntities = await _noteRepository.GetNotesAsync();

            return noteEntities.Select(x=>x.ToNote()).ToList();
        }
    }
}
