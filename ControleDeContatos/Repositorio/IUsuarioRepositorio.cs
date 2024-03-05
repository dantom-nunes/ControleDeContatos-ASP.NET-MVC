using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorId(int id);
        UsuarioModel CriarUsuario(UsuarioModel usuario);
        UsuarioModel EditarUsuario(UsuarioModel usuario);
        bool ApagarUsuario(int id);
    }
}
