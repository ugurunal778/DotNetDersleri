using System.Data.Entity;

namespace EntityFrameworkCodeFirstSample.Model
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=CodeFirstSampleDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SchoolContext>());
        }

        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
