using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace conti.maurizio._5H.SecondaWeb.Models
{
    public class DBContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        // Questo costruttore lavora in coppia con il metodo OnConfiguring...
        public DBContext(){ }
        
        // Quando viene chiamato il costruttore vuoto, viene chiamato anche questo metodo che
        // si preoccupa di passare a EF la stringa di connessione
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                     => options.UseSqlite("Data Source=database.db");

        public DBContext(DbContextOptions options): base(options)
        {
            _options = options; 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Articolo> Articoli { get ; set; }
    }
}