using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExspenseTags
{
	public class TransActionLineDto
	{
		public DateOnly TransactionDate {  get; set; }
		public string BankCategory { get; set; }

		public string BankSubCategory { get; set; }

		public string Body { get; set; }

		public decimal Amount { get; set; }

		public decimal Balance { get; set; }

	}
}
