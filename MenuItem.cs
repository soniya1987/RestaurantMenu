using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public float Price { get; set; }

        public string Description { get; set; }

        public Category MenuCategory { get; set; }

        public bool IsNew { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
