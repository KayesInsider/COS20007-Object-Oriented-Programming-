using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;

        public Player(string name, string desc) :
            base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject? Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else if (_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }
            else
            {
                return null;
            }
            
        }

        public override string FullDesciption
        {
           
            get
            {
                return $"{Name}, you are carrying:\n" + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }

    }
}
