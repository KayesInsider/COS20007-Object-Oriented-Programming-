using System;

namespace Swin_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Swin Adventure!");

          
            Console.Write("Enter player's name: ");
            string playerName = Console.ReadLine();
            Console.Write("Enter player's description: ");
            string playerDescription = Console.ReadLine();

        
            Player player = new Player(playerName, playerDescription);

           
            Item item1 = new Item(new string[] { "item1" }, "Item 1", "This is item 1");
            Item item2 = new Item(new string[] { "item2" }, "Item 2", "This is item 2");

          
            player.Inventory.Put(item1);
            player.Inventory.Put(item2);

            
            Bag bag = new Bag(new string[] { "bag" }, "Bag", "This is a bag");

            
            player.Inventory.Put(bag);

           
            Item item3 = new Item(new string[] { "item3" }, "Item 3", "This is item 3");

          
            bag.Inventory.Put(item3);

          
            while (true)
            {
                Console.Write("Enter a command (or 'quit' to exit): ");
                string command = Console.ReadLine();

                if (command == "quit")
                    break;

              
                LookCommand lookCommand = new LookCommand();
                string result = lookCommand.Execute(player, command.Split());
                Console.WriteLine(result);
            }

            Console.WriteLine("Thank you for playing Swin Adventure!");
        }
    }
}
