using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceiraPessoal.Shared.Models {
	public class Financa {

		#region CONSTRUTOR
		public Financa() {
			Descricao = String.Empty;
		}

		#endregion

		#region DADOS
		[Key]
		public int ID { get; set; }

		[Display(Name = "Descrição")]
		[Required(ErrorMessage = "O Campo {1} deve ser informado!")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Informe pelo menos {3} dos campo {1}")]
		public string Descricao { get; set; }

		[Range(0.01, double.MaxValue, ErrorMessage = "Deve informar o valor entre {2} e {3} do campo {1}")]
		public double Valor {get; set;}

		[Display(Name = "Tipo")]
		[Range(1, 2, ErrorMessage = "Deve informar se é do tipo receber ou pagar")]
		public int TipoID { get; set; }

		[Display(Name = "Data Operação")]
		[Required(ErrorMessage = "O campo {1} deve ser informado")]
		public DateTime DataOperacao { get; set; }
		public DateTime DataCadastro { get; set; }
		public bool Ativo { get; set; }
		#endregion

		#region FOREIGN KEY 
		[ForeignKey("TipoGastoID")]
		public int TipoGastoID { get; set; }
		public TipoGasto TipoGasto { get; set; }
		#endregion
	}
}
