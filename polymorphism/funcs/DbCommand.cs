using System;

namespace polymorphism.funcs
{
    public class DbCommand
    {
        private DbConnection _conn;
        public DbCommand(DbConnection conn)
        {
            this._conn = conn;
        }

        public void Execute(string instruction)
        {
            _conn.OpenConnection();

            System.Console.WriteLine("connected to " + _conn.ConnectionString);
            System.Console.WriteLine(instruction);

            _conn.CloseConnection();

        }
    }
}