using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyLineBot.Data;
using MyLineBot.Data.common;
using System.IO;

namespace MyLineBot.Common
{
    public class DatabaseManager
    {
        public static IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        public CommonDataContext Common()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CommonDataContext>();
            optionsBuilder.UseSqlServer(string.Format(Configuration.GetConnectionString("CommonDataContext")));
            return new CommonDataContext(optionsBuilder.Options);
        }
        public DataContext Prototype(string dataName)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer(string.Format(Configuration.GetConnectionString("DataContext"), dataName));
            return new DataContext(optionsBuilder.Options);
        }
    }
}
