using Api.Dominio;
using Api.Infraestrututra.DTO;
using Api.Infraestrututra.Repositorios;
using Api.Infraestrututra.Repositorios.RepositorioProduto;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CarrinhoController : ControllerBase
	{
		private readonly IRepositorioDeProduto _repositorioDeProdutos =  new RepositorioDeProduto();
		

		[HttpPost("Item")]
		public void AdicionarItem(ItemDTO itemDTO)
		{
			Item itemCriado = itemDTO.Converter(_repositorioDeProdutos);
			Carrinho.AdicionarItem(itemCriado);
		}

		[HttpPost("LimparCarrinho")]
		public void LimparCarrinho()
		{
			Carrinho.LimparItens();
		}

		[HttpGet("Total")]
		public decimal ObterTotalDoCarrinho()
		{
			return Carrinho.CalcularTotal();
		}
	}

}
