using ProAtividade.Domain.Entites;
using System.Threading.Tasks;

namespace ProAtividade.Domain.Interfaces.Repositories
{
	public interface IAtividadeRepo :IGeneralRepo
	{
		Task<Atividade[]> PegaTodasAsync();
		Task<Atividade> PegaPorIdAsync(int id);
		Task<Atividade> PegaPorTituloAsync(string titulo);

	}
}
