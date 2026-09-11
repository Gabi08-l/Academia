using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Academia.Mvc.Models;

namespace Academia.Mvc.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Profissional> Profissionals { get; set; }
    public DbSet<Plano> Planos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<AvaliacaoFisica> AvaliacoesFisicas { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<Inscricao> Inscricoes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
}