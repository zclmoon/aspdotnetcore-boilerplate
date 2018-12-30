using Dapper.Contrib.Extensions;

namespace AspDotNetCoreBoilerplate.DataAccess.Entities
{
    [Table("user_info")]
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
