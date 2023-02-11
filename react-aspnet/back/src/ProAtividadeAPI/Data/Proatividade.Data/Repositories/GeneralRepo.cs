using ProAtividade.Data.Context;
using ProAtividade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proatividade.Data.Repositories
{
	public class GeneralRepo : IGeneralRepo
	{
		private readonly DataContext _context;

		public GeneralRepo(DataContext context)
		{
			_context = context;
		}

		public void Adicionar<T>(T entity) where T : class
		{
			_context.Add(entity);
		}

		public void Atualizar<T>(T entity) where T : class
		{
			_context.Update(entity);
		}

		public void Excluir<T>(T entity) where T : class
		{
			_context.Remove(entity);
		}

		public void ExcluirVarias<T>(T[] entity) where T : class
		{
			_context.RemoveRange(entity);
		}

		public async Task<bool> SalvarMudancasAsync()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}
