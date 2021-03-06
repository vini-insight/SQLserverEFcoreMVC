using Microsoft.EntityFrameworkCore;
using SQLserverEFcoreMVC.Models;

namespace SQLserverEFcoreMVC.Data
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=root;charset=utf8;");
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=dio;Trusted_Connection=True;");
        }
    }
}