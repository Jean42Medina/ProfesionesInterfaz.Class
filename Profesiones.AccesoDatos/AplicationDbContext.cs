using Microsoft.EntityFrameworkCore;
using Profesiones.Entidad;

namespace Profesiones.AccesoDatos
{
    public class AplicationDbContext : DbContext 
    {
        public DbSet<Carpintero> Carpinteros { get; set; }
    }
}
