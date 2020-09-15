namespace polymorphism.funcs
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string ConnectionString)
            : base(ConnectionString)
        {
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Openning SQL connection");
        }
       
        public override void OpenConnection()
        {
            System.Console.WriteLine(" Closing SQL Connection");
        }

    }
}