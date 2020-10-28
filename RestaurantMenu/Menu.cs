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

		public List<MenuItem> AddItem (MenuItem item)
        {
			items.Add(item);
			return items;
        }

 
        public List<MenuItem> RemoveItem(MenuItem item)
        {
			int index = -1;
			for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Equals(item))
                {
                    index = i;
                }
            }
            items.RemoveAt(index);
            return items;
        }

		public string getUpdated()
        {
			return $"This menu was last updated on ${lastUpdated}";
        }

		public void PrintMenu()
        {
            foreach (MenuItem item in items)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.IsItemNew());
            }
        }

	}
}