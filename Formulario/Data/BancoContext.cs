using Formulario.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Formulario.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<Models.ContatoModel> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ContatoModel>()
                .Property(c => c.Preco)
                .HasColumnType("decimal(10, 2)"); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
