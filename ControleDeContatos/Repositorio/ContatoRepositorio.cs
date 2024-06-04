using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }

        public ContatoModel BuscarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos(int usuarioId)
        {
            return _bancoContext.Contatos.Where(x => x.UsuarioId == usuarioId).ToList();
        }

        public ContatoModel CriarContato(ContatoModel contato)
        {
            // Gravar no banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel AtualizarContato(ContatoModel contato)
        {
            ContatoModel contatoDB = BuscarPorId(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato.");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;

        }

        public bool ApagarContato(int id)
        {
            ContatoModel contatoDB = BuscarPorId(id);

            if (contatoDB == null) throw new Exception("Houve um erro ao deletar o contato.");

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}