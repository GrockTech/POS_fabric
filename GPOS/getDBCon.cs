using System;
using System.Data.SqlClient;

class Program
{
   public static void GetDB()
    
    {
        // Create an instance of SqlConnectionStringBuilder
        var builder = new SqlConnectionStringBuilder();

        // Set properties individually
        builder.DataSource = @"(localdb)\MSSQLLocalDB";
        builder.InitialCatalog = "YourDatabaseName";
        builder.IntegratedSecurity = true; // Windows authentication

        // Optionally, enable encryption
        builder.Encrypt = true;
        builder.TrustServerCertificate = true; // Insecure - use only for testing or trusted environments

        // Construct the connection string
        string connectionString = builder.ConnectionString;

        // Use the connection string to create a SqlConnection
       
    }
}
