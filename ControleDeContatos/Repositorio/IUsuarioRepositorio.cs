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
        UsuarioModel AlterarSenha (AlterarSenhaModel alterarSenhaModel);
        bool ApagarUsuario(int id);
    }
}
