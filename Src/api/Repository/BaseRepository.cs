using Npgsql;

namespace Repository
{
    public abstract class BaseRepository
    {
        private readonly string _stringConnection;

        protected BaseRepository()
        {
            _stringConnection = "Server=tectopolis-db.postgres.database.azure.com;Database=posts;Port=5432;User Id=cristianorc@tectopolis-db;Password=sup@1097;;";
        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_stringConnection);
        }
    }
}