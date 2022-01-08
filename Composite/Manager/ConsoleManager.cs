using Composite.Leaf;
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
            SendMessageToUser("1 - Lister l'inventaire complet");
            SendMessageToUser("2 - Lister les armes dans l'inventaire");
            SendMessageToUser("3 - Ajouter une arme dans l'inventaire");
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

                case "2":
                    PrintWeapon();
                    break;

                case "3":
                    AddWeapon();
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

        private void PrintWeapon()
        {
            PrintSeparator();
            SendMessageToUser("Liste des armes dans l'inventaire :");
            _inventory.DisplayWeaponName();
        }

        private void AddWeapon()
        {
            PrintSeparator();
            string weaponComposite = string.Empty;
            do
            {
                SendMessageToUser("Quelle type d'arme ajouter ?");
                SendMessageToUser("1 - Arme avec une lame");
                SendMessageToUser("2 - Arme contondante");
                weaponComposite = Console.ReadLine();
            } while (!weaponComposite.Equals("1") && !weaponComposite.Equals("2"));

            switch (weaponComposite)
            {
                case "1":
                    string weaponType = string.Empty;
                    
                    do
                    {
                        SendMessageToUser("Quelle arme ?");
                        SendMessageToUser("1 - Couteau");
                        SendMessageToUser("2 - Épée");
                        weaponType = Console.ReadLine();
                    } while (!weaponType.Equals("1") && !weaponType.Equals("2"));

                    string weaponName = null;

                    do
                    {
                        SendMessageToUser("Quelle est son nom ?");
                        weaponName = Console.ReadLine();

                    } while (String.IsNullOrEmpty(weaponName));

                    
                    if (weaponType.Equals("1"))
                    {
                        Knife knifeToCreate = new Knife(weaponName);
                        _inventory.AddWeaponInInventory(knifeToCreate);
                    }
                    else
                    {
                        Sword swordToCreate = new Sword(weaponName);
                        _inventory.AddWeaponInInventory(swordToCreate);
                    }
;                    break;

                case "2":
                    string weaponType2 = string.Empty;

                    do
                    {
                        SendMessageToUser("Quelle arme ?");
                        SendMessageToUser("1 - Batte de baseball");
                        SendMessageToUser("2 - Marteau");
                        weaponType2 = Console.ReadLine();
                    } while (!weaponType2.Equals("1") && !weaponType2.Equals("2"));

                    string weaponName2 = null;

                    do
                    {
                        SendMessageToUser("Quelle est son nom ?");
                        weaponName2 = Console.ReadLine();

                    } while (String.IsNullOrEmpty(weaponName2));


                    if (weaponType2.Equals("1"))
                    {
                        BaseballBat baseballBatToCreate = new BaseballBat(weaponName2);
                        _inventory.AddWeaponInInventory(baseballBatToCreate);
                    }
                    else
                    {
                        Hammer hammerToCreate = new Hammer(weaponName2);
                        _inventory.AddWeaponInInventory(hammerToCreate);
                    }
                    break;

                default:
                    SendMessageToUser("Action inconnu");
                    break;
            }
            
        }
    }
}
