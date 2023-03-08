using ECommerce_MW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MW.DAL
{
    public class DatabaseContex : DbContext
    {
        public DatabaseContex(DbContextOptions<DatabaseContex> options) : base(options) //paramaetros que recibe el constructor, ya esta predefinido
                                                                                        // permite generar conexio a la BD por medio de DBContexOption
        {

        }

        public DbSet<Country> Countries { get; set; }
    }
}
