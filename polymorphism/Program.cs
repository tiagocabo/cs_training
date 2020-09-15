using System;
using polymorphism.funcs;


namespace polymorphism
{
    abstract class Program
    {
        
        static void Main(string[] args)
        {
            var con = new SqlConnection("Oracle");

            con.OpenConnection();
            con.CloseConnection();

            var ops = new DbCommand(con);

            ops.Execute("SELECT * FROM table");
        }
    }
}
