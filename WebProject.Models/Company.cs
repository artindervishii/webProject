using System;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
	public class Company
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? name { get; set; }
		public string? StreetAdress { get; set; }
		public string? City { get; set; }
		public string? State { get; set; }
		public string? PostalCode { get; set; }
		public string? PhoneNumber { get; set; }
	}
}

