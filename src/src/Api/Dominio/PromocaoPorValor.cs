namespace Api.Dominio
{
    public class PromocaoPorValor : Promocao
    {
        private decimal valorPromocional;
        public PromocaoPorValor(int id,int quantidadeRecebida, decimal valorPromocional) : 
            base(id,quantidadeRecebida)
        {
            this.valorPromocional = valorPromocional;
        }

        protected override decimal GetPrecoPromocionalDoProduto(Produto _)
        {
            return this.valorPromocional;
        }

    }
}
