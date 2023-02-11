using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.Data.Context;
using ProAtividade.Domain.Entites;
using ProAtividade.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAtividadeAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AtividadeController : ControllerBase
	{
		private readonly IAtividadeService _atividadeService;

		public AtividadeController(IAtividadeService atividadeService)
		{
			_atividadeService = atividadeService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				var atividades = await _atividadeService.PegarTodasAtividadesAsync();
				if (_atividadeService == null)
				{
					return NoContent();
				}

				return Ok(atividades);
			}
			catch (Exception e)
			{
				return this.StatusCode(StatusCodes.Status500InternalServerError,
					$"Erro ao tentar recuperar Atividades. Erro: {e.Message}");
			}
		}
		
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			try
			{
				var atividade = await _atividadeService.PegarAtividadePorIdAsync(id);
				if (_atividadeService == null)
				{
					return NoContent();
				}

				return Ok(atividade);
			}
			catch (Exception e)
			{
				return this.StatusCode(StatusCodes.Status500InternalServerError,
					$"Erro ao tentar recuperar Atividade de id: {id}. Erro: {e.Message}");
			}
		}
		
		[HttpPost]
		public async Task<IActionResult> Post(Atividade model)
		{
			try
			{
				var atividade = await _atividadeService.AdicionarAtividade(model);
				if (_atividadeService == null)
				{
					return NoContent();
				}

				return Ok(atividade);
			}
			catch (Exception e)
			{
				return this.StatusCode(StatusCodes.Status500InternalServerError,
					$"Erro ao tentar adicionar Atividade. Erro: {e.Message}");
			}

		}
		
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id,Atividade model)
		{
			try
			{
				if(model.Id != id)
				{
					this.StatusCode
						(StatusCodes.Status409Conflict, "Você está tentando atualizar a atividade errada.");
				}

				var atividade = await _atividadeService.AtualizarAtividade(model);
				if (_atividadeService == null)
				{
					return NoContent();
				}

				return Ok(atividade);
			}
			catch (Exception e)
			{
				return this.StatusCode(StatusCodes.Status500InternalServerError,
					$"Erro ao tentar atualizar Atividade com id: {id}. Erro: {e.Message}");
			}
		}
		
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			try
			{
				var atividade = await _atividadeService.PegarAtividadePorIdAsync(id);
				if (_atividadeService == null)
				{
					this.StatusCode
						(StatusCodes.Status409Conflict, "Você está tentando excluir uma atividade que não existe.");
					return NoContent();
				}
				
				if(await _atividadeService.ExcluirAtividade(id))
				{
					return Ok(new { message = "Excluído." });
				}
				else
				{
					return BadRequest("Ocorreu um erro inesperado ao excluir a atividade.");
				}
				
			}
			catch (Exception e)
			{
				return this.StatusCode(StatusCodes.Status500InternalServerError,
					$"Erro ao tentar excluir Atividade com id: {id}. Erro: {e.Message}");
			}
		}
	}
}
