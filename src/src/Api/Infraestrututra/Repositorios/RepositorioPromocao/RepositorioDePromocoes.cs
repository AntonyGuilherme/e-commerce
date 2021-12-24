using Api.Dominio;
using Api.Infraestrututra.Repositorios.RepositorioPromocao;
using System.Collections.Generic;

namespace Api.Infraestrututra.Repositorios
{
    public class RepositorioDePromocoes : IRepositorioDePromocao
    {
        private readonly static List<Promocao> _promocoes = new List<Promocao>()
        {
            new Promocao(1,2),
            new PromocaoPorValor(2,3,10)
        };

        public Promocao Buscar(int Id)
        {
           return _promocoes.Find((promocao) => promocao.Id == Id);
        }

        public List<Promocao> BuscarTodos()
        {
            return _promocoes;
        }

        public void Salvar(Promocao promocao)
        {
            _promocoes.Add(promocao);
        }
    }
}
