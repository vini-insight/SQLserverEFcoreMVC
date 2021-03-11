using Microsoft.EntityFrameworkCore;
using SQLserverEFcoreMVC.Models;

namespace SQLserverEFcoreMVC.Data
{
    public class Context : DbContext
    {
        // public DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=root;charset=utf8;");
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=dio;Trusted_Connection=True;");
        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        // https://entityframework.net/knowledge-base/20471927/how-to-fake-dbcontext-entry-method-in-entity-framework-with-repository-pattern

        // public void SetModified(object entity)
        // {
        //     Entry(entity).State = EntityState.Modified;
        // }
    }
}