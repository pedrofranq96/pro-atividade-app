﻿using System;

namespace ProAtividade.Domain.Entites
{
	public class Atividade
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public DateTime DataCriacao { get; set; }
		public DateTime? DataConclusao { get; set; }

		public Prioridade Prioridade { get; set; }


		public Atividade()
		{
			DataCriacao = DateTime.Now;
			DataConclusao = null;
		}

		public Atividade(int id, string titulo, string descricao) : this()
		{
			Id = id;
			Titulo = titulo;
			Descricao = descricao;
		}

		public void Concluir()
		{
			if(DataConclusao.Equals(""))
			{
				DataConclusao = DateTime.Now;
			}
			else
			{
				throw new Exception($"Atividade já concluída em: {DataConclusao?.ToString("dd/MM/yyyy hh:mm")}");
			}
		}
	}
}
