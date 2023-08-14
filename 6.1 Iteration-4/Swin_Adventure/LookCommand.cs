using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
   public class LookCommand : Command
    {
        public LookCommand() : base(ids: new string[]{"look"})
        {
        }
        public override string Execute(Player p, string[] text)
        {
            if (text.Length != 3 && text.Length != 5)
            {
                return "I don't know how to look like that\n";
            }

            if (text[0] != "look")
            {
                return "Error in look input\n";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?\n";
            }

            if (text.Length == 5 && text[3] != "in")
            {
                return "What do you want to look in?\n";
            }

            string itemToFind = text[2];

            if (text.Length == 3)
            {
                return LookAtIn(itemToFind, p as IHaveInventory);
            }

            string placeToLookIn = text[4];
            IHaveInventory container = FetchContainer(p, placeToLookIn);

            if (container is null)
            {
                return $"I cannot find the {placeToLookIn}\n";
            }

            return LookAtIn(itemToFind, container);
        }



        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            if (p.AreYou(containerId))
            {
                return p;
            }

            GameObject container = p.Locate(containerId);
            if (container is IHaveInventory inventoryContainer)
            {
                return inventoryContainer;
            }

            return null;
        }



        private string LookAtIn(string thingId, IHaveInventory container)
        {
            GameObject thing = container.Locate(thingId);
            if (thing != null)
            {
                return thing.FullDescription;
            }

            return $"I can't find the {thingId}";
        }

     

    }


}
