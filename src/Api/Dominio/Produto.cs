namespace Api.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        private Promocao PromocaoAtiva;

        public Produto(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public void AlterarPromocao(Promocao promocao)
        {
            this.PromocaoAtiva = promocao;
        }

        public Promocao GetPromocaoAtiva()
        {
            return this.PromocaoAtiva;
        }

        public decimal GetValor(int quantidade)
        {
            if (this.PromocaoAtiva != null)
            {
                return this.PromocaoAtiva.GetValorPromocional(this,quantidade);
            }

            return this.Preco * quantidade;

        }



    }
}
