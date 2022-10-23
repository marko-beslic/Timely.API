using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Timely.API.DataModels
{
    public class TimelyContext : DbContext
    {
        public TimelyContext(DbContextOptions<TimelyContext> options): base(options)
        {
        }

        public DbSet<WorkSession> WorkSession { get; set; }
    }
}
