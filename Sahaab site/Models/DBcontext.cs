using System.Data.Entity;

namespace Sahaab_site.Models
{
    public class DBcontext : DbContext
    {
        public DBcontext()
        {

        }
        public DbSet<Customer> Customers { get; set; } // My domain models
        public object Numbers { get; internal set; }
    }
}