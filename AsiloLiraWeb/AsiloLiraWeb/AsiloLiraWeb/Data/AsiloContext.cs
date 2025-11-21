using Microsoft.EntityFrameworkCore;
using AsiloLiraWeb.Models;

namespace AsiloLiraWeb.Data
{
    public class AsiloContext : DbContext
    {
        public AsiloContext(DbContextOptions<AsiloContext> options)
            : base(options)
        {
        }

        public DbSet<Voluntario> Voluntarios { get; set; }
    }
}
