using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        

        public Location(string name, string description, string[] ids) : base(ids, name, description)
        {
            _inventory = new Inventory();
            
        }
       
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }

            return _inventory.Fetch(id);

        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
       
    }
}
