using System.Data.Entity;

namespace JqueryAjaxCRUD.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("SchoolConnectionString")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}