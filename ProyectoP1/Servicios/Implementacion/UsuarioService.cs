using Microsoft.EntityFrameworkCore;
using ProyectoP1.Models;
using ProyectoP1.Servicios.Contrato;

namespace ProyectoP1.Servicios.Implementacion
{
    

    public class UsuarioService : IUsuarioService
    {
        private readonly HotelAbcContext _dbContext;
        public UsuarioService(HotelAbcContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u =>u.Correo == correo && u.Clave==clave)
                .FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}
