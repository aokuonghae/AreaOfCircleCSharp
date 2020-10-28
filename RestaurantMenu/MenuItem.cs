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
			this.price = price;
			this.description = description;
			this.category = category;
			this.isNew = isNew;
		}
		public MenuItem(string description, string category) : this(0, description, category, false)
		{ }

		public double Price { get => price; set => price = value; }
		public string Description { get => description; set => description = value; }
		public string Category { get => category; set => category = value; }
		public bool IsNew { get => isNew; set => isNew = value; }

		public string IsItemNew()
        {
			return isNew ? "This item is new!" : "This item is not new.";
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   description == item.description &&
                   category == item.category ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(description);
        }
    }

}
