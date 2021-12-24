using Api.Dominio;
using Api.Infraestrututra.Repositorios.RepositorioProduto;
using System.Collections.Generic;

namespace Api.Infraestrututra.Repositorios
{
    public class RepositorioDeProduto : IRepositorioDeProduto
    {
        private readonly static List<Produto> _produtos = new List<Produto>{
            new Produto(1,"PS5", 50),
            new Produto(2,"TV do Edi 32 polegadas (Modelo 2002)",30),
            new Produto(3,"Sanfona do Buxin", 10)
        };

        public Produto Buscar(int Id)
        {
            return _produtos.Find((produto) => produto.Id == Id);
        }

        public List<Produto> BuscarTodos()
        {
            return _produtos;
        }

        public void Salvar(Produto produto)
        {
            _produtos.Add(produto);
        }
    }
}
