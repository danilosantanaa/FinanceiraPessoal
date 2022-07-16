using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceiraPessoal.Shared.Models {
	public class SalarioMensal {

		#region DADOS
		[Key]
		public int ID { get; set; }

		[Range(0.01, double.MaxValue, ErrorMessage = "Deve informar no mínimo o valor {2}")]
		public double Valor { get; set; }
		public DateTime DataReceber { get; set; }
		public bool Ativo { set; get; }
		#endregion
	}
}
