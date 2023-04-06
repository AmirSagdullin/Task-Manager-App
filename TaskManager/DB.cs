using Npgsql;

namespace Task_Manager
{
    internal class DB
    {
        static public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=123;Database=TaskManager;");
        }
    }
}
