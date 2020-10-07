using System;
using System.Collections.Generic;
using System.Globalization;

namespace RestaurantMenu
{
	public class MenuItem
	{
		private double price;
		private string description;
		private string category;
		private Boolean isNew;

		public MenuItem(double price, string description, string category, Boolean isNew)
		{
			this.Price = price;
			this.Description = description;
			this.Category = category;
			this.IsNew = isNew;
		}
		public MenuItem(string description, string category) : this(0, description, category, false)
		{ }

		public double Price { get => price; set => price = value; }
		public string Description { get => description; set => description = value; }
		public string Category { get => category; set => category = value; }
		public bool IsNew { get => isNew; set => isNew = value; }
	}
}
