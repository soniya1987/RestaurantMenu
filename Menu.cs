using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Menus { get; set; }

        public Menu(List<MenuItem> menus)
        {
            Menus = menus;
        }
    }
}
