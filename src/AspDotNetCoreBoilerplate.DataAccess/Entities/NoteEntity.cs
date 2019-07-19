using Dapper.Contrib.Extensions;

namespace AspDotNetCoreBoilerplate.DataAccess.Entities
{
    [Table("note")]
    public class NoteEntity : EntityBase
    {
        public string Content { get; set; }
    }
}
