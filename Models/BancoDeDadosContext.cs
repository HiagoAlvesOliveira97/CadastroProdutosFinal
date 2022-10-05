using Microsoft.EntityFrameworkCore;

namespace CadastroProdutosFinal.Models
{
    public class BancoDeDadosContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CM8F2OC\SQLEXPRESS;Database=DW_CRUD_FINAL;Integrated Security=True");
        }
    }
}
