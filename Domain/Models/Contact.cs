using System;
namespace Domain.Models
{
	public class Contact : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string TelephoneNumber { get; set; }
	}
}

