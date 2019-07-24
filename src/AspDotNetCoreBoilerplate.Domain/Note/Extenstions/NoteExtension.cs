using System;
using AspDotNetCoreBoilerplate.DataAccess.Entities;

namespace AspDotNetCoreBoilerplate.Domain.Note
{
    public static class NoteExtension
    {
        public static Note ToNote(this NoteEntity noteEntity)
        {
            if (noteEntity == null)
            {
                return null;
            }

            return new Note()
            {
                 Id = noteEntity.Id,
                 Content = noteEntity.Content
            };
        }

        public static NoteEntity ToNoteEntity(this Note note)
        {
            return new NoteEntity()
            {
                Content = note.Content,
                CreatedBy = "1",
                CreatedDateUtc = DateTime.UtcNow,
                DeletedBy = null,
                DeletedDateUtc = null,
                UpdatedBy = null,
                UpdatedDateUtc = null
            };
        }
    }
}
