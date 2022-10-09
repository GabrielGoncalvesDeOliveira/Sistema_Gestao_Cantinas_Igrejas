using Microsoft.EntityFrameworkCore;

namespace SistemaGestaoCantinasIgrejas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
