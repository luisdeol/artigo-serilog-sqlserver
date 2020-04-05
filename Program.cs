using System.Collections.ObjectModel;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace ArtigoSerilogSql.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ArtigoSerilog");
            const string nomeTabela = "Logs";

            // Em "AdditionalColumns, adicione colunas extras que deseje, como IP, nome de usuário, id de trace da chamada, etc.
            var options = new ColumnOptions
                {
                    AdditionalColumns = new Collection<SqlColumn> {
                        new SqlColumn { ColumnName = "Action" }
                    }
                };
            
            Log.Logger = new LoggerConfiguration()
                .WriteTo.MSSqlServer(
                    connectionString: connectionString,
                    tableName: nomeTabela,
                    columnOptions: options,
                    appConfiguration: configuration
                )
                .CreateLogger();

            CreateWebHostBuilder(args).UseSerilog().Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
