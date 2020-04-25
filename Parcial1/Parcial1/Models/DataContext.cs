

namespace Parcial1.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Parcial1.Models.Romero> Romeroes { get; set; }
    }
}