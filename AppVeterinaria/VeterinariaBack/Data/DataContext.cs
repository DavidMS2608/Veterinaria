using Microsoft.EntityFrameworkCore;
using VeterinariaModel.Entities;

namespace InventarioBack.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Medico> Medicos { get; set; }
}
