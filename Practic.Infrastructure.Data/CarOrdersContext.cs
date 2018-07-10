using Practic.Models;
using System.Data.Entity;


namespace Practic.Infrastructure.Data
{
    public class CarOrdersContext : DbContext
    {
        public DbSet<Add> Adds { get; set; }
        public DbSet<Weigh> Weighs { get; set; }
        public DbSet<Determine> Determines { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteType> RouteTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Measure> Measures { get; set; }
    }
    public class CarOrdersDbInitializer : DropCreateDatabaseIfModelChanges<CarOrdersContext>
    {
        protected override void Seed(CarOrdersContext db)
        {
            db.RouteTypes.Add(new RouteType { Name = "Усть-Каменогорск" });
            db.SaveChanges();
        }
    }
}
