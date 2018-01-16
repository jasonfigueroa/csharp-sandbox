using System.Collections.Generic;

namespace hwapp
{
    internal class Fleet
    {
        private List<Car> inventory;

        public Fleet()
        {
            this.inventory = new List<Car>();
        }

        public List<Car> Inventory 
        {
            get{ return this.inventory; }  
        }
    }
}