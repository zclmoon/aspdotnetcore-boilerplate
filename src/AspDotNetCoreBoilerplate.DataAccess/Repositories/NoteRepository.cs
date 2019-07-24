using AspDotNetCoreBoilerplate.Configuration;
using AspDotNetCoreBoilerplate.DataAccess.Entities;
using Dapper;
using Dapper.Contrib;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetCoreBoilerplate.DataAccess.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly string _connString;

        public NoteRepository(IOptions<ConnectionStrings> options)
        {
            _connString = options.Value.ConnectionString;
        }

        public async Task<List<NoteEntity>> GetNotesAsync()
        {
            var sql = @"SELECT * FROM note LIMIT 0, 10;";


            using (var conn = new MySqlConnection(_connString))
            {
                var result = await conn.QueryAsync<NoteEntity>(sql);

                return result.ToList();
            }
        }

        public async Task<string> CreateNoteAsync(NoteEntity noteEntity)
        {
            using (var conn = new MySqlConnection(_connString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    // this is for building a long sql string in many private methods.
                    StringBuilder sql = new StringBuilder();

                    var param = new DynamicParameters();

                    sql.Append(CreateInsertNoteSql(noteEntity, param));

                    await conn.QueryFirstOrDefaultAsync<int>(sql.ToString(), param, transaction);


                    transaction.Commit();
                }
            }

            return noteEntity.Id;
        }

        private string CreateInsertNoteSql(NoteEntity noteEntity, DynamicParameters param)
        {
            var sql = @"
INSERT INTO `note`(
    `id`,`content`,
    `created_date_utc`,`created_by`,`updated_date_utc`,`updated_by`,`deleted_date_utc`,`deleted_by`)
VALUES (
    @id,
    @content,
    @createdDate,
    @createdBy,
    @updatedDate,
    @updatedBy,
    @deletedDate,
    @deletedBy);
";
            param.Add("id", noteEntity.Id);
            param.Add("content", noteEntity.Content);
            param.Add("createdDate", noteEntity.CreatedDateUtc);
            param.Add("createdBy", noteEntity.CreatedBy);
            param.Add("updatedDate", noteEntity.UpdatedDateUtc);
            param.Add("updatedBy", noteEntity.UpdatedBy);
            param.Add("deletedDate", noteEntity.DeletedDateUtc);
            param.Add("deletedBy", noteEntity.DeletedBy);

            return sql;
        }


    } // NoteRepository
}
