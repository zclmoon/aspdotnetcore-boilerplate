using Dapper.Contrib.Extensions;
using System;

namespace AspDotNetCoreBoilerplate.DataAccess.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        public DateTime CreatedDateUtc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DeletedDateUtc { get; set; }
        public string DeletedBy { get; set; }
    }
}
