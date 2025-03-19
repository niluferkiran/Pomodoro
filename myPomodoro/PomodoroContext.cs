using System;
using Microsoft.EntityFrameworkCore;

namespace myPomodoro
{
    public class PomodoroContext : DbContext
    {
        public PomodoroContext(DbContextOptions<PomodoroContext> options) : base(options) { }

        public DbSet<Sayac> Sayaclar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=PomodoroDB;Trusted_Connection=True;");
            }
        }
    }
}
