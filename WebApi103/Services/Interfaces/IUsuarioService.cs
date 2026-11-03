using Domain.Entities;
using Domain.Helpers;

namespace WebApi103.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<Response<List<Usuario>>> ObtenerUsuario();

        public Task<Response<Usuario>> ById(int id);

        public Task<Response<Usuario>> Create(Usuario request);
    }
}
