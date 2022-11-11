using Microsoft.Extensions.Configuration;

namespace Configuration
{
    public class Configuration
    {
        public const string StringConnectionSQLServer = "Data Source=@&ADDRESS&@;Initial Catalog=@&DATABASE&@;persist security info=True;user id=@&USER&@;password=@&PASSWORD&@;MultipleActiveResultSets=True;App=EntityFramework&quot;";

        public static IConfiguration ReadConfigurationAppConfig()
        {
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")) && Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").Equals("Development"))
            {
                var config = new ConfigurationBuilder()
                   .AddJsonFile(Function.File.ReturnPath("API", "AppConfig.json"), true)
                   //.AddJsonFile($"AppConfig.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true)
                   .Build();
                return config;
            }
            else
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile(Function.File.ReturnPath("API", "AppConfig.json"), true)
                    //.AddJsonFile($"AppConfig.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true)
                    .Build();
                return config;
            }
        }

        public static IConfiguration ReadConfigurationConnection()
        {
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")) && Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").Equals("Development"))
            {
                var config = new ConfigurationBuilder()
                   .AddJsonFile("Connection.json", true)
                   //.AddJsonFile($"Connection.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true)
                   .Build();
                return config;
            }
            else
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile("Connection.json", true)
                    //.AddJsonFile($"Connection.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true)
                    .Build();
                return config;
            }
        }

        public static string GetAddress()
        {
            return ReadConfigurationConnection()["ADDRESS"];
        }

        public static string GetDataBase()
        {
            return ReadConfigurationConnection()["DATABASE"];
        }

        public static string GetUser()
        {
            return ReadConfigurationConnection()["USER"];
        }

        public static string GetPassword()
        {
            return ReadConfigurationConnection()["PASSWORD"];
        }

        public static string GetStringConnectionSQLServer()
        {
            return StringConnectionSQLServer
                .Replace("@&ADDRESS&@", GetAddress())
                .Replace("@&DATABASE&@", GetDataBase())
                .Replace("@&USER&@", GetUser())
                .Replace("@&PASSWORD&@", GetPassword());
        }
    }
}