using System.Collections.Generic;

namespace Api.Infraestrututra.Repositorios
{
    public interface IRepositorio<T,TipoDoID>
    {
        void Salvar(T Entidade);
        List<T> BuscarTodos();
        T Buscar(TipoDoID Id);

    }
}
