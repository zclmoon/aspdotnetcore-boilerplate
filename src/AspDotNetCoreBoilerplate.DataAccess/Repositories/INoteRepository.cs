using AspDotNetCoreBoilerplate.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspDotNetCoreBoilerplate.DataAccess.Repositories
{
    public interface INoteRepository
    {
        Task<List<NoteEntity>> GetNotesAsync();

        Task<string> CreateNoteAsync(NoteEntity noteEntity);
    }
}
