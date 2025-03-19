using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myPomodoro.Models;

namespace myPomodoro.Models
{
    public class PomodoroContext : DbContext
    {
        public PomodoroContext() { }  // 📌 Parametresiz constructor Eklendi!

        public PomodoroContext(DbContextOptions<PomodoroContext> options) : base(options) { }

        public DbSet<Sayac> Sayaclar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=myPomodoro;Trusted_Connection=True;");
            }
        }
    }
}
