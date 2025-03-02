using Microsoft.EntityFrameworkCore;
using Tarea_Práctica_2_.Models;

namespace Tarea_Práctica_2_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)
        {

        }

        public DbSet<MCategoria> tbl_Categoria { get; set; }
        public DbSet<MConsola> tbl_Consola { get; set; }
        public DbSet<MProducto> tbl_Producto { get; set; }
    }
}
