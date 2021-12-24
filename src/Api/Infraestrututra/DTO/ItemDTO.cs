using Api.Dominio;
using Api.Infraestrututra.Repositorios;

namespace Api.Infraestrututra.DTO
{
    public class ItemDTO
    {
        public int IdDoProduto { get; set; }
        public int Quantidade { get; set; }


        public Item Converter(IRepositorio<Produto,int> repositorioDeProdutos)
        {
            Produto produto = repositorioDeProdutos.Buscar(this.IdDoProduto);

            return new Item(produto, Quantidade);
        }

    }
}
