using Microsoft.EntityFrameworkCore;
using Nutricional.Models;

namespace Nutricional.Data
{
    public class AlimentoContext : DbContext
    {
        public AlimentoContext(DbContextOptions<AlimentoContext> opts) :base(opts)
        {

        }

        public DbSet<Alimento> Alimentos { get; set; }
    }
}
