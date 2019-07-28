using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
	public class Product : Entity
	{
		public string Name { get; set; }

		public long CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
