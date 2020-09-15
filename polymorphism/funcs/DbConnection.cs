using System;
using System.Collections.Generic;

namespace polymorphism.funcs
{
    public abstract class DbConnection
        {
           
            public string ConnectionString;
            public TimeSpan TimeOut = new TimeSpan(5000);
            //public TimeSpan Timeout;

             public DbConnection(string ConnectionString)
            {
                
                var available_conns = new List<string> {"SQL", "Oracle"};
                
                bool exists = available_conns.Contains(ConnectionString);

                System.Console.WriteLine(exists);

                if (string.IsNullOrEmpty(ConnectionString))
                {
                    throw new ArgumentException($"'{nameof(ConnectionString)}' cannot be null or empty", nameof(ConnectionString));
                }
                else if (exists)
                {
                    throw new ArgumentException($"'{nameof(ConnectionString)}' must be either SQL or Oracle", nameof(ConnectionString));

                }

                this.ConnectionString = ConnectionString;
            }

            public abstract void OpenConnection();

            public abstract void CloseConnection();
        }
}

