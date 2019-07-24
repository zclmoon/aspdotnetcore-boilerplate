using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspDotNetCoreBoilerplate.Domain.Note
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetNotes();

        Task CreateNote(Note note);
    }
}
