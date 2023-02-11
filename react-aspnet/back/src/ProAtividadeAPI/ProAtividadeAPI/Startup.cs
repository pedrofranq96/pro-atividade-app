using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Proatividade.Data.Repositories;
using ProAtividade.Data.Context;
using ProAtividade.Domain.Interfaces.Repositories;
using ProAtividade.Domain.Interfaces.Services;
using ProAtividade.Domain.Services;
using System.Text.Json.Serialization;

namespace ProAtividadeAPI
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<DataContext>(
				options => options.UseSqlServer(Configuration.GetConnectionString("Default"))
				);

			services.AddScoped<IAtividadeRepo, AtividadeRepo>();
			services.AddScoped<IAtividadeService, AtividadeService>();
			services.AddScoped<IGeneralRepo, GeneralRepo>();
			
			services.AddControllers().AddJsonOptions(options => 
			{
				options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
			});
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProAtividadeAPI", Version = "v1" });
			});
			services.AddCors();
		}

	
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProAtividadeAPI v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();
			app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()); //config para liberar a api no front

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
