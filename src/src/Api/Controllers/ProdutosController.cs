using Api.Dominio;
using Api.Infraestrututra.Repositorios;
using Api.Infraestrututra.Repositorios.RepositorioProduto;
using Api.Infraestrututra.Repositorios.RepositorioPromocao;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProdutosController : ControllerBase
	{
		private readonly IRepositorioDePromocao  _repositorioPromocoes = new RepositorioDePromocoes();
		private readonly IRepositorioDeProduto _repositorioProduto = new RepositorioDeProduto();

		[HttpPut("{idDoProduto}/Promocao/{idDaPromocao}")]
		public void VincularPromocaoAoProduto(int idDaPromocao, int idDoProduto)
		{
			Promocao promocao = _repositorioPromocoes.Buscar(idDaPromocao);
			Produto produto = _repositorioProduto.Buscar(idDoProduto);

			produto.AlterarPromocao(promocao);
		}
	}
}
