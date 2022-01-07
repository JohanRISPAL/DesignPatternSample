using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Manager
{
    internal class ConsoleManager
    {

        private Inventory _inventory;

        public ConsoleManager()
        {
            _inventory = new Inventory();
            //populate the inventory
            Knife knife = new Knife("Couteau à beurre");
            Knife knife2 = new Knife("Couteau à fromage");
            Knife knife3 = new Knife("Couteau à steak");

            _inventory.AddWeaponInInventory(knife);
            _inventory.AddWeaponInInventory(knife2);
            _inventory.AddWeaponInInventory(knife3);

            HealthPotion healthPotion = new HealthPotion("Potion de vie");
            HealthPotion healthPotion2 = new HealthPotion("Potion de vie II");

            _inventory.AddConsumableInInventory(healthPotion);
            _inventory.AddConsumableInInventory(healthPotion2);
        }

        internal void PrintApplicationTitle()
        {
            PrintSeparator();
            Console.WriteLine("Bienvenue dans mon application de gestion\nd'inventaire basée sur le pattern composite !");
            PrintSeparator();
        }

        internal string PrintMenu()
        {
            PrintSeparator();
            Console.WriteLine("Que faire ?");
            Console.WriteLine("1 - Lister l'inventaire complet");
            Console.WriteLine("10 - Quitter");

            return Console.ReadLine();
        }

        internal void PrintSeparator()
        {
            Console.WriteLine("==============================================");
        }

        internal void SendMessageToUser(string message)
        {
            Console.WriteLine(message);
        }

        internal bool ManageUserAction(string userAction)
        {
            switch (userAction)
            {
                case "1":
                    PrintInventory();
                    break;

                case "10":
                    Console.WriteLine("Au revoir !");
                    return false;

                default:
                    Console.WriteLine("Action inconnu");
                    break;
            }

            return true;
        }

        private void PrintInventory()
        {
            PrintSeparator();
            SendMessageToUser("Liste de l'inventaire complet :");
            _inventory.DisplayName();
        }
    }
}
