using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcWebIdentity.Entities;

namespace MvcWebIdentity.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    AlunoId = 1,
                    Nome = "Nilton",
                    Email = "hajikazuo@outlook.com",
                    Idade = 24,
                    Curso = "Programação"
                });
        }
    }
}
