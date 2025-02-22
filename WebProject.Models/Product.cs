﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Models
{
	public class Product
	{

		[Key]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Company { get; set; }

		[Required]
		[Display(Name = "List Price")]
		[Range(1, 2000)]
		public double ListPrice { get; set; }

		[Required]
		[Display(Name = "Price for 1-20")]
		[Range(1, 2000)]
		public double Price { get; set; }

		[Required]
		[Display(Name = "Price for 20+")]
		[Range(1, 2000)]
		public double Price20 { get; set; }

		[Required]
		[Display(Name = "Price for 50+")]
		[Range(1, 2000)]
		public double Price50 { get; set; }


		public int CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		[ValidateNever]
		public Category Category { get; set; }


		[ValidateNever]
		public string ImageUrl { get; set; }


	}
}
