using System.Threading.Tasks;

namespace ProAtividade.Domain.Interfaces.Repositories
{
	public interface IGeneralRepo
	{
		void Adicionar<T>(T entity) where T : class;
		void Atualizar<T>(T entity) where T : class;
		void Excluir<T>(T entity) where T : class;
		void ExcluirVarias<T>(T[] entity) where T : class;

		Task<bool> SalvarMudancasAsync();
	}
}
