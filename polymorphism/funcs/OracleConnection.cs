namespace polymorphism.funcs
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString)
            : base(ConnectionString)
        {
            
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Openning Oracle Connection");
        }


        public override void OpenConnection()
        {
            System.Console.WriteLine("Closing Connection");
        }

    }
}