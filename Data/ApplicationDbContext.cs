using Microsoft.EntityFrameworkCore;
using EvaluationDeC_.Models;

namespace EvaluationDeC_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Absence> Absences { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Cours> Cours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=EvaluationC#2025;Username=postgres;Password=sfall");
            }
        }
    }
}