using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimerPrograma.Models;

namespace PrimerPrograma.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Poner aqui todos los modelos que se vayan creando
        public DbSet<Producto> Producto { get; set; }


    }
}
