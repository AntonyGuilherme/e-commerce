using System.Collections.Generic;
using System.Linq;

namespace Api.Dominio
{
    public static class Carrinho
    {
        public static List<Item> _itens = new List<Item>();

        public static void AdicionarItem(Item item)
        {
            Item itemEncontrado = _itens.Find((_item) => _item.Produto.Id == item.Produto.Id);

            if(itemEncontrado != null)
            {
                itemEncontrado.IncrementarQuantidade(item.Quantidade);
                return;
            }

            _itens.Add(item);
        }

        public static decimal CalcularTotal()
        {
            return _itens.Sum((item) => item.CalcularValor());
        }

        public static void LimparItens()
        {
            _itens.Clear();
        }


    }
}
