using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAtividadeAPI.Data;
using ProAtividadeAPI.Models;
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
		private readonly DataContext _context;
		public AtividadeController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IEnumerable<Atividade> get()
		{
			return _context.Atividades;
		}
		
		[HttpGet("{id}")]
		public Atividade get(int id)
		{
			return _context.Atividades.FirstOrDefault(x=> x.Id == id);
		}
		
		[HttpPost]
		public Atividade Post(Atividade atividade)
		{
			_context.Atividades.Add(atividade);

			if (_context.SaveChanges() > 0)
			{
				return atividade;
			}
			else
			{
				throw new Exception("Atividade inválida, tente novamente.");
			}
			
		}
		
		[HttpPut("{id}")]
		public Atividade Put(int id,Atividade atividade)
		{
			if (atividade.Id != id) throw new Exception("Você está atualizando a atividade errada.");

			_context.Update(atividade);
			if (_context.SaveChanges() > 0)
			{
				return _context.Atividades.FirstOrDefault(x=> x.Id == id);
			}
			else
			{
				return new Atividade();
			}
		}
		
		[HttpDelete("{id}")]
		public bool Delete(int id)
		{
			var atividade = _context.Atividades.FirstOrDefault(x => x.Id == id);
			if (atividade == null)
			{
				throw new Exception("Atividade não exite");
			}
			_context.Remove(atividade);
			return _context.SaveChanges() > 0;
		}
	}
}
