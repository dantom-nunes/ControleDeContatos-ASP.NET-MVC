using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorEmailELogin(string email, string login);
        UsuarioModel BuscarPorLogin(string login);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorId(int id);
        UsuarioModel CriarUsuario(UsuarioModel usuario);
        UsuarioModel EditarUsuario(UsuarioModel usuario);
        bool ApagarUsuario(int id);
    }
}
