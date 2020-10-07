using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
	public class Menu
	{
		private DateTime lastUpdated;
		private List<MenuItem> items;

		public Menu(DateTime lastUpdated, List<MenuItem> items)
		{
			this.lastUpdated = lastUpdated;
			this.items = items;
		}

		public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }
		public List<MenuItem> Items { get => items; set => items = value; }
	}
}