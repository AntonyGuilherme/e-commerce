namespace Api.Dominio
{
    public class Promocao
    {
        public int Id { get; }
        private readonly int quantidadeRecebida;

        public Promocao(int id,int quantidadeRecebida)
        {
            this.Id = id;
            this.quantidadeRecebida = quantidadeRecebida;
        }

        public decimal GetValorPromocional(Produto produto,int quantidade)
        {
            return this.GetValorComPromocao(produto,quantidade) + this.GetValorSemPromocao(produto,quantidade);
        }

        private decimal GetValorComPromocao(Produto produto, int quantidade)
        {
          return  this.GetQuantidadePromocional(quantidade) * this.GetPrecoPromocionalDoProduto(produto);
        }

        private decimal GetValorSemPromocao(Produto produto,int quantidade)
        {
            return produto.Preco * this.GetQuantidadeNaoPromocional(quantidade);
        }

        protected virtual decimal GetPrecoPromocionalDoProduto(Produto produto)
        {
            return produto.Preco;
        }

        private int GetQuantidadePromocional(int quantidade)
        {
            return quantidade / this.quantidadeRecebida;
        }

        private int GetQuantidadeNaoPromocional(int quantidade)
        {
            return quantidade % this.quantidadeRecebida;
        }

     }
}
