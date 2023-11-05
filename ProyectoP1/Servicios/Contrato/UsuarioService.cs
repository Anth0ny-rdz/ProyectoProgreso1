using Microsoft.EntityFrameworkCore;
using ProyectoP1.Models;

namespace ProyectoP1.Servicios.Contrato
{
    public interface IUsuarioService
    {

        Task<Usuario> GetUsuario(string correo, string clave);

        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
