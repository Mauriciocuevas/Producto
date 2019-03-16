using System.Data.Entity;

namespace WebApplication2.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApplication2.Models.Producto> Productoes { get; set; }
    }
}