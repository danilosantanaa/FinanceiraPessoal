using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceiraPessoal.Shared.Models {
	public class TipoGasto {

		#region CONSTRUTOR
		public TipoGasto()
		{
			Descricao = String.Empty;
		}
		#endregion

		#region DADOS
		[Key]
		public int ID { get; set; }

		[Required(ErrorMessage ="Deve informa {1}.")]
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }
		public bool Ativo { get; set; }

		[Display(Name = "Data Criação")]
		public DateTime DataCriacao { get; set; }
		#endregion

		#region LISTAS
		public List<Financa> Financas { get; set; }
		#endregion
	}
}
