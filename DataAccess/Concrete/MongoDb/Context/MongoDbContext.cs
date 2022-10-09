using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.MongoDb.Context
{
    public class MongoDbContext : MongoDbContextBase
    {
        public MongoDbContext(IConfiguration configuration)
            : base(configuration)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        base.OnConfiguring(optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DArchMsContext")));
        //    }
        //}




    }
}