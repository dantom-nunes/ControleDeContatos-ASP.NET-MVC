using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel CriarContato (ContatoModel contato);
        ContatoModel AtualizarContato(ContatoModel contato);
        bool ApagarContato(int id);
    }
}
