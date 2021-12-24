namespace Api.Dominio
{
    public class Item
    {
        public Produto Produto { get; }
        public int Quantidade { get; private set; }

        public Item(Produto produto, int quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
        }

        public decimal CalcularValor()
        {
            return this.Produto.GetValor(this.Quantidade);
        }

        public void IncrementarQuantidade(int quantidade)
        {
            this.Quantidade += quantidade;
        }

    }
}
