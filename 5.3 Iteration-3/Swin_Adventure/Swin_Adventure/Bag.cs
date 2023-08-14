using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Swin_Adventure
{
    public class Bag : Item
    {
        private Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public override string FullDesciption 
        {
            get
            {
                return $"In the {this.Name} you can see:\n" + _inventory.ItemList;
            }
            
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }

        public string FullDescription { get; set; }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }
    }
}
