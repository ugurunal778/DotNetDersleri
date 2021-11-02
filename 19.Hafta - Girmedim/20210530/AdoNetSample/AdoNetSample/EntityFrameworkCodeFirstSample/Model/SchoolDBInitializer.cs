using System.Data.Entity;

namespace EntityFrameworkCodeFirstSample.Model
{
    public class SchoolDBInitializer : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            base.Seed(context);
        }
    }
}
