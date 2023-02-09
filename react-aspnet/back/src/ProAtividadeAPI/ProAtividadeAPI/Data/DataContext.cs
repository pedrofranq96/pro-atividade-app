using Microsoft.EntityFrameworkCore;
using ProAtividadeAPI.Models;

namespace ProAtividadeAPI.Data
{
	public class DataContext : DbContext
	{
		public DbSet<Atividade> Atividades { get; set; }

		public DataContext(DbContextOptions<DataContext> options): base(options) { }

	}
}
