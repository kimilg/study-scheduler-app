using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Work> Works { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleWork> ScheduleWorks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<ScheduleWork>(x => x.HasKey(aa => new {aa.ScheduleId, aa.WorkId}));

            builder.Entity<ScheduleWork>()
                .HasOne(u => u.Schedule)
                .WithMany(v => v.Works)
                .HasForeignKey(k => k.ScheduleId);
            
            builder.Entity<ScheduleWork>()
                .HasOne(u => u.Work)
                .WithMany(v => v.Schedules)
                .HasForeignKey(k => k.WorkId);
        }
    }
}