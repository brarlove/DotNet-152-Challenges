using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class MenuRepo
    {
        public MenuRepo()
        { }
        //list of menu
        public List<MenuItem> menuList = new List<MenuItem>();

        //methods
        public void addMenuToList(MenuItem item)
        {
            menuList.Add(item);
        }

        public void removeMenuFromList(MenuItem item)
        {
            menuList.Remove(item);
        }

        public List<MenuItem> showMenuList()
        {
            return menuList;
        }
    }
}
