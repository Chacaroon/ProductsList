using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Product
{
	public class AddProductDTO
	{
		public string Name { get; set; }
		public long CategoryId { get; set; }
	}
}
