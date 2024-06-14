using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Cofee.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options){     
        }
    public DbSet<Cofee.Models.Contacto> DataContacto {get; set; }

    public DbSet<Cofee.Models.Producto> DataProducto {get; set; }
    public DbSet<Cofee.Models.Proforma> DataItemCarrito {get; set; }
}
