using LionServer.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LionServer.Infra.Data.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LionContext>
    {
        //ApplicationDbContext 代表的是你的创建失败的那个类型
        public LionContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LionContext>();
            optionsBuilder.UseSqlServer("server=DESKTOP-9AV5NTE;uid=sa;pwd=000000;database=LionDataDB");

            return new LionContext(optionsBuilder.Options);
        }
    }

    public class DesignTimeDbContextFactory2 : IDesignTimeDbContextFactory<EventStoreSQLContext>
    {
        //ApplicationDbContext 代表的是你的创建失败的那个类型
        public EventStoreSQLContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EventStoreSQLContext>();
            optionsBuilder.UseSqlServer("server=DESKTOP-9AV5NTE;uid=sa;pwd=000000;database=LionDataDB");

            return new EventStoreSQLContext(optionsBuilder.Options);
        }
    }
}
