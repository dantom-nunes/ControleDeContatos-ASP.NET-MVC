using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos(int usuarioId);
        ContatoModel BuscarPorId(int id);
        ContatoModel CriarContato (ContatoModel contato);
        ContatoModel AtualizarContato(ContatoModel contato);
        bool ApagarContato(int id);
    }
}
