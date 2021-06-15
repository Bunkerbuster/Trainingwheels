using CommanderGQL.Model;
using Microsoft.EntityFrameworkCore;

namespace CommanderGQL.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Platform> Platforms { get; set; }


        public DbSet<Command> Commands { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder
                .Entity<Platform>()
                .HasMany(p => p.Commands)
                .WithOne(p => p.Platform)
                .HasForeignKey(p => p.PlatformId);

            modelbuilder
                .Entity<Command>()
                .HasOne(p => p.Platform)
                .WithMany(p => p.Commands)
                .HasForeignKey(p => p.PlatformId);


        }



    }
}
