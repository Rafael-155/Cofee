using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cofee.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options){     
        }
    public DbSet<Cofee.Models.Contacto> DataContacto {get; set; }
    
    public DbSet<Cofee.Models.Producto> DataProducto {get; set; }
}
