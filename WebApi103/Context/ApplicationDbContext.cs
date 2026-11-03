using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi103.Context
{
    public class ApplicationDbContext : DbContext
    {

      public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        } 

        // MODELOS A MAPEAR 

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Inserta en la tabla de Usuario

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                   PkUsuario = 1,
                   Nombre = "Majo Sosa",
                   UserName = "Majo",
                   Password = "Password1.",
                   FkRol =  1
                }
                
                );


            // Inserta en la tabla de roles 

            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    PkRol = 1,
                    Nombre = "sa",
                    Estatus = true

                },
                new Rol
                {
                    PkRol = 2,
                    Nombre = "admin", 
                    Estatus = false
                }

                
                
                
                );


            base.OnModelCreating(modelBuilder);
        }


    }
}
