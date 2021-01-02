﻿using System;
using System.Collections.Generic;

namespace APIMilhieCreation.Models
{
	public class UnderCategory
	{
		public virtual Guid UnderCategoryId { get; set; }
		public virtual String Name { get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}