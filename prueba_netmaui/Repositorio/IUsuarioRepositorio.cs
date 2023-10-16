using prueba_netmaui.Model;

namespace prueba_netmaui.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> Login(string correo, string contraseña);
    }
}
