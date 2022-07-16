using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceiraPessoal.Shared.Models {
	public class Meta {

		#region CONSTRUTOR
		public Meta()
		{
			Descricao = Observacao = String.Empty;
		}
		#endregion

		#region DADOS
		public int ID { get; set; }
		public string Descricao { get; set; }
		public double ValorMeta { get; set; }
		public string Observacao { get; set; }
		public bool Ativo { get; set;}
		public DateTime DataCriacao { get; set; }
		public DateTime DataMeta { get; set; }
		#endregion
		
		// Criar um Model de Usuario?
	}
}
