﻿using System;
using System.Linq;
using System.Reflection;
using DbUp;
using Npgsql;

namespace MyDocs.Infrastructure.Db.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString =
                args.FirstOrDefault()
                ?? "Server=mydocs.database;Port=5432;Database=mydocs;User Id=mydocs;Password=h2E@93%5b!fVX*e=;";

            WaitUntilDbIsReady(connectionString);
            
            var upgrader =
                DeployChanges.To
                    .PostgresqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
        }

        private static void WaitUntilDbIsReady(string connectionString)
        {
            var isDbStarting = true;
            while (isDbStarting)
            {
                try
                {
                    using var conn = new NpgsqlConnection(connectionString);
                    conn.Open();

                    Console.WriteLine("Db ready apply migrations");

                    isDbStarting = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Db is not ready yet, waiting... :S");
                }
            }
        }
    }
}
