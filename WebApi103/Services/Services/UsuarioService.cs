
using Domain.Entities;
using Domain.Helpers;
using Microsoft.EntityFrameworkCore;
using WebApi103.Context;
using WebApi103.Services.Interfaces;

namespace WebApi103.Services.Services
{

    // Todo la funcionalidades para la BD
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _context;
        public UsuarioService(ApplicationDbContext context) 
        { 
            _context = context;
        
        }

        //Lista de Usuario

        public async Task<Response<List<Usuario>>> ObtenerUsuario()
        {
            try
            {
                List<Usuario> response = await _context.Usuarios.ToListAsync();

                return new Response<List<Usuario>>(response);

            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error" + ex.Message);
            }
        }


        public async Task<Response<Usuario>> ById(int id)
        {
            try
            {
                Usuario result = await _context.Usuarios.FirstOrDefaultAsync(x => x.PkUsuario == id);
                
                return new Response<Usuario>(result);
            
            }
            catch (Exception ex)
            {

                throw new Exception($"No se encontro: {ex.Message}");
            }

        }


        public async Task<Response<Usuario>> Create(Usuario request)
        {
            try
            {
                Usuario newUsers =  new Usuario()
                {
                    Nombre = request.Nombre,
                    UserName = request.UserName,
                    Password = request.Password,
                    FkRol = request.FkRol
                    
                };

                 var result = await _context.Usuarios.AddAsync(newUsers);
                               _context.SaveChanges();

                return new Response<Usuario>(newUsers, "Se creo correctamente :D");
              
            }
            catch (Exception ex)
            {
                throw new Exception ("Succedio un error: " +ex.Message);
            }
        }
        






    }
}
