using Microsoft.EntityFrameworkCore;
using Proatividade.Data.Mappings;
using ProAtividade.Domain.Entites;

namespace ProAtividade.Data.Context
{
	public class DataContext : DbContext
	{
		public DbSet<Atividade> Atividades { get; set; }

		public DataContext(DbContextOptions<DataContext> options): base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AtividadeMap());
		}

	}
}
